using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using DBI_Exam_Creator_Tool.Entities;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class QuestionPanel : UserControl
    {
        public Question question { get; set; }

        private delegate bool HandleRemove(Question q, TabPage tab);
        private HandleRemove handleRemove;

        public QuestionPanel()
        {
            InitializeComponent();
        }

        public QuestionPanel(Question question, Func<Question, TabPage, bool> _handleRemove)
        {
            InitializeComponent();
            this.question = question;
            this.handleRemove = new HandleRemove(_handleRemove);

            OnCreate();
        }

        private void OnCreate()
        {
            questionIdTxt.Text = question.QuestionId;
            pointNumeric.DataBindings.Add("Value", question, "Point");

            for (var i = 0; i < question.Candidates.Count; i++)
            {
                addCandidateTab(question.Candidates[i], "Candidate " + (i + 1));
            }
        }

        private void removeQuestionBtn_Click(object sender, EventArgs e)
        {
            this.handleRemove(this.question, (TabPage)this.Parent);
        }

        private void addCandidateBtn_Click(object sender, EventArgs e)
        {
            Candidate c = new Candidate();
            c.QuestionId = question.QuestionId;
            c.CandidateId = Guid.NewGuid().ToString();
            c.QuestionType = Candidate.QuestionTypes.Select;
            c.CheckColumnName = true;

            question.Candidates.Add(c);

            string tabTitle = "Candidate " + question.Candidates.Count();

            addCandidateTab(c, tabTitle);
        }

        private void addCandidateTab(Candidate c, string tabTitle)
        {
            TabPage tp = new TabPage(tabTitle);
            tp.BackColor = System.Drawing.SystemColors.GradientActiveCaption;

            CandidatePanel candidatePanel = new CandidatePanel(c, this.handleDeleteCandidate);
            candidatePanel.BackColor = Color.Transparent;
            tp.Controls.Add(candidatePanel);
            candidateTabControl.TabPages.Add(tp);

            // focus new tab
            candidateTabControl.SelectedIndex = candidateTabControl.TabCount - 1;
            tp.Focus();
        }

        private bool handleDeleteCandidate(Candidate c, TabPage tab)
        {
            question.Candidates.Remove(c);
            candidateTabControl.TabPages.Remove(tab);
            return false;
        }
    }
}
