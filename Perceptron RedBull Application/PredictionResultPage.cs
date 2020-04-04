using System;
using System.Windows.Forms;
using System.Runtime.InteropServices;

using Excel = Microsoft.Office.Interop.Excel;

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
            Excel.Application xlApp = new Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!", "Excel Report");
            }
            else
            {
                object misValue = System.Reflection.Missing.Value;
                Excel.Workbook xlWorkBook = xlApp.Workbooks.Add();
                Excel.Worksheet xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

                try
                {
                    xlWorkSheet.Range[xlWorkSheet.Cells[1, 1], xlWorkSheet.Cells[1, 3]].Merge();

                    xlWorkSheet.Cells[1, 1] = "RedBull Category Counts";

                    xlWorkSheet.Cells[2, 1] = "Regular";
                    xlWorkSheet.Cells[2, 2] = "Sugar Free";
                    xlWorkSheet.Cells[2, 3] = "Unidentified";
                    xlWorkSheet.Cells[5, 1] = "Accuracy(%)";

                    xlWorkSheet.Cells[3, 1] = Commons.Resource.REGULAR_COUNT;
                    xlWorkSheet.Cells[3, 2] = Commons.Resource.SUGAR_FREE_COUNT;
                    xlWorkSheet.Cells[3, 3] = Commons.Resource.UNIDENTIFIED_COUNT;
                    xlWorkSheet.Cells[5, 2] = Commons.Resource.PREDICTION_ACCURACY;

                    //xlWorkBook.SaveAs(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\RedBull Category Count.xls",
                    //    Excel.XlFileFormat.xlWorkbookNormal, misValue, misValue, misValue, misValue, Excel.XlSaveAsAccessMode.xlExclusive,
                    //    misValue, misValue, misValue, misValue, misValue);

                    //MessageBox.Show("Excel file was created in Documents folder!", "Excel Report");

                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    Marshal.ReleaseComObject(xlWorkSheet);
                    Marshal.ReleaseComObject(xlWorkBook);
                    Marshal.ReleaseComObject(xlApp);

                    MessageBox.Show("Excel file was created in Documents folder!", "Excel Report");
                }
                catch (Exception)
                {
                    MessageBox.Show("An Error Occurred!", "Excel Report");
                }
                //finally
                //{
                //    xlWorkBook.Close(true, misValue, misValue);
                //    xlApp.Quit();

                //    Marshal.ReleaseComObject(xlWorkSheet);
                //    Marshal.ReleaseComObject(xlWorkBook);
                //    Marshal.ReleaseComObject(xlApp);
                //}
            }
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
