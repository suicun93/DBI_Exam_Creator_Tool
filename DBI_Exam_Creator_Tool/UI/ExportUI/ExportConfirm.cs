using System;
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
        private string OutPutPath;
        private readonly QuestionSet QuestionSet;
        private ShufflePaperModel Spm;

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
                foreach (var question in QuestionSet.QuestionList)
                foreach (var candidate in question.Candidates)
                    candidate.Point = decimal.ToDouble(question.Point);

                Spm = new ShufflePaperModel(QuestionSet, Convert.ToInt32(papersNumberInput.Value));

                //Create Test
                var paperModel = new PaperModel
                {
                    Path = OutPutPath,
                    Spm = Spm
                };
                Process.Start(OutPutPath);

                using (var progress = new ProgressBarForm(paperModel.CreateTests))
                {
                    progress.ShowDialog(this);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Dispose();
        }

        private void newBtn_Click(object sender, EventArgs e)
        {
            Constants.PaperSet.ListPaperMatrixId = null;
            papersNumberInput.Enabled = true;
            papersNumberInput.Maximum = PaperModel.MaxNumberOfTests(QuestionSet.QuestionList);
            papersNumberInput.Value = papersNumberInput.Maximum;
            papersNumberInput.Enabled = true;
            newBtn.Enabled = false;
        }
    }
}