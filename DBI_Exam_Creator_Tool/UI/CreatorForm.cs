using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using DBI_Exam_Creator_Tool.Commons;
using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.Model;
using DBI_Exam_Creator_Tool.UI;
using DBI_Exam_Creator_Tool.Utils;
using DBI_ShuffleTool.Utils.Doc;
using Newtonsoft.Json;

namespace DBI_Exam_Creator_Tool
{
    public partial class CreatorForm : Form
    {
        private List<Question> questions;
        private QuestionSet questionSet = new QuestionSet();

        public CreatorForm()
        {
            InitializeComponent();

            questions = questionSet.QuestionList;
        }

        // Add Question - New Tab.
        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var q = new Question();
            q.QuestionId = Guid.NewGuid().ToString();
            q.Point = 1;
            questions.Add(q);
            addQuestionTab(q);
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            var q = new Question();
            q.QuestionId = Guid.NewGuid().ToString();
            q.Point = 1;
            questions.Add(q);
            addQuestionTab(q);

            // Focus newest tab
            questionTabControl.SelectedIndex = questionTabControl.TabPages.Count - 1;
        }

        private void questionTabControl_Selected(object sender, TabControlEventArgs e)
        {
            //TabPage currentTab = e.TabPage;
        }

        private bool handleRemoveQuestion(Question q, TabPage tab)
        {
            questions.Remove(q);
            questionTabControl.TabPages.Remove(tab);
            printQuestionNo();
            return false;
        }

        // Preview entire the Questions List.
        private void previewBtn_Click(object sender, EventArgs e)
        {
            PreviewDocUtils.PreviewCandidatePackage(questionSet);
        }

        private void removeQuestionBtn_Click(object sender, EventArgs e)
        {
            var tab = questionTabControl.TabPages[questionTabControl.SelectedIndex];
            var qp = (QuestionPanel) tab.Controls["questionPanel"];

            questions.Remove(qp.question);
            questionTabControl.TabPages.Remove(tab);

            printQuestionNo();
        }

        // Add question.
        private void addQuestionTab(Question q)
        {
            var questionPanel = new QuestionPanel(q, handleRemoveQuestion);
            questionPanel.Dock = DockStyle.Fill;
            questionPanel.Name = "questionPanel";

            var tab = new TabPage(q.QuestionId);
            tab.Controls.Add(questionPanel);

            questionTabControl.TabPages.Add(tab);

            printQuestionNo();
        }

        private void open()
        {
            importDialog.Filter = "Data (*.dat)|*.dat";
            importDialog.FilterIndex = 2;
            importDialog.RestoreDirectory = true;
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear.
                questions.Clear();
                questionTabControl.TabPages.Clear();

                // Load data.
                var localPath = importDialog.FileName;
                var set = SerializeUtils.DeserializeJson(localPath);
                questionSet = set;
                questions = questionSet.QuestionList;

                // Visualization.
                foreach (var q in questions)
                    addQuestionTab(q);
                MessageBox.Show("Import data successfully.");
            }
        }

        // Export to .jon file.
        private void save()
        {
            exportDialog.Filter = "Data (*.dat)|*.dat";
            exportDialog.FilterIndex = 2;
            exportDialog.RestoreDirectory = true;
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                var saveFolder = Path.GetDirectoryName(exportDialog.FileName);
                var savePath = Path.Combine(saveFolder, exportDialog.FileName);
                SerializeUtils.WriteJson(questionSet, savePath);
                MessageBox.Show("Export data successfully to " + savePath, "Success");
            }
        }

        private void printQuestionNo()
        {
            for (var i = 0; i < questionTabControl.TabPages.Count; i++)
                questionTabControl.TabPages[i].Text = "Question " + (i + 1);
        }

        // DrawItem for Vertical TabControl - Question Tabs.
        private void questionTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            var g = e.Graphics;
            Brush _textBrush = new SolidBrush(Color.Black);
            Font _tabFont;

            // Get the item from the collection.
            var _tabPage = questionTabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            var _tabBounds = questionTabControl.GetTabRect(e.Index);

            if (e.State == DrawItemState.Selected)
            {
                // Draw a different background color.
                _tabFont = new Font("Microsoft Sans Serif", 10, FontStyle.Bold);
                g.FillRectangle(Brushes.LightBlue, e.Bounds);
            }
            else
            {
                _tabFont = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
                e.DrawBackground();
            }

            // Draw string. Center the text.
            var _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void scriptBtn_Click(object sender, EventArgs e)
        {
            var scriptForm = new InputScriptForm(handleCloseScriptForm, questionSet.DBScriptList);

            scriptForm.Visible = true;
            scriptForm.Show();
        }

        private bool handleCloseScriptForm(List<string> scripts)
        {
            questionSet.DBScriptList = scripts;
            return false;
        }

        private void exportPaperSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exportConfirm = new ExportConfirm(questionSet);
            //exportConfirm.Visible = true;
            if (Constants.PaperSet != null && Constants.PaperSet.ListPaperMatrixId != null &&
                Constants.PaperSet.ListPaperMatrixId.Count > 0)
            {
                exportConfirm.papersNumberInput.Value = Constants.PaperSet.ListPaperMatrixId.Count;
                exportConfirm.papersNumberInput.Enabled = false;
                exportConfirm.newBtn.Enabled = true;
            }
            else
            {
                exportConfirm.papersNumberInput.Maximum = PaperModel.MaxNumberOfTests(questionSet.QuestionList);
                exportConfirm.papersNumberInput.Value = exportConfirm.papersNumberInput.Maximum;
                exportConfirm.papersNumberInput.Enabled = true;
                exportConfirm.newBtn.Enabled = false;
            }
            exportConfirm.Show(this);
        }

        private void importPaperSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importDialog.Filter = "Data (*.dat)|*.dat";
            importDialog.FilterIndex = 2;
            importDialog.RestoreDirectory = true;
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear.
                questions.Clear();
                questionTabControl.TabPages.Clear();

                // Load data.
                var localPath = importDialog.FileName;
                Constants.PaperSet = JsonConvert.DeserializeObject<PaperSet>(File.ReadAllText(localPath));
                questionSet = Constants.PaperSet.QuestionSet;
                questions = questionSet.QuestionList;
                questionSet.DBScriptList = Constants.PaperSet.DBScriptList;

                // Visualization.
                foreach (var q in questions)
                    addQuestionTab(q);
                MessageBox.Show("Import data successfully.");
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            save();
        }
    }
}