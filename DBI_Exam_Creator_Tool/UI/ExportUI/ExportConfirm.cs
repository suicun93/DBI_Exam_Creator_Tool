using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;
using DBI_Exam_Creator_Tool.Commons;
using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.Model;
using DBI_Exam_Creator_Tool.Utils;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class ExportConfirm : Form
    {
        ShufflePaperModel Spm;
        QuestionSet QuestionSet;
        string OutPutPath;

        public ExportConfirm(QuestionSet questionSet)
        {
            InitializeComponent();
            QuestionSet = questionSet;
            
            exportBtn.Visible = true;
        }

        private void browseBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OutPutPath = FileUtils.SaveFileLocation();
                locationTxt.Text = OutPutPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(OutPutPath))
                {
                    MessageBox.Show("You need to Browse first!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Spm = new ShufflePaperModel(QuestionSet, Convert.ToInt32(papersNumberInput.Value));

                //Create Test
                PaperModel paperModel = new PaperModel
                {
                    Path = OutPutPath,
                    Spm = Spm,
                };
                Process.Start(OutPutPath);

                using (ProgressBarForm progress = new ProgressBarForm(paperModel.CreateTests))
                {
                    progress.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Dispose();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            Constants.PaperSet.ListPaperMatrixId = new List<int>();
            papersNumberInput.Enabled = true;
            papersNumberInput.Maximum = PaperModel.MaxNumberOfTests(QuestionSet.QuestionList);
            papersNumberInput.Value = papersNumberInput.Maximum;
            papersNumberInput.Enabled = true;
            newBtn.Enabled = false;
        }
    }
}
