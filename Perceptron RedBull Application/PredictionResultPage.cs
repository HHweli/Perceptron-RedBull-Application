using System;
using System.Windows.Forms;

namespace Perceptron_RedBull_Application
{
    public partial class PredictionResultPage : Form
    {
        public PredictionResultPage()
        {
            InitializeComponent();
        }

        private void rglEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void sfEditBtn_Click(object sender, EventArgs e)
        {

        }

        private void manualAddBtn_Click(object sender, EventArgs e)
        {
            Form editPage = new ManualEditPage();
            editPage.Show();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            Form homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {

        }

        private void PredictionResultPage_Load(object sender, EventArgs e)
        {
            resultRglImgBox.Image = Commons.Resource.bitmap;
            resultRglImgBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
    }
}
