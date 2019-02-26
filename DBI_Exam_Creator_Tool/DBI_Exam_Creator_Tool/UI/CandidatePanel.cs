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

        // Bind Candidate data to controls
        private void OnCreate()
        {
            questionTypeComboBox.DataSource = new BindingSource(Constants.QuestionTypes(), null);
            questionTypeComboBox.DisplayMember = "Key";
            questionTypeComboBox.ValueMember = "Value";
            
            questionTypeComboBox.DataBindings.Add("SelectedValue", Candidate, "QuestionType");

            contentTxt.DataBindings.Add("Text", Candidate, "Content");

            // img
            //

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = new BindingList<Requirement>(Candidate.Requirements);

            // Trigger questionTypeComboBox SelectedValueChanged event
            questionTypeComboBox_SelectedValueChanged(questionTypeComboBox, null);
        }

        // Browse Images
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
            //using (Form form = new Form())
            //{
            //    form.StartPosition = FormStartPosition.CenterScreen;
            //    form.AutoScroll = true;
            //    form.Width = 680;

            //    int yPosition = 0;
            //    foreach (string imgData in Candidate.Images)
            //    {
            //        Image image = ImageUtils.Base64StringToImage(imgData);

            //        PictureBox pb = new PictureBox();
            //        pb.Dock = DockStyle.Fill;
            //        pb.Image = image;
            //        pb.Location = new Point(0, yPosition);

            //        yPosition += image.Height;

            //        form.Controls.Add(pb);
            //    }
            //    form.ShowDialog();
            //}

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

        // Used for Edit, Delete Requirement
        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedRowIndex = e.RowIndex;
        }
        
        // Handle Add Requirement button.
        private void addRequirementBtn_Click(object sender, EventArgs e)
        {
            Requirement r = new Requirement();
            r.CandidateId = Candidate.CandidateId;
            r.RequirementId = Guid.NewGuid().ToString();
            r.Type = Constants.GetRequirementTypes(Candidate.QuestionType).First().Value;

            RequirementForm rf = new RequirementForm(r, Candidate.QuestionType , true, this.Rf_Disposed);
            rf.Show();
        }
        
        // Handle Edit button.
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex != -1)
            {
                RequirementForm rf = new RequirementForm(Candidate.Requirements[selectedRowIndex], Candidate.QuestionType, false, this.Rf_Disposed);
                rf.Show();
            }
        }

        // Update dataGridView when close Edit form.
        private bool Rf_Disposed(Requirement req, bool isNewReq, bool saved)
        {
            if (!saved)
                return false;

            if (!isNewReq)
            {
                Candidate.Requirements[selectedRowIndex] = req;
            } else
            {
                Candidate.Requirements.Add(req);
            }
            dataGridView.DataSource = typeof(BindingList<Requirement>);
            dataGridView.DataSource = new BindingList<Requirement>(Candidate.Requirements);
            return false;
        }
        
        // Handle Delete button.
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex != -1)
            {
                Candidate.Requirements.RemoveAt(selectedRowIndex);
            }
            dataGridView.DataSource = typeof(BindingList<Requirement>);
            dataGridView.DataSource = new BindingList<Requirement>(Candidate.Requirements);
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
                    activateQueryTxt.Enabled = false;
                    break;
                case Candidate.QuestionTypes.Procedure:
                    activateQueryTxt.Enabled = true;
                    break;
                case Candidate.QuestionTypes.Trigger:
                    activateQueryTxt.Enabled = true;
                    break;
                case Candidate.QuestionTypes.Schema:
                    activateQueryTxt.Enabled = false;
                    break;
                case Candidate.QuestionTypes.DML:
                    activateQueryTxt.Enabled = false;
                    break;
                default:
                    break;
            }
        }
    }
}
