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

            resultSetCheckBox.DataBindings.Add("Checked", Candidate, "ResultSet");
            requireSortCheckBox.DataBindings.Add("Checked", Candidate, "RequireSort");

            effectCheckBox.DataBindings.Add("Checked", Candidate, "Effect");
            checkEffectQueryTxt.DataBindings.Add("Text", Candidate, "CheckEffectQuery");

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

        private void effectCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            checkEffectQueryTxt.Enabled = effectCheckBox.Checked;
        }

        private void selectState()
        {
            activateQueryTxt.Enabled = false;
            // ResultSet checkbox enabled & always checked.
            resultSetCheckBox.Checked = true;
            effectCheckBox.Checked = false;

            requireSortCheckBox.Enabled = true;
            resultSetCheckBox.Enabled = effectCheckBox.Enabled = false;
        }

        private void procedureState()
        {
            activateQueryTxt.Enabled = true;

            resultSetCheckBox.Enabled = requireSortCheckBox.Enabled = effectCheckBox.Enabled = true;
        }

        private void triggerState()
        {
            activateQueryTxt.Enabled = true;

            resultSetCheckBox.Enabled = requireSortCheckBox.Enabled = effectCheckBox.Enabled = true;
        }

        private void dmlState()
        {
            activateQueryTxt.Enabled = false;

            resultSetCheckBox.Checked = requireSortCheckBox.Checked = false;
            effectCheckBox.Checked = true;

            resultSetCheckBox.Enabled = requireSortCheckBox.Enabled = effectCheckBox.Enabled = false;
        }

        private void schemaState()
        {
            activateQueryTxt.Enabled = false;

            resultSetCheckBox.Checked = requireSortCheckBox.Checked = effectCheckBox.Checked = false;

            resultSetCheckBox.Enabled = requireSortCheckBox.Enabled = effectCheckBox.Enabled = false;
        }
    }
}
