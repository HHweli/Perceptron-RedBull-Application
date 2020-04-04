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
    public partial class CategorizationSetupPage : Form
    {
        public CategorizationSetupPage()
        {
            InitializeComponent();
        }

        private void categorizeBtn_Click(object sender, EventArgs e)
        {

        }

        private void catSetupBackBtn_Click(object sender, EventArgs e)
        {
            Form homePage = new HomePage();
            this.Hide();
            homePage.ShowDialog();
            this.Close();
        }
    }
}
