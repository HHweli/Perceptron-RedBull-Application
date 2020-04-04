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
                predictingImgNameLbl.Text = fileName;

                // Saving the predicting image for later use
                Commons.Resource.bitmap = new Bitmap(openFile.FileName);

                predictingImageBox.Image = Commons.Resource.bitmap;

                categorizeBtn.Enabled = true;
            }
        }
    }
}
