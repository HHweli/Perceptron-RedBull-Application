using System;
using System.Windows.Forms;

namespace Perceptron_RedBull_Application
{
    public partial class ManualEditPage : Form
    {
        public ManualEditPage()
        {
            InitializeComponent();
        }

        private void manualEditDoneBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
