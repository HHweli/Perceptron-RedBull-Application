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

                predictingImgNameLbl.Text = Commons.Resource.PREDICTING_IMAGE_NAME;
                predictingImageBox.Image = Commons.Resource.PREDICTING_IMAGE;

                categorizeBtn.Enabled = true;
            }
        }
    }
}
