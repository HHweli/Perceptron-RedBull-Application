using System;
using System.Windows.Forms;

namespace Perceptron_RedBull_Application
{
    public partial class ManualEditPage : Form
    {
        PredictionResultPage predictionResultPage = null;

        public ManualEditPage()
        {
            InitializeComponent();
        }

        public ManualEditPage(PredictionResultPage predictionResultPage)
        {
            this.predictionResultPage = predictionResultPage;
            InitializeComponent();
        }

        private void manualEditDoneBtn_Click(object sender, EventArgs e)
        {
            if (manualCountRglTxt.Value + manualCountSfTxt.Value != Commons.Resource.UNIDENTIFIED_COUNT)
            {
                MessageBox.Show("Sum Of Regular Count and Sugar Free Count Must Be Equal To Unidentified Count!", "Unidentified Count");
                manualCountRglTxt.Focus();
            }
            else
            {
                Commons.Resource.REGULAR_COUNT = Commons.Resource.REGULAR_COUNT + (int)manualCountRglTxt.Value;
                Commons.Resource.SUGAR_FREE_COUNT = Commons.Resource.SUGAR_FREE_COUNT + (int)manualCountSfTxt.Value;
                Commons.Resource.UNIDENTIFIED_COUNT = Commons.Resource.UNIDENTIFIED_COUNT -
                    ((int)manualCountRglTxt.Value + (int)manualCountSfTxt.Value);

                predictionResultPage.SetFormInitialValues();

                this.Close();
            }
        }

        private void ManualEditPage_Load(object sender, EventArgs e)
        {
            predictedImgBox.Image = Commons.Resource.PREDICTING_IMAGE;
            predictingImgNameLbl.Text = Commons.Resource.PREDICTING_IMAGE_NAME;
        }
    }
}
