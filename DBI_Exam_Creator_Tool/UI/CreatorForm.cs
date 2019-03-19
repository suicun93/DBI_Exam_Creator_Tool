using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.UI;
using DBI_Exam_Creator_Tool.Utils;
using DBI_ShuffleTool.Utils.Doc;
using Newtonsoft.Json;

namespace DBI_Exam_Creator_Tool
{
    public partial class CreatorForm : Form
    {
        private QuestionSet questionSet = new QuestionSet();
        private List<Question> questions;

        public CreatorForm()
        {
            InitializeComponent();

            questions = questionSet.QuestionList;
        }

        // Add Question - New Tab.
        private void addQuestionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.QuestionId = Guid.NewGuid().ToString();
            q.Point = 1;
            this.questions.Add(q);
            addQuestionTab(q);
        }

        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            Question q = new Question();
            q.QuestionId = Guid.NewGuid().ToString();
            q.Point = 1;
            this.questions.Add(q);
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
            this.questions.Remove(q);
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
            TabPage tab = questionTabControl.TabPages[questionTabControl.SelectedIndex];
            QuestionPanel qp = (QuestionPanel)tab.Controls["questionPanel"];

            questions.Remove(qp.question);
            questionTabControl.TabPages.Remove(tab);

            printQuestionNo();
        }

        // Add question.
        private void addQuestionTab(Question q)
        {
            QuestionPanel questionPanel = new QuestionPanel(q, this.handleRemoveQuestion);
            questionPanel.Dock = DockStyle.Fill;
            questionPanel.Name = "questionPanel";

            TabPage tab = new TabPage(q.QuestionId);
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
                this.questions.Clear();
                this.questionTabControl.TabPages.Clear();

                // Load data.
                string localPath = importDialog.FileName;
                QuestionSet set = SerializeUtils.DeserializeJson(localPath);
                this.questionSet = set;
                this.questions = questionSet.QuestionList;

                // Visualization.
                foreach (Question q in questions)
                {
                    addQuestionTab(q);
                }
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
                string saveFolder = Path.GetDirectoryName(exportDialog.FileName);
                string savePath = Path.Combine(saveFolder, exportDialog.FileName);
                SerializeUtils.WriteJson(questionSet, savePath);
                MessageBox.Show("Export data successfully to " + savePath, "Success");
            } else
            {
                //MessageBox.Show("Failed to export data", "Error!");
            }
            
        }

        private void printQuestionNo()
        {
            for (var i = 0; i < questionTabControl.TabPages.Count; i++)
            {
                questionTabControl.TabPages[i].Text = "Question " + (i + 1);
            }
        }

        // DrawItem for Vertical TabControl - Question Tabs.
        private void questionTabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            Graphics g = e.Graphics;
            Brush _textBrush = new System.Drawing.SolidBrush(Color.Black);
            Font _tabFont;

            // Get the item from the collection.
            TabPage _tabPage = questionTabControl.TabPages[e.Index];

            // Get the real bounds for the tab rectangle.
            Rectangle _tabBounds = questionTabControl.GetTabRect(e.Index);

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
            StringFormat _stringFlags = new StringFormat();
            _stringFlags.Alignment = StringAlignment.Center;
            _stringFlags.LineAlignment = StringAlignment.Center;
            g.DrawString(_tabPage.Text, _tabFont, _textBrush, _tabBounds, new StringFormat(_stringFlags));
        }

        private void scriptBtn_Click(object sender, EventArgs e)
        {
            InputScriptForm scriptForm = new InputScriptForm(this.handleCloseScriptForm, questionSet.DBScriptList);
            
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
            ExportConfirm exportConfirm = new ExportConfirm(questionSet);
            exportConfirm.Visible = true;
            exportConfirm.Show();
        }

        private void importPaperSetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            importDialog.Filter = "Data (*.dat)|*.dat";
            importDialog.FilterIndex = 2;
            importDialog.RestoreDirectory = true;
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear.
                this.questions.Clear();
                this.questionTabControl.TabPages.Clear();

                // Load data.
                string localPath = importDialog.FileName;
                PaperSet paperSet = JsonConvert.DeserializeObject<PaperSet>(File.ReadAllText(localPath));
                this.questionSet = paperSet.QuestionSet;
                this.questions = questionSet.QuestionList;

                // Visualization.
                foreach (Question q in questions)
                {
                    addQuestionTab(q);
                }
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
