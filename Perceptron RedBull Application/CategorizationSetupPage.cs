using Microsoft.ML;
using Newtonsoft.Json;
using Perceptron_RedBull_Application.ML.CustomType;
using Perceptron_RedBull_Application.ML.Service;
using Perceptron_RedBull_Application.ML.YoloParser;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron_RedBull_Application
{
    public partial class CategorizationSetupPage : Form
    {
        public static IList<YoloBoundingBox> detectedObjects = new List<YoloBoundingBox>();
        public static string[] predictingImgPaths;

        public CategorizationSetupPage()
        {
            InitializeComponent();
        }

        private void categorizeBtn_Click(object sender, EventArgs e)
        {
            var assetsRelativePath = @"../../../assets";
            string assetsPath = GetAbsolutePath(assetsRelativePath);
            var modelFilePath = Path.Combine(assetsPath, "Model", "model.onnx");
            var imagesFolder = Path.Combine(assetsPath, "images");
            var outputFolder = Path.Combine(assetsPath, "images", "output");

            MLContext mlContext = new MLContext();

            try
            {
                ImageNetData image = ImageNetData.ReadFromFile(imagesFolder).ElementAt(0);

                MakePredictionRequest(image.ImagePath).Wait();

                DrawBoundingBox(imagesFolder, outputFolder, image.Label, detectedObjects);
                LogDetectedObjects(image.Label, detectedObjects);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            //try
            //{
            //    IEnumerable<ImageNetData> images = ImageNetData.ReadFromFile(imagesFolder);
            //    IDataView imageDataView = mlContext.Data.LoadFromEnumerable(images);

            //    var modelScorer = new OnnxModelScorer(imagesFolder, modelFilePath, mlContext);

            //    // Use model to score data
            //    IEnumerable<float[]> probabilities = modelScorer.Score(imageDataView);

            //    YoloOutputParser parser = new YoloOutputParser();

            //    var boundingBoxes =
            //        probabilities
            //        .Select(probability => parser.ParseOutputs(probability))
            //        .Select(boxes => parser.FilterBoundingBoxes(boxes, 5, .5F));

            //    for (var i = 0; i < images.Count(); i++)
            //    {
            //        string imageFileName = images.ElementAt(i).Label;
            //        IList<YoloBoundingBox> detectedObjects = boundingBoxes.ElementAt(i);

            //        DrawBoundingBox(imagesFolder, outputFolder, imageFileName, detectedObjects);
            //        LogDetectedObjects(imageFileName, detectedObjects);
            //    }
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.ToString());
            //}

            Console.WriteLine("========= End of Object Detection ========");

            predictingImgPaths = Directory.GetFiles(Path.Combine(outputFolder, "crp"));

            for (int i = 0; i < predictingImgPaths.Length; i++)
            {
                ModelOutput prediction = Predictor.ClassifySingleImage(predictingImgPaths[i], ModelTrainer.Train());

                string predictedLabel = prediction != null ? prediction.PredictedLabel : "";

                Console.WriteLine("debug -> " + predictedLabel);
                if (predictedLabel.Equals(Commons.Resource.SUGAR_FREE))
                    Commons.Resource.SUGAR_FREE_COUNT += 1;
                else if (predictedLabel.Equals(Commons.Resource.REGULAR))
                    Commons.Resource.REGULAR_COUNT += 1;
                else
                    Commons.Resource.UNIDENTIFIED_COUNT += 1;
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

                // Saving the predicting image for later use
                Commons.Resource.PREDICTING_IMAGE = new Bitmap(openFile.FileName);

                // Saving the predicting image name for later use
                Commons.Resource.PREDICTING_IMAGE_NAME = fileName;

                // Saving the predicting image path
                Commons.Resource.PREDICTING_IMAGE_PATH = openFile.FileName;

                predictingImgNameLbl.Text = Commons.Resource.PREDICTING_IMAGE_NAME;
                predictingImageBox.Image = Commons.Resource.PREDICTING_IMAGE;

                categorizeBtn.Enabled = true;
            }
        }

        private static async Task MakePredictionRequest(string imageFilePath)
        {
            var client = new HttpClient();

            // Request headers - replace this example key with your valid Prediction-Key.
            client.DefaultRequestHeaders.Add("Prediction-Key", "a0ffc5d0545f454684d274b7cfb0f166");

            // Prediction URL - replace this example URL with your valid Prediction URL.
            string url = "https://redbullcanidentifier.cognitiveservices.azure.com/customvision/v3.0/Prediction/620b819b-e260-4860-9931-25fa3aec8c66/detect/iterations/redbullCanIdentifierModel/image";

            HttpResponseMessage response;

            // Request body. Try this sample with a locally stored image.
            byte[] byteData = GetImageAsByteArray(imageFilePath);

            using (var content = new ByteArrayContent(byteData))
            {
                content.Headers.ContentType = new MediaTypeHeaderValue("application/octet-stream");
                response = await client.PostAsync(url, content);
                string respBody = await response.Content.ReadAsStringAsync();

                var respObj = JsonConvert.DeserializeObject<ResponsePrediction>(respBody);

                Commons.Resource.TOTAL_COUNT = respObj.predictions.Length;

                foreach (Prediction pred in respObj.predictions)
                {
                    YoloBoundingBox ybb = new YoloBoundingBox();
                    ybb.Dimensions = new BoundingBoxDimensions();

                    ybb.Label = pred.tagName;
                    ybb.Confidence = pred.probability;
                    ybb.BoxColor = Color.Red;

                    ybb.Dimensions.X = 100 * pred.boundingBox.left;
                    ybb.Dimensions.Y = 100 * pred.boundingBox.top;
                    ybb.Dimensions.Width = 12 * pred.boundingBox.width;
                    ybb.Dimensions.Height = 12 * pred.boundingBox.height;

                    detectedObjects.Add(ybb);
                }
            }
        }

        private static byte[] GetImageAsByteArray(string imageFilePath)
        {
            FileStream fileStream = new FileStream(imageFilePath, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            return binaryReader.ReadBytes((int)fileStream.Length);
        }

        public static string GetAbsolutePath(string relativePath)
        {
            FileInfo _dataRoot = new FileInfo(typeof(Program).Assembly.Location);
            string assemblyFolderPath = _dataRoot.Directory.FullName;

            string fullPath = Path.Combine(assemblyFolderPath, relativePath);

            return fullPath;
        }

        private static void DrawBoundingBox(string inputImageLocation, string outputImageLocation, string imageName, IList<YoloBoundingBox> filteredBoundingBoxes)
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

                x = (uint)originalImageWidth * x / OnnxModelScorer.ImageNetSettings.imageWidth;
                y = (uint)originalImageHeight * y / OnnxModelScorer.ImageNetSettings.imageHeight;
                width = (uint)originalImageWidth * width / OnnxModelScorer.ImageNetSettings.imageWidth;
                height = (uint)originalImageHeight * height / OnnxModelScorer.ImageNetSettings.imageHeight;

                string text = $"{box.Label} ({(box.Confidence * 100).ToString("0")}%)";

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
                    Pen pen = new Pen(box.BoxColor, 3.2f);
                    SolidBrush colorBrush = new SolidBrush(box.BoxColor);

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

        private static void LogDetectedObjects(string imageName, IList<YoloBoundingBox> boundingBoxes)
        {
            Console.WriteLine($".....The objects in the image {imageName} are detected as below....");

            foreach (var box in boundingBoxes)
            {
                Console.WriteLine($"{box.Label} and its Confidence score: {box.Confidence}");
            }

            Console.WriteLine("");
        }
    }
}
