using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.Helpers;
using System.IO;

namespace DBI_Exam_Creator_Tool
{
    public partial class CandidatePanel : UserControl
    {
        private Candidate Candidate;

        public CandidatePanel()
        {
            InitializeComponent();
        }

        public CandidatePanel(Candidate candidate)
        {
            InitializeComponent();
            this.Candidate = candidate;
            this.OnCreate();
        }

        private void OnCreate()
        {
            List<string> questionTypes = Utilities.QuestionTypes();
            questionTypeComboBox.DataSource = questionTypes;
            //questionTypeComboBox.SelectedItem = Candidate.QuestionType;
            questionTypeComboBox.DataBindings.Add("SelectedItem", Candidate, "QuestionType");

            contentTxt.DataBindings.Add("Text", Candidate, "Content");

            // img
            //

            dataGridView.DataSource = typeof(List<Requirement>);
            dataGridView.DataSource = Candidate.Requirements;
        }

        private void addRequirementBtn_Click(object sender, EventArgs e)
        {
            Requirement r = new Requirement("1", 1, 1, "hello mother fucker", "haha", "hahahehe");
            Candidate.Requirements.Add(r);

            dataGridView.DataSource = typeof(List<Requirement>);
            dataGridView.DataSource = Candidate.Requirements;
        }

        private void imgPreview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Image image = Base64StringToImage(Candidate.ImageData);
            using (Form form = new Form())
            {
                form.StartPosition = FormStartPosition.CenterScreen;
                form.Size = image.Size;

                PictureBox pb = new PictureBox();
                pb.Dock = DockStyle.Fill;
                pb.Image = image;

                form.Controls.Add(pb);
                form.ShowDialog();
            }
        }

        private void browseImgBtn_Click(object sender, EventArgs e)
        {
            browseImgDialog.InitialDirectory = "C:\\";
            browseImgDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (browseImgDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                //string filePath = browseImgDialog.FileName;

                //var image = Image.FromFile(filePath);

                // Read the contents of the file into a stream
                var fileStream = browseImgDialog.OpenFile();

                using (StreamReader reader = new StreamReader(fileStream))
                {
                    string fileContent = reader.ReadToEnd();
                    //Console.WriteLine(fileContent);
                    var bytes = Encoding.UTF8.GetBytes(fileContent);
                    Candidate.ImageData = Convert.ToBase64String(bytes);
                    reader.Close();
                }
            }
        }

        public Image Base64StringToImage(string inputString)
        {
            Image img = null;

            byte[] imageBytes = Convert.FromBase64String(inputString);

            using (MemoryStream ms = new MemoryStream())
            {
                
                ms.Position = 0;
                img = Image.FromStream(ms, true);

                ms.Close();
                imageBytes = null;
            }
            return img;
        }
    }
}
