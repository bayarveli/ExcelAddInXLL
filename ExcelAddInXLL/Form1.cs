using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ExcelAddInXLL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_calculate_Click(object sender, EventArgs e)
        {
            string path = "D:\\humidAir.xlsm";

            Excel.Application xlApp = null;
            Excel.Workbook xlWorkbook = null;

            try
            {
                xlApp = new Excel.Application();

                xlApp.DisplayAlerts = false;
                xlApp.Visible = true;
                xlApp.Application.Visible = false;

                xlWorkbook = xlApp.Workbooks.Open(path, 0, false, 5, "", "", true, Excel.XlPlatform.xlWindows, "", true, false, 0, true, 1, 0);

                bool operationFlag = xlApp.RegisterXLL("D://HumidAir.xll");

                if (operationFlag == true)
                {
                    double input1 = Double.Parse(txt_input1.Text);
                    double input2 = Double.Parse(txt_input2.Text);
                    double input3 = Double.Parse(txt_input3.Text);
                    string input4 = txt_input4.Text;

                    string result = xlApp.Run("HumidairTdbRHPsi", 60.0, 85.0, 8.0, "Hm").ToString();

                    txt_result.Text = result;
                }
                else
                {
                    MessageBox.Show("Add-in file (.xll) cannot be found.");
                }

                xlWorkbook.Close(false);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A problem occurred about Excel application.");
            }
            finally
            {
                xlApp.Quit();

                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlWorkbook);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(xlApp);

                xlWorkbook = null;
                xlApp = null;
            }
        }
    }
}
