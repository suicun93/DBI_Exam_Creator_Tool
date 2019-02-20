using System;
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
using DBI_Exam_Creator_Tool.Commons;

namespace DBI_Exam_Creator_Tool
{
    public partial class MainForm : Form
    {
        private int questionId = 1;
        private List<Question> questions = new List<Question>();
        private Question currentQuestion;

        public MainForm()
        {
            InitializeComponent();
        }

        // Trigger when user click "Add Candidate" button
        // add new Candidate to the current Question
        private void addCandidateBtn_Click(object sender, EventArgs e)
        {
            if (currentQuestion == null)
            {
                Console.WriteLine("no question selected");
                return;
            }

            Candidate c = new Candidate();
            // increase last CandidateId by 1
            c.CandidateId = currentQuestion.Candidates[currentQuestion.Candidates.Count() - 1].CandidateId + 1;
            c.QuestionType = Constants.QuestionType.QUERY;

            currentQuestion.Candidates.Add(c);
            TabPage tp = new TabPage("Candidate " + currentQuestion.Candidates.Count());

            CandidatePanel candidatePanel = new CandidatePanel(c);
            tp.Controls.Add(candidatePanel);
            candidateControl.TabPages.Add(tp);

            // focus new tab
            candidateControl.SelectedIndex = candidateControl.TabCount - 1;
            tp.Focus();
        }


        // Trigger when user click "Add Question" button
        // add new Question to list
        private void addQuestionBtn_Click(object sender, EventArgs e)
        {
            Question q = new Question(this.questionId, 1, new List<Candidate>());
            Candidate c = new Candidate();
            c.CandidateId = 1;
            c.QuestionId = q.QuestionId;
            q.Candidates.Add(c);
            this.questions.Add(q);
            
            Button btn = new Button();
            Point btnLocation = new Point(3, 3 * this.questions.Count() + 23 * (this.questions.Count() - 1));
            btn.Location = btnLocation;
            btn.Text = "Question " + (this.questions.Count());
            btn.Click += (_sender, EventArgs) => { Question_Btn_Click(_sender, EventArgs, q); };
            
            this.questionPanel.Controls.Add(btn);
            btn.PerformClick();
        }

        /// <summary>
        /// When user click "Question i" button
        /// switch tab control to the corresponding Candidates
        /// </summary>
        /// <param name="_q">Question binding with the button</param>
        private void Question_Btn_Click(object _sender, EventArgs _e, Question _q)
        {
            // Clear binding with the previous Question Point
            pointTxt.DataBindings.Clear();
            // Bind with current Question Point
            pointTxt.DataBindings.Add("Text", _q, "Point");

            candidateControl.TabPages.Clear();
            currentQuestion = _q;

            Button btn = (Button)_sender;
            //btn.BackColor = Color.Green;
            btn.Focus();

            // Show corresponding question's candidates in tab control

            for (int i = 0; i < _q.Candidates.Count(); i++)
            {
                Candidate c = _q.Candidates[i];

                TabPage tp = new TabPage("Candidate " + (i + 1));
                CandidatePanel candidatePanel = new CandidatePanel(c);
                tp.Controls.Add(candidatePanel);
                candidateControl.TabPages.Add(tp);
            }
        }

        // Export Questions data into .json file
        private void exportBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "Json files (*.json)|*.json";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string jsonData = JsonConvert.SerializeObject(this.questions);

                string saveFolder = Path.GetDirectoryName(saveFileDialog.FileName);
                string savePath = Path.Combine(saveFolder, saveFileDialog.FileName);

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
    }
}
