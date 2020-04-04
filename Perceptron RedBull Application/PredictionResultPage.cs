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

        private void manualAddBtn_Click(object sender, EventArgs e)
        {
            Form editPage = new ManualEditPage(this);
            editPage.Show();
        }

        private void finishBtn_Click(object sender, EventArgs e)
        {
            if (Commons.Resource.PREDICTING_IMAGE != null)
                Commons.Resource.PREDICTING_IMAGE.Dispose();

            Form homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            // generate a excel sheet with the predicted final counts.
        }

        private void PredictionResultPage_Load(object sender, EventArgs e)
        {
            SetFormInitialValues();
        }

        public void SetFormInitialValues()
        {
            rglCountBtnTxt.Text = Commons.Resource.REGULAR_COUNT.ToString();
            sfCountBtnTxt.Text = Commons.Resource.SUGAR_FREE_COUNT.ToString();
            unidentifyCountBtnTxt.Text = Commons.Resource.UNIDENTIFIED_COUNT.ToString();

            accuracyLbl.Text = "Accuracy : " + Commons.Resource.PREDICTION_ACCURACY.ToString() + "%";

            if (Commons.Resource.UNIDENTIFIED_COUNT == 0)
                manualAddBtn.Enabled = false;
            else
                manualAddBtn.Enabled = true;
        }
    }
}
