namespace DBI_Exam_Creator_Tool
{
    partial class CandidatePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addRequirementBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.requirementsLabel = new System.Windows.Forms.Label();
            this.browseImgBtn = new System.Windows.Forms.Button();
            this.imgLabel = new System.Windows.Forms.Label();
            this.contentTxt = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.questionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.imgPreview = new System.Windows.Forms.LinkLabel();
            this.browseImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.RequirementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckEffectQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // addRequirementBtn
            // 
            this.addRequirementBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addRequirementBtn.Location = new System.Drawing.Point(83, 122);
            this.addRequirementBtn.Name = "addRequirementBtn";
            this.addRequirementBtn.Size = new System.Drawing.Size(99, 23);
            this.addRequirementBtn.TabIndex = 28;
            this.addRequirementBtn.Text = "Add Requirement";
            this.addRequirementBtn.UseVisualStyleBackColor = true;
            this.addRequirementBtn.Click += new System.EventHandler(this.addRequirementBtn_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowDrop = true;
            this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.RequirementId,
            this.CandidateId,
            this.Type,
            this.ResultQuery,
            this.EffectTable,
            this.CheckEffectQuery});
            this.dataGridView.Location = new System.Drawing.Point(83, 151);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(644, 193);
            this.dataGridView.TabIndex = 27;
            // 
            // requirementsLabel
            // 
            this.requirementsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.requirementsLabel.AutoSize = true;
            this.requirementsLabel.Location = new System.Drawing.Point(3, 127);
            this.requirementsLabel.Name = "requirementsLabel";
            this.requirementsLabel.Size = new System.Drawing.Size(72, 13);
            this.requirementsLabel.TabIndex = 26;
            this.requirementsLabel.Text = "Requirements";
            // 
            // browseImgBtn
            // 
            this.browseImgBtn.Location = new System.Drawing.Point(83, 93);
            this.browseImgBtn.Name = "browseImgBtn";
            this.browseImgBtn.Size = new System.Drawing.Size(99, 23);
            this.browseImgBtn.TabIndex = 23;
            this.browseImgBtn.Text = "Browse";
            this.browseImgBtn.UseVisualStyleBackColor = true;
            this.browseImgBtn.Click += new System.EventHandler(this.browseImgBtn_Click);
            // 
            // imgLabel
            // 
            this.imgLabel.AutoSize = true;
            this.imgLabel.Location = new System.Drawing.Point(3, 98);
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(36, 13);
            this.imgLabel.TabIndex = 24;
            this.imgLabel.Text = "Image";
            // 
            // contentTxt
            // 
            this.contentTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.contentTxt.Location = new System.Drawing.Point(83, 37);
            this.contentTxt.Multiline = true;
            this.contentTxt.Name = "contentTxt";
            this.contentTxt.Size = new System.Drawing.Size(644, 46);
            this.contentTxt.TabIndex = 22;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(3, 40);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(44, 13);
            this.contentLabel.TabIndex = 21;
            this.contentLabel.Text = "Content";
            // 
            // questionTypeComboBox
            // 
            this.questionTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.questionTypeComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.questionTypeComboBox.Location = new System.Drawing.Point(83, 6);
            this.questionTypeComboBox.Name = "questionTypeComboBox";
            this.questionTypeComboBox.Size = new System.Drawing.Size(99, 21);
            this.questionTypeComboBox.TabIndex = 20;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(3, 9);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 19;
            this.typeLabel.Text = "Type";
            // 
            // imgPreview
            // 
            this.imgPreview.AutoSize = true;
            this.imgPreview.Location = new System.Drawing.Point(189, 98);
            this.imgPreview.Name = "imgPreview";
            this.imgPreview.Size = new System.Drawing.Size(45, 13);
            this.imgPreview.TabIndex = 29;
            this.imgPreview.TabStop = true;
            this.imgPreview.Text = "Preview";
            this.imgPreview.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.imgPreview_LinkClicked);
            // 
            // browseImgDialog
            // 
            this.browseImgDialog.FileName = "img";
            // 
            // RequirementId
            // 
            this.RequirementId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RequirementId.DataPropertyName = "requirementId";
            this.RequirementId.HeaderText = "RequirementId";
            this.RequirementId.Name = "RequirementId";
            this.RequirementId.ReadOnly = true;
            this.RequirementId.Width = 101;
            // 
            // CandidateId
            // 
            this.CandidateId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.CandidateId.DataPropertyName = "CandidateId";
            this.CandidateId.HeaderText = "CandidateId";
            this.CandidateId.Name = "CandidateId";
            this.CandidateId.Width = 89;
            // 
            // Type
            // 
            this.Type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 56;
            // 
            // ResultQuery
            // 
            this.ResultQuery.DataPropertyName = "ResultQuery";
            this.ResultQuery.HeaderText = "ResultQuery";
            this.ResultQuery.Name = "ResultQuery";
            // 
            // EffectTable
            // 
            this.EffectTable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EffectTable.DataPropertyName = "EffectTable";
            this.EffectTable.HeaderText = "EffectTable";
            this.EffectTable.Name = "EffectTable";
            this.EffectTable.Width = 87;
            // 
            // CheckEffectQuery
            // 
            this.CheckEffectQuery.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CheckEffectQuery.DataPropertyName = "CheckEffectQuery";
            this.CheckEffectQuery.HeaderText = "CheckEffectQuery";
            this.CheckEffectQuery.Name = "CheckEffectQuery";
            // 
            // CandidatePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.imgPreview);
            this.Controls.Add(this.addRequirementBtn);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.requirementsLabel);
            this.Controls.Add(this.browseImgBtn);
            this.Controls.Add(this.imgLabel);
            this.Controls.Add(this.contentTxt);
            this.Controls.Add(this.contentLabel);
            this.Controls.Add(this.questionTypeComboBox);
            this.Controls.Add(this.typeLabel);
            this.Name = "CandidatePanel";
            this.Size = new System.Drawing.Size(730, 347);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addRequirementBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label requirementsLabel;
        private System.Windows.Forms.Button browseImgBtn;
        private System.Windows.Forms.Label imgLabel;
        private System.Windows.Forms.TextBox contentTxt;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.ComboBox questionTypeComboBox;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.LinkLabel imgPreview;
        private System.Windows.Forms.OpenFileDialog browseImgDialog;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckEffectQuery;
    }
}
