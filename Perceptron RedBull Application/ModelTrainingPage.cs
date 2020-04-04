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
    public partial class ModelTrainingPage : Form
    {
        public ModelTrainingPage()
        {
            InitializeComponent();
        }

        private void ModelTrainingPage_Load(object sender, EventArgs e)
        {

        }

        private void newCatNameTxt_Enter(object sender, EventArgs e)
        {
            //if (newCatNameTxt.Text == "new category name")
            //    newCatNameTxt.Text = null;

            //newCatNameTxt.Font.Style = FontStyle.Regular;
            //newCatNameTxt.ForeColor = Color.Black;
        }

        private void newCatNameTxt_Leave(object sender, EventArgs e)
        {
            //if (newCatNameTxt.Text == "")
            //    newCatNameTxt.Text = "new category name";

            //newCatNameTxt.ForeColor = Color.DarkGray;
        }

        private void trainBackBtn_Click(object sender, EventArgs e)
        {
            Form homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }
    }
}
