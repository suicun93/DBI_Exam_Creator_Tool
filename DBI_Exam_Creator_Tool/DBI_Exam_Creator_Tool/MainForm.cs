using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DBI_Exam_Creator_Tool.Entities;

namespace DBI_Exam_Creator_Tool
{
    public partial class MainForm : Form
    {
        private List<Candidate> candidates = new List<Candidate>();
        private BindingSource bindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            dataGridView.DataSource = bindingSource;
        }

        private void browseImgBtn_Click(object sender, EventArgs e)
        {
            browseImgDialog.InitialDirectory = "C:\\";
            browseImgDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (browseImgDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = browseImgDialog.FileName;
                
                var image = Image.FromFile(filePath);
                //Size viewSize = new Size(pictureBox.Width, pictureBox.Height);

                pictureBox.Image = image;
                pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;

                // Read the contents of the file into a stream
                //var fileStream = browseImgDialog.OpenFile();

                //using (StreamReader reader = new StreamReader(fileStream))
                //{
                //    string fileContent = reader.ReadToEnd();
                //}
            }
        }

        private void addRequirementBtn_Click(object sender, EventArgs e)
        {
            bindingSource.Add(new Requirement("1", 1, 1, "select * from girls", "", ""));

            //dataGridView.Update();
            //dataGridView.Refresh();
        }

        private void addCandidateBtn_Click(object sender, EventArgs e)
        {
            candidates.Add(new Candidate());
            TabPage tp = new TabPage("Candidate " + (candidates.Count() + 1));
            tp.Controls.Add(candidatePanel);
            candidateControl.TabPages.Add(tp);


            //TextBox tb = new TextBox();
            //tb.Dock = DockStyle.Fill;
            //tb.Multiline = true;

            //tp.Controls.Add(tb);
        }
    }
}
