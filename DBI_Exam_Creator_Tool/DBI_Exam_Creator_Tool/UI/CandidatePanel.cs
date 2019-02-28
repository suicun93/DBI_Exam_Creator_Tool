using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.Utils;
using DBI_Exam_Creator_Tool.Commons;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class CandidatePanel : UserControl
    {
        public Candidate Candidate { get; set; }
        private int selectedRowIndex = -1;

        private delegate bool HandleDelete(Candidate c, TabPage tp);
        private HandleDelete handleDelete;

        public CandidatePanel()
        {
            InitializeComponent();
        }

        public CandidatePanel(Candidate candidate, Func<Candidate, TabPage, bool> _handleDelete)
        {
            InitializeComponent();
            this.Candidate = candidate;
            this.OnCreate();
            handleDelete = new HandleDelete(_handleDelete);
        }

        // Bind Candidate data to controls.
        private void OnCreate()
        {
            questionTypeComboBox.DataSource = new BindingSource(Constants.QuestionTypes(), null);
            questionTypeComboBox.DisplayMember = "Key";
            questionTypeComboBox.ValueMember = "Value";
            
            questionTypeComboBox.DataBindings.Add("SelectedValue", Candidate, "QuestionType");

            contentTxt.DataBindings.Add("Text", Candidate, "Content");

            solutionTxt.DataBindings.Add("Text", Candidate, "Solution");
            testQueryTxt.DataBindings.Add("Text", Candidate, "TestQuery");

            requireSortCheckBox.DataBindings.Add("Checked", Candidate, "RequireSort");

            DBNameTxt.DataBindings.Add("Text", Candidate, "DBName");

            // img
            //

            // Trigger questionTypeComboBox SelectedValueChanged event
            questionTypeComboBox_SelectedValueChanged(questionTypeComboBox, null);
        }

        // Browse Images.
        private void browseImgBtn_Click(object sender, EventArgs e)
        {
            Candidate.Images.Clear();
            browseImgDialog.InitialDirectory = "C:\\";
            browseImgDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            browseImgDialog.Multiselect = true;
            if (browseImgDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string fileName in browseImgDialog.FileNames)
                {
                    // Get the path of specified file
                    string filePath = fileName;

                    Image img = Image.FromFile(filePath);
                    Image resizedImg = ImageUtils.ResizeImage(img, Constants.Size.IMAGE_WIDTH);

                    var base64Data = ImageUtils.ImageToBase64(resizedImg);

                    Candidate.Images.Add(base64Data);
                    //imgPreview.Text = Path.GetFileName(filePath);
                    imgPreview.Text = "Preview";
                    ToolTip tt = new ToolTip();
                    tt.SetToolTip(imgPreview, "Click to preview");
                }
            }
        }

        // Preview Images.
        private void imgPreview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (string imgData in Candidate.Images)
            {
                Image image = ImageUtils.Base64StringToImage(imgData);
                using (Form form = new Form())
                {
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Size = image.Size;
                    form.FormBorderStyle = FormBorderStyle.FixedDialog;
                    form.MaximizeBox = false;
                    form.MinimizeBox = false;

                    PictureBox pb = new PictureBox();
                    pb.Dock = DockStyle.Fill;
                    pb.Image = image;

                    form.Controls.Add(pb);
                    form.ShowDialog();
                }
            }

        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            Console.WriteLine("something");
        }

        // Delete current Candidate from Question
        // Close current Tab.
        private void deleteCandidateBtn_Click(object sender, EventArgs e)
        {
            handleDelete(this.Candidate, (TabPage) this.Parent);
        }

        private void questionTypeComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (questionTypeComboBox.SelectedValue)
            {
                case Candidate.QuestionTypes.Select:
                    selectState();
                    break;
                case Candidate.QuestionTypes.Procedure:
                    procedureState();
                    break;
                case Candidate.QuestionTypes.Trigger:
                    triggerState();
                    break;
                case Candidate.QuestionTypes.Schema:
                    schemaState();
                    break;
                case Candidate.QuestionTypes.DML:
                    dmlState();
                    break;
                default:
                    break;
            }
        }

        private void selectState()
        {
            testQueryTxt.Enabled = false;

            requireSortCheckBox.Visible = true;

            dbNameLabel.Visible = DBNameTxt.Visible = false;
        }

        private void procedureState()
        {
            testQueryTxt.Enabled = true;
            
            requireSortCheckBox.Checked = requireSortCheckBox.Visible = false;

            dbNameLabel.Visible = DBNameTxt.Visible = false;
        }

        private void triggerState()
        {
            testQueryTxt.Enabled = true;

            requireSortCheckBox.Checked = requireSortCheckBox.Visible = false;

            dbNameLabel.Visible = DBNameTxt.Visible = false;
        }

        private void dmlState()
        {
            testQueryTxt.Enabled = false;


            requireSortCheckBox.Checked = requireSortCheckBox.Visible = false;

            dbNameLabel.Visible = DBNameTxt.Visible = false;
        }

        private void schemaState()
        {
            testQueryTxt.Enabled = false;
            
            requireSortCheckBox.Checked = requireSortCheckBox.Visible = false;

            dbNameLabel.Visible = DBNameTxt.Visible = true;
        }
    }
}
