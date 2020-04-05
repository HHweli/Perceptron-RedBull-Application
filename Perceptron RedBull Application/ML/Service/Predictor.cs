using Perceptron_RedBull_Application.ML.CustomType;
using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Perceptron_RedBull_Application.ML.Const;

namespace Perceptron_RedBull_Application.ML.Service
{
    class Predictor
    {
        public static string Predict(PredictionEngine<ImageData, ImagePrediction> engine)
        {
            string[] files = Directory.GetFiles(ML_Path.TEST_DATA_SET, "*", SearchOption.AllDirectories);

            IEnumerable<ImageData> images = files.Select(file => new ImageData
            {
                ImagePath = file,
                Label = Directory.GetParent(file).Name
            }).ToArray();

            VBuffer<ReadOnlyMemory<char>> keys = default;
            engine.OutputSchema["LabelKey"].GetKeyValues(ref keys);

            var originalLabels = keys.DenseValues().ToArray();

            foreach (var image in images)
            {
                var prediction = engine.Predict(image);
                var labelIndex = prediction.PredictedLabel;

                Console.WriteLine($"Image: {Path.GetDirectoryName(image.ImagePath)}, Score: {prediction.Score.Max()}" +
                    $"Predicted Label: {originalLabels[labelIndex]}");
            }

            return "";
        }
    }
}
