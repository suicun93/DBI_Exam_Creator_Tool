using System;
using System.Drawing;
using System.Windows.Forms;
using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.Utils;
using DBI_Exam_Creator_Tool.Commons;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class CandidatePanel : UserControl
    {
        public Candidate Candidate { get; set; }

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
            
            questionTypeComboBox.DataBindings.Add("SelectedValue", Candidate, "QuestionType", true, DataSourceUpdateMode.OnPropertyChanged);
            contentTxt.DataBindings.Add("Text", Candidate, "QuestionRequirement", true, DataSourceUpdateMode.OnPropertyChanged);

            solutionTxt.DataBindings.Add("Text", Candidate, "Solution", true, DataSourceUpdateMode.OnPropertyChanged);
            testQueryTxt.DataBindings.Add("Text", Candidate, "TestQuery", true, DataSourceUpdateMode.OnPropertyChanged);

            requireSortCheckBox.DataBindings.Add("Checked", Candidate, "RequireSort", true, DataSourceUpdateMode.OnPropertyChanged);
            checkColumnNameCheckbox.DataBindings.Add("Checked", Candidate, "CheckColumnName", true, DataSourceUpdateMode.OnPropertyChanged);
            checkDistinctCheckbox.DataBindings.Add("Checked", Candidate, "CheckDistinct", true, DataSourceUpdateMode.OnPropertyChanged);
            relatedSchemaCheckbox.DataBindings.Add("Checked", Candidate, "RelatedSchema", true, DataSourceUpdateMode.OnPropertyChanged);

            // Images.
            if (Candidate.Illustration.Count != 0)
            {
                imgPreview.Text = "Preview";
                imgPreview.Visible = true;
            }

            // Trigger questionTypeComboBox SelectedValueChanged event
            questionTypeComboBox_SelectedValueChanged(questionTypeComboBox, null);
        }

        // Browse Images.
        private void browseImgBtn_Click(object sender, EventArgs e)
        {
            Candidate.Illustration.Clear();
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
                    if (img.Width > Constants.Size.IMAGE_WIDTH)
                    {
                        img = ImageUtils.ResizeImage(img, Constants.Size.IMAGE_WIDTH);
                    }

                    var base64Data = ImageUtils.ImageToBase64(img);

                    Candidate.Illustration.Add(base64Data);
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
            //foreach (string imgData in Candidate.Illustration)
            //{
            //    Image image = ImageUtils.Base64StringToImage(imgData);
            //    using (Form form = new Form())
            //    {
            //        form.StartPosition = FormStartPosition.CenterScreen;
            //        form.Size = image.Size;
            //        form.FormBorderStyle = FormBorderStyle.FixedDialog;
            //        form.MaximizeBox = false;
            //        form.MinimizeBox = false;

            //        PictureBox pb = new PictureBox();
            //        pb.Dock = DockStyle.Fill;
            //        pb.Image = image;

            //        form.Controls.Add(pb);
            //        form.ShowDialog();
            //    }
            //}
            PicturePreview preview = new PicturePreview(Candidate.Illustration);
            preview.Visible = true;
            preview.Show();
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
            }
        }

        private void selectState()
        {
            testQueryTxt.Enabled = true;

            requireSortCheckBox.Visible = true;

            requireSortCheckBox.Checked = false;

            checkColumnNameCheckbox.Visible = true;

            checkColumnNameCheckbox.Checked = false;

            checkDistinctCheckbox.Visible = true;

            checkDistinctCheckbox.Checked = false;

            relatedSchemaCheckbox.Visible = false;

            relatedSchemaCheckbox.Checked = false;
        }

        private void procedureState()
        {
            testQueryTxt.Enabled = true;

            requireSortCheckBox.Visible = false;

            requireSortCheckBox.Checked = false;

            checkColumnNameCheckbox.Visible = false;

            checkColumnNameCheckbox.Checked = false;

            checkDistinctCheckbox.Visible = false;

            checkDistinctCheckbox.Checked = false;

            relatedSchemaCheckbox.Visible = false;

            relatedSchemaCheckbox.Checked = false;
        }

        private void triggerState()
        {
            testQueryTxt.Enabled = true;

            requireSortCheckBox.Visible = false;

            requireSortCheckBox.Checked = false;

            checkColumnNameCheckbox.Visible = false;

            checkColumnNameCheckbox.Checked = false;

            checkDistinctCheckbox.Visible = false;

            checkDistinctCheckbox.Checked = false;

            relatedSchemaCheckbox.Visible = false;

            relatedSchemaCheckbox.Checked = false;
        }

        private void dmlState()
        {
            testQueryTxt.Enabled = true;

            requireSortCheckBox.Visible = false;

            requireSortCheckBox.Checked = false;

            checkColumnNameCheckbox.Visible = false;

            checkColumnNameCheckbox.Checked = false;

            checkDistinctCheckbox.Visible = false;

            checkDistinctCheckbox.Checked = false;

            relatedSchemaCheckbox.Visible = true;

            //relatedSchemaCheckbox.Checked = false;
        }

        private void schemaState()
        {
            testQueryTxt.Enabled = true;

            requireSortCheckBox.Visible = false;

            requireSortCheckBox.Checked = false;

            checkColumnNameCheckbox.Visible = false;

            checkColumnNameCheckbox.Checked = false;

            checkDistinctCheckbox.Visible = false;

            checkDistinctCheckbox.Checked = false;

            relatedSchemaCheckbox.Visible = false;

            //relatedSchemaCheckbox.Checked = false;
        }

        private void CandidatePanel_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;//Fill Usercontrol within the his parent layout
        }
    }
}
