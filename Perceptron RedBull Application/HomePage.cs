using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron_RedBull_Application
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Commons.Resource.REGULAR_COUNT = 0;
            Commons.Resource.SUGAR_FREE_COUNT = 0;
            Commons.Resource.UNIDENTIFIED_COUNT = 0;

            Commons.Resource.PREDICTION_ACCURACY = 0.0;
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            Form categorizationSetupForm = new CategorizationSetupPage();
            this.Hide();
            categorizationSetupForm.ShowDialog();
            this.Close();
        }

        private void addNewCatBtn_Click(object sender, EventArgs e)
        {
            Form modelTrainingForm = new ModelTrainingPage();
            this.Hide();
            modelTrainingForm.ShowDialog();
            this.Close();
        }
    }
}
