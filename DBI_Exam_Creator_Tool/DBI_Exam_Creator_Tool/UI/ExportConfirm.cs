using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class ExportConfirm : Form
    {
        private string saveFolder = "";

        public ExportConfirm()
        {
            InitializeComponent();
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                saveFolder = folderBrowserDialog.SelectedPath;
                locationTxt.Text = saveFolder;

                // Open shuffle tool here
            }
            else
            {
                //MessageBox.Show("Failed to export data", "Error!");
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            // Open shuffle tool here
            // saveFolder
            int papersNumber = Decimal.ToInt32(papersNumberInput.Value);

            this.Dispose();
        }
    }
}
