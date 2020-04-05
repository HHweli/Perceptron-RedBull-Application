using Perceptron_RedBull_Application.ML.CustomType;
using Microsoft.ML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Perceptron_RedBull_Application.ML.Service
{
    class ModelTrainer
    {
        public static PredictionEngine<ImageData, ImagePrediction> Train(string directoryPath)
        {
            string[] files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);

            IEnumerable<ImageData> images = files.Select(file => new ImageData
            {
                ImagePath = file,
                Label = Directory.GetParent(file).Name
            }).ToArray();

            MLContext context = new MLContext();

            IDataView imageData = context.Data.LoadFromEnumerable(images);
            var imageDataShuffle = context.Data.ShuffleRows(imageData);

            var testTrainData = context.Data.TrainTestSplit(imageDataShuffle, testFraction: 0.2);

            var validateData = context.Transforms.Conversion.MapValueToKey("LabelKey", "Label",
                keyOrdinality: Microsoft.ML.Transforms.ValueToKeyMappingEstimator.KeyOrdinality.ByValue)
                .Fit(testTrainData.TestSet)
                .Transform(testTrainData.TestSet);

            var pipeline = context.Transforms.Conversion.MapValueToKey("LabelKey", "Label",
                keyOrdinality: Microsoft.ML.Transforms.ValueToKeyMappingEstimator.KeyOrdinality.ByValue)
                .Append(context.Model.ImageClassification(
                    "ImagePath",
                    "LabelKey",
                    arch: Microsoft.ML.Vision.ImageClassificationTrainer.Architecture.ResnetV2101,
                    epoch: 100,
                    batchSize: 10
                 ));

            var model = pipeline.Fit(testTrainData.TrainSet);

            var predictions = model.Transform(testTrainData.TestSet);

            var metrics = context.MulticlassClassification.Evaluate(predictions, labelColumnName: "LabelKey",
                predictedLabelColumnName: "PredictedLabel");

            Console.WriteLine($"Log loss - {metrics.LogLoss}");

            return context.Model.CreatePredictionEngine<ImageData, ImagePrediction>(model);
        }
    }
}
