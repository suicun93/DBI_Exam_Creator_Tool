﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.UI;
using DBI_Exam_Creator_Tool.Utils;

namespace DBI_Exam_Creator_Tool
{
    public partial class CreatorForm : Form
    {
        private List<Question> questions = new List<Question>();

        public CreatorForm()
        {
            InitializeComponent();
            //questionTabControl.TabPages.Add(new TabPage("Question 1"));
            //questionTabControl.TabPages.Add(new TabPage("Question 2"));
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
            MessageBox.Show(questions.Count().ToString());
        }

        private void removeQuestionBtn_Click(object sender, EventArgs e)
        {
            TabPage tab = questionTabControl.TabPages[questionTabControl.SelectedIndex];
            QuestionPanel qp = (QuestionPanel)tab.Controls["questionPanel"];

            questions.Remove(qp.question);
            questionTabControl.TabPages.Remove(tab);

            printQuestionNo();
        }
        
        private void exportBtn_Click(object sender, EventArgs e)
        {
            export();
        }

        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            export();
        }

        private void importToolStripMenuItem_Click(object sender, EventArgs e)
        {
            import();
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

        private void import()
        {
            importDialog.Filter = "Json files (*.json)|*.json";
            importDialog.FilterIndex = 2;
            importDialog.RestoreDirectory = true;
            if (importDialog.ShowDialog() == DialogResult.OK)
            {
                // Clear.
                this.questions.Clear();
                this.questionTabControl.TabPages.Clear();

                // Load data.
                string localPath = importDialog.FileName;
                List<Question> questionList = JsonUtils.DeserializeJson(localPath);
                this.questions = questionList;

                // Visualization.
                foreach (Question q in questions)
                {
                    addQuestionTab(q);
                }
            }
        }

        // Export to .jon file.
        private void export()
        {
            exportDialog.Filter = "Json files (*.json)|*.json";
            exportDialog.FilterIndex = 2;
            exportDialog.RestoreDirectory = true;
            if (exportDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonData = JsonConvert.SerializeObject(this.questions);

                string saveFolder = Path.GetDirectoryName(exportDialog.FileName);
                string savePath = Path.Combine(saveFolder, exportDialog.FileName);

                WriteToFile(jsonData, savePath);
            }
        }

        private void WriteToFile(string data, string savePath)
        {
            try
            {
                File.WriteAllText(savePath, data);
                MessageBox.Show("Saved to " + savePath, "Success");
            }
            catch (Exception)
            {
                MessageBox.Show("Failed to export data", "Error!");
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
    }
}
