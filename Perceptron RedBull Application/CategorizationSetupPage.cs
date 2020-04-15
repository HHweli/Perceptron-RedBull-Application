using Microsoft.ML;
using Microsoft.ML.Transforms.Image;
using Perceptron_RedBull_Application.ML.CustomType;
using Perceptron_RedBull_Application.ML.Service;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Perceptron_RedBull_Application
{
    public partial class CategorizationSetupPage : Form
    {
        public const int rowCount = 13, columnCount = 13;

        public const int featuresPerBox = 5;

        private static readonly (float x, float y)[] boxAnchors = { (0.573f, 0.677f), (1.87f, 2.06f), (3.34f, 5.47f), (7.88f, 3.53f), (9.77f, 9.17f) };

        public static string[] predictingImgPaths;

        static string assetsRelativePath = @"../../../ML/assets";
        static string assetsPath = GetAbsolutePath(assetsRelativePath);
        static string modelFilePath = Path.Combine(assetsPath, "Model", "model.onnx");
        static string imagesFolder = Path.Combine(assetsPath, "images");
        static string outputFolder = Path.Combine(assetsPath, "images", "output");

        public CategorizationSetupPage()
        {
            InitializeComponent();
        }

        private void categorizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap testImage;
                var context = new MLContext();

                var emptyData = new List<ImageInput>();

                var data = context.Data.LoadFromEnumerable(emptyData);

                var pipeline = context.Transforms.ResizeImages(resizing: ImageResizingEstimator.ResizingKind.Fill, outputColumnName: "data", imageWidth: ImageSettings.imageWidth, imageHeight: ImageSettings.imageHeight, inputColumnName: nameof(ImageInput.Image))
                                .Append(context.Transforms.ExtractPixels(outputColumnName: "data"))
                                .Append(context.Transforms.ApplyOnnxModel(modelFile: modelFilePath, outputColumnName: "model_outputs0", inputColumnName: "data"));

                var model = pipeline.Fit(data);

                var predictionEngine = context.Model.CreatePredictionEngine<ImageInput, ImagePredictions>(model);

                string[] labels = new string[1] { "can" };

                using (var stream = new FileStream(Commons.Resource.PREDICTING_IMAGE_PATH, FileMode.Open))
                {
                    testImage = (Bitmap)Image.FromStream(stream);
                }

                var prediction = predictionEngine.Predict(new ImageInput { Image = testImage });

                var boundingBoxes = ParseOutputs(prediction.PredictedLabels, labels);

                var originalWidth = testImage.Width;
                var originalHeight = testImage.Height;

                if (boundingBoxes.Count > 1)
                {
                    var maxConfidence = boundingBoxes.Max(b => b.Confidence);
                    var topBoundingBox = boundingBoxes.FirstOrDefault(b => b.Confidence == maxConfidence);

                    boundingBoxes.Clear();

                    boundingBoxes.Add(topBoundingBox);
                }

                DrawBoundingBox(imagesFolder, outputFolder, Commons.Resource.PREDICTING_IMAGE_NAME, boundingBoxes);

                Console.WriteLine("========= End of Object Detection ========");

                predictingImgPaths = Directory.GetFiles(Path.Combine(outputFolder, "crp"));

                for (int i = 0; i < predictingImgPaths.Length; i++)
                {
                    ModelOutput predict = Predictor.ClassifySingleImage(predictingImgPaths[i], ModelTrainer.Train());

                    string predictedLabel = predict != null ? predict.PredictedLabel : "";

                    Console.WriteLine("debug -> " + predictedLabel);
                    if (predictedLabel.Equals(Commons.Resource.SUGAR_FREE))
                        Commons.Resource.SUGAR_FREE_COUNT += 1;
                    else if (predictedLabel.Equals(Commons.Resource.REGULAR))
                        Commons.Resource.REGULAR_COUNT += 1;
                    else
                        Commons.Resource.UNIDENTIFIED_COUNT += 1;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            Form resultPage = new PredictionResultPage();
            this.Hide();
            resultPage.ShowDialog();
            this.Close();
        }

        private void catSetupBackBtn_Click(object sender, EventArgs e)
        {
            Form homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void addPredictImgBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image files ((*.jpg, *.png) | *.jpg; *.png";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // Getting the image file name from path
                String[] paths = openFile.FileName.Split('\\');
                String fileName = paths[paths.Length - 1];

                Image image = (Image)Image.FromFile(openFile.FileName).Clone();
                image.Save(Path.Combine(imagesFolder, fileName));
                image.Dispose();

                // Saving the predicting image for later use
                Commons.Resource.PREDICTING_IMAGE = new Bitmap(openFile.FileName);

                // Saving the predicting image name for later use
                Commons.Resource.PREDICTING_IMAGE_NAME = fileName;

                // Saving the predicting image path
                Commons.Resource.PREDICTING_IMAGE_PATH = Path.Combine(imagesFolder, fileName);

                predictingImgNameLbl.Text = Commons.Resource.PREDICTING_IMAGE_NAME;
                predictingImageBox.Image = new Bitmap(openFile.FileName);

                openFile.Dispose();

                categorizeBtn.Enabled = true;
            }
        }

        public static string GetAbsolutePath(string relativePath)
        {
            FileInfo _dataRoot = new FileInfo(typeof(Program).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativePath);

            return fullPath;
        }

        private static void DrawBoundingBox(string inputImageLocation, string outputImageLocation, string imageName, IList<BoundingBox> filteredBoundingBoxes)
        {
            Image image = Image.FromFile(Path.Combine(inputImageLocation, imageName));

            var originalImageHeight = image.Height;
            var originalImageWidth = image.Width;

            int i = 0;
            foreach (var box in filteredBoundingBoxes)
            {
                var x = (uint)Math.Max(box.Dimensions.X, 0);
                var y = (uint)Math.Max(box.Dimensions.Y, 0);
                var width = (uint)Math.Min(originalImageWidth - x, box.Dimensions.Width);
                var height = (uint)Math.Min(originalImageHeight - y, box.Dimensions.Height);

                x = (uint)originalImageWidth * x / ImageSettings.imageWidth;
                y = (uint)originalImageHeight * y / ImageSettings.imageHeight;
                width = (uint)originalImageWidth * width / ImageSettings.imageWidth;
                height = (uint)originalImageHeight * height / ImageSettings.imageHeight;

                string text = box.Description;

                using (Graphics thumbnailGraphic = Graphics.FromImage(image))
                {
                    thumbnailGraphic.CompositingQuality = CompositingQuality.HighQuality;
                    thumbnailGraphic.SmoothingMode = SmoothingMode.HighQuality;
                    thumbnailGraphic.InterpolationMode = InterpolationMode.HighQualityBicubic;

                    // Define Text Options
                    Font drawFont = new Font("Arial", 12, FontStyle.Bold);
                    SizeF size = thumbnailGraphic.MeasureString(text, drawFont);
                    SolidBrush fontBrush = new SolidBrush(Color.Black);
                    Point atPoint = new Point((int)x, (int)y - (int)size.Height - 1);

                    // Define BoundingBox options
                    Pen pen = new Pen(Color.Red, 3.2f);
                    SolidBrush colorBrush = new SolidBrush(Color.Red);

                    thumbnailGraphic.FillRectangle(colorBrush, (int)x, (int)(y - size.Height - 1), (int)size.Width, (int)size.Height);
                    thumbnailGraphic.DrawString(text, drawFont, fontBrush, atPoint);

                    // Draw bounding box on image
                    thumbnailGraphic.DrawRectangle(pen, x, y, width, height);

                    Rectangle cropRect = new Rectangle((int)x, (int)y, (int)width, (int)height);
                    Image croppedImg = new Bitmap(cropRect.Width, cropRect.Height);

                    using (Graphics g = Graphics.FromImage(croppedImg))
                    {
                        g.DrawImage(image, new Rectangle(0, 0, croppedImg.Width, croppedImg.Height), cropRect, GraphicsUnit.Pixel);
                    }

                    croppedImg.Save(Path.Combine(outputImageLocation, "crp", imageName.Substring(0, imageName.IndexOf('.')) + "-" + box.Label + i + Path.GetExtension(imageName)));
                }

                i++;
            }

            if (!Directory.Exists(outputImageLocation))
            {
                Directory.CreateDirectory(outputImageLocation);
            }

            image.Save(Path.Combine(outputImageLocation, imageName));
        }

        public static List<BoundingBox> ParseOutputs(float[] modelOutput, string[] labels, float probabilityThreshold = .5f)
        {
            var boxes = new List<BoundingBox>();

            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    for (int box = 0; box < boxAnchors.Length; box++)
                    {
                        var channel = box * (labels.Length + featuresPerBox);

                        var boundingBoxPrediction = ExtractBoundingBoxPrediction(modelOutput, row, column, channel);

                        var mappedBoundingBox = MapBoundingBoxToCell(row, column, box, boundingBoxPrediction);

                        if (boundingBoxPrediction.Confidence < probabilityThreshold)
                            continue;

                        float[] classProbabilities = ExtractClassProbabilities(modelOutput, row, column, channel, boundingBoxPrediction.Confidence, labels);

                        var (topProbability, topIndex) = classProbabilities.Select((probability, index) => (Score: probability, Index: index)).Max();

                        if (topProbability < probabilityThreshold)
                            continue;

                        boxes.Add(new BoundingBox
                        {
                            Dimensions = mappedBoundingBox,
                            Confidence = topProbability,
                            Label = labels[topIndex]
                        });
                    }
                }
            }

            return boxes;
        }

        private static BoundingBoxDimensions MapBoundingBoxToCell(int row, int column, int box, BoundingBoxPrediction boxDimensions)
        {
            const float cellWidth = ImageSettings.imageWidth / columnCount;
            const float cellHeight = ImageSettings.imageHeight / rowCount;

            var mappedBox = new BoundingBoxDimensions
            {
                X = (row + Sigmoid(boxDimensions.X)) * cellWidth,
                Y = (column + Sigmoid(boxDimensions.Y)) * cellHeight,
                Width = (float)Math.Exp(boxDimensions.Width) * cellWidth * boxAnchors[box].x,
                Height = (float)Math.Exp(boxDimensions.Height) * cellHeight * boxAnchors[box].y,
            };

            // The x,y coordinates from the (mapped) bounding box prediction represent the center
            // of the bounding box. We adjust them here to represent the top left corner.
            mappedBox.X -= mappedBox.Width / 2;
            mappedBox.Y -= mappedBox.Height / 2;

            return mappedBox;
        }

        private static BoundingBoxPrediction ExtractBoundingBoxPrediction(float[] modelOutput, int row, int column, int channel)
        {
            return new BoundingBoxPrediction
            {
                X = modelOutput[GetOffset(row, column, channel++)],
                Y = modelOutput[GetOffset(row, column, channel++)],
                Width = modelOutput[GetOffset(row, column, channel++)],
                Height = modelOutput[GetOffset(row, column, channel++)],
                Confidence = Sigmoid(modelOutput[GetOffset(row, column, channel++)])
            };
        }

        public static float[] ExtractClassProbabilities(float[] modelOutput, int row, int column, int channel, float confidence, string[] labels)
        {
            var classProbabilitiesOffset = channel + featuresPerBox;
            float[] classProbabilities = new float[labels.Length];
            for (int classProbability = 0; classProbability < labels.Length; classProbability++)
                classProbabilities[classProbability] = modelOutput[GetOffset(row, column, classProbability + classProbabilitiesOffset)];
            return Softmax(classProbabilities).Select(p => p * confidence).ToArray();
        }

        private static float Sigmoid(float value)
        {
            var k = (float)Math.Exp(value);
            return k / (1.0f + k);
        }

        private static float[] Softmax(float[] classProbabilities)
        {
            var max = classProbabilities.Max();
            var exp = classProbabilities.Select(v => Math.Exp(v - max));
            var sum = (float)exp.Sum();
            return exp.Select(v => (float)v / sum).ToArray();
        }

        private static int GetOffset(int row, int column, int channel)
        {
            const int channelStride = rowCount * columnCount;
            return (channel * channelStride) + (column * columnCount) + row;
        }
    }

    class BoundingBoxPrediction : BoundingBoxDimensions
    {
        public float Confidence { get; set; }
    }
}
