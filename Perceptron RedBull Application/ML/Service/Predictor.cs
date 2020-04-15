using Microsoft.ML;
using Perceptron_RedBull_Application.ML.CustomType;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Perceptron_RedBull_Application.ML.Service
{
    class Predictor
    {
        public static ModelOutput ClassifySingleImage(string imagePath)
        {
            Console.WriteLine(imagePath);

            var projectDirectory = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, "../../../"));
            var workspaceRelativePath = Path.Combine(projectDirectory, "ML", "Workspace");

            MLContext mlContext = new MLContext();

            //IEnumerable<ImageData> images = LoadImagesFromDirectory(folder: assetsRelativePath, useFolderNameAsLabel: true);
            IEnumerable<ImageData> image = LoadImage(file: imagePath);

            if (image.Contains(null))
                return null;

            IDataView imageData = mlContext.Data.LoadFromEnumerable(image);

            var preprocessingPipeline = mlContext.Transforms.Conversion.MapValueToKey(
                    inputColumnName: "Label",
                    outputColumnName: "LabelAsKey")
                .Append(mlContext.Transforms.LoadRawImageBytes(
                    outputColumnName: "Image",
                    imageFolder: Directory.GetParent(imagePath).Name,
                    inputColumnName: "ImagePath"));

            IDataView data = preprocessingPipeline
                                .Fit(imageData)
                                .Transform(imageData);

            DataViewSchema modelSchema;
            ITransformer model = mlContext.Model.Load(workspaceRelativePath + "\\redbull-model.zip", out modelSchema);

            PredictionEngine<ModelInput, ModelOutput> predictionEngine = mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(model);

            try
            {
                ModelInput inputImage = mlContext.Data.CreateEnumerable<ModelInput>(data, reuseRowObject: true).First();

                ModelOutput prediction = predictionEngine.Predict(inputImage);

                Console.WriteLine("Classifying single image");
                OutputPrediction(prediction);

                return prediction;
            }
            catch (InvalidOperationException)
            {
                Console.WriteLine("Invalid Operation Exception!");
                return null;
            }
        }

        public static IEnumerable<ModelOutput> ClassifyImages(MLContext mlContext, IDataView data, ITransformer trainedModel)
        {
            IDataView predictionData = trainedModel.Transform(data);

            IEnumerable<ModelOutput> predictions = mlContext.Data.CreateEnumerable<ModelOutput>(predictionData, reuseRowObject: true).Take(10);

            Console.WriteLine("Classifying multiple images");
            foreach (var prediction in predictions)
            {
                OutputPrediction(prediction);
            }

            return predictions;
        }

        private static void OutputPrediction(ModelOutput prediction)
        {
            string imageName = Path.GetFileName(prediction.ImagePath);
            Console.WriteLine($"Image: {imageName} | Actual Value: {prediction.Label} | Predicted Value: {prediction.PredictedLabel}");
        }

        public static IEnumerable<ImageData> LoadImagesFromDirectory(string folder, bool useFolderNameAsLabel = true)
        {
            var files = Directory.GetFiles(folder, "*", searchOption: SearchOption.AllDirectories);

            foreach (var file in files)
            {
                if ((Path.GetExtension(file) != ".jpg") && (Path.GetExtension(file) != ".png"))
                    continue;

                var label = Path.GetFileName(file);

                if (useFolderNameAsLabel)
                    label = Directory.GetParent(file).Name;
                else
                {
                    for (int index = 0; index < label.Length; index++)
                    {
                        if (!char.IsLetter(label[index]))
                        {
                            label = label.Substring(0, index);
                            break;
                        }
                    }
                }

                yield return new ImageData()
                {
                    ImagePath = file,
                    Label = label
                };
            }
        }

        public static IEnumerable<ImageData> LoadImage(string file, bool useFolderNameAsLabel = false)
        {
            if ((Path.GetExtension(file) != ".jpg") && (Path.GetExtension(file) != ".png"))
                yield return null;

            var label = Path.GetFileName(file);

            if (useFolderNameAsLabel)
                label = Directory.GetParent(file).Name;
            else
            {
                for (int index = 0; index < label.Length; index++)
                {
                    if (!char.IsLetter(label[index]))
                    {
                        label = label.Substring(0, index);
                        break;
                    }
                }
            }

            yield return new ImageData()
            {
                ImagePath = file,
                Label = label
            };
        }
    }
}
