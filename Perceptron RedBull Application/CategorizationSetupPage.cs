using Perceptron_RedBull_Application.ML.CustomType;
using Perceptron_RedBull_Application.ML.Service;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Perceptron_RedBull_Application
{
    public partial class CategorizationSetupPage : Form
    {
        public CategorizationSetupPage()
        {
            InitializeComponent();
        }

        private void categorizeBtn_Click(object sender, EventArgs e)
        {
            ModelOutput prediction = Predictor.ClassifySingleImage(Commons.Resource.PREDICTING_IMAGE_PATH, ModelTrainer.Train());

            string predictedLabel = prediction.PredictedLabel;

            Console.WriteLine("predicted label -> " + predictedLabel);

            if (predictedLabel.Equals("SF"))
                Commons.Resource.SUGAR_FREE_COUNT += 1;
            else if (predictedLabel.Equals("RG"))
                Commons.Resource.REGULAR_COUNT += 1;

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
            openFile.Filter = "Image files ((*.jpg, *.jpeg, *.jpe, *.jfif, *.png, *.bmp) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png, *.bmp";

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
    }
}
