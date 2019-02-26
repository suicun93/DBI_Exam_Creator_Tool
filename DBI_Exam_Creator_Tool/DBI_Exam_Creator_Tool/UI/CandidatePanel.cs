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
            
            questionTypeComboBox.DataBindings.Add("SelectedItem", Candidate, "QuestionType");

            contentTxt.DataBindings.Add("Text", Candidate, "Content");

            // img
            //

            dataGridView.AutoGenerateColumns = false;
            dataGridView.DataSource = new BindingList<Requirement>(Candidate.Requirements);
        }

        // Preview Images
        private void imgPreview_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Image image = ImageUtils.Base64StringToImage(Candidate.ImageData);
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

        // Browse Images
        private void browseImgBtn_Click(object sender, EventArgs e)
        {
            browseImgDialog.InitialDirectory = "C:\\";
            browseImgDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            if (browseImgDialog.ShowDialog() == DialogResult.OK)
            {
                // Get the path of specified file
                string filePath = browseImgDialog.FileName;

                Image img = Image.FromFile(filePath);
                Image resizedImg = ImageUtils.ResizeImage(img, Constants.Size.IMAGE_WIDTH);

                var base64Data = ImageUtils.ImageToBase64(resizedImg);

                Candidate.ImageData = base64Data;
                imgPreview.Text = Path.GetFileName(filePath);
                ToolTip tt = new ToolTip();
                tt.SetToolTip(imgPreview, "Click to preview");
            }
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            Console.WriteLine("something");
        }

        private void dataGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.selectedRowIndex = e.RowIndex;
        }

        //
        // Handle Add Requirement button
        //
        private void addRequirementBtn_Click(object sender, EventArgs e)
        {
            Requirement r = new Requirement();
            r.CandidateId = Candidate.CandidateId;
            if (Candidate.Requirements.Count() != 0)
            {
                // increase last RequirementId by 1
                r.RequirementId = Candidate.Requirements[Candidate.Requirements.Count() - 1].RequirementId + 1;
            } else
            {
                r.RequirementId = 1;
            }
            r.Type = Requirement.RequirementTypes.ResultSet;

            RequirementForm rf = new RequirementForm(r);
            rf.Disposed += (_sender, _e) => { Rf_Disposed(_sender, _e, rf.Requirement, true, rf.discarded); };
            rf.Show();
        }

        //
        // Handle Edit button
        //
        private void editBtn_Click(object sender, EventArgs e)
        {
            if (selectedRowIndex != -1)
            {
                RequirementForm rf = new RequirementForm(Candidate.Requirements[selectedRowIndex]);
                rf.Disposed += (_sender, _e) => { Rf_Disposed(_sender, _e, rf.Requirement, false, rf.discarded); };
                rf.Show();
            }
        }

        // Update dataGridView when close Edit form
        private void Rf_Disposed(object sender, EventArgs e, Requirement editedRequirement, bool isNewReq, bool discarded)
        {
            if (discarded)
                return;
            if (!isNewReq)
            {
                Candidate.Requirements[selectedRowIndex] = editedRequirement;
                
            } else
            {
                Candidate.Requirements.Add(editedRequirement);
            }
            dataGridView.DataSource = typeof(BindingList<Requirement>);
            dataGridView.DataSource = new BindingList<Requirement>(Candidate.Requirements);
        }

        //
        // Handle Delete button
        //
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
        // Close current Tab
        private void deleteCandidateBtn_Click(object sender, EventArgs e)
        {
            handleDelete(this.Candidate, (TabPage) this.Parent);
        }
    }
}
