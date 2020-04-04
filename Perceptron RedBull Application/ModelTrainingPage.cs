using System;
using System.Windows.Forms;
using System.IO;
using System.Linq;

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

        private void addTrainingImgBtn_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();

            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string[] paths = Directory.EnumerateFiles(folderBrowser.SelectedPath, "*.*", SearchOption.AllDirectories)
                    .Where(file => file.ToLower().EndsWith(".jpg") || file.ToLower().EndsWith(".png") || file.ToLower().EndsWith(".jpeg"))
                    .ToArray();

                string[] files = Directory.GetFiles(folderBrowser.SelectedPath);

                if (files.Length > 0)
                {
                    Commons.Resource.TRAINING_IMAGE_SET = files;
                }
                else
                {
                    MessageBox.Show("There must be atleast one image file in the folder!\nAllowed only .jpg .jpeg .png", "Training Image Set");
                }

                foreach (string s in paths)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
