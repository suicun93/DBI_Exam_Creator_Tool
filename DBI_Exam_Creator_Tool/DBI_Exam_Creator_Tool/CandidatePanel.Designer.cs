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
            System.Windows.Forms.Button deleteCandidateBtn;
            this.addRequirementBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.RequirementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RequireSort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckEffectQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ActivateTriggerQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OutputParameter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementsLabel = new System.Windows.Forms.Label();
            this.browseImgBtn = new System.Windows.Forms.Button();
            this.imgLabel = new System.Windows.Forms.Label();
            this.contentTxt = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.questionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.imgPreview = new System.Windows.Forms.LinkLabel();
            this.browseImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.editBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            deleteCandidateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // deleteCandidateBtn
            // 
            deleteCandidateBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            deleteCandidateBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            deleteCandidateBtn.Location = new System.Drawing.Point(733, 8);
            deleteCandidateBtn.Name = "deleteCandidateBtn";
            deleteCandidateBtn.Size = new System.Drawing.Size(115, 23);
            deleteCandidateBtn.TabIndex = 32;
            deleteCandidateBtn.Text = "Delete Candidate";
            deleteCandidateBtn.UseVisualStyleBackColor = false;
            deleteCandidateBtn.Click += new System.EventHandler(this.deleteCandidateBtn_Click);
            // 
            // addRequirementBtn
            // 
            this.addRequirementBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addRequirementBtn.Location = new System.Drawing.Point(749, 137);
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
            this.RequireSort,
            this.EffectTable,
            this.CheckEffectQuery,
            this.ActivateTriggerQuery,
            this.OutputParameter});
            this.dataGridView.Location = new System.Drawing.Point(83, 166);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(765, 236);
            this.dataGridView.TabIndex = 27;
            this.dataGridView.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_RowEnter);
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // RequirementId
            // 
            this.RequirementId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.RequirementId.DataPropertyName = "requirementId";
            this.RequirementId.HeaderText = "RequirementId";
            this.RequirementId.Name = "RequirementId";
            this.RequirementId.ReadOnly = true;
            this.RequirementId.Width = 21;
            // 
            // CandidateId
            // 
            this.CandidateId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.CandidateId.DataPropertyName = "CandidateId";
            this.CandidateId.HeaderText = "CandidateId";
            this.CandidateId.Name = "CandidateId";
            this.CandidateId.Width = 21;
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
            // RequireSort
            // 
            this.RequireSort.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.RequireSort.DataPropertyName = "RequireSort";
            this.RequireSort.HeaderText = "Require Sort";
            this.RequireSort.Name = "RequireSort";
            this.RequireSort.Width = 84;
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
            // ActivateTriggerQuery
            // 
            this.ActivateTriggerQuery.DataPropertyName = "ActivateTriggerQuery";
            this.ActivateTriggerQuery.HeaderText = "Activate Trigger Query";
            this.ActivateTriggerQuery.Name = "ActivateTriggerQuery";
            // 
            // OutputParameter
            // 
            this.OutputParameter.HeaderText = "Output Parameter";
            this.OutputParameter.Name = "OutputParameter";
            // 
            // requirementsLabel
            // 
            this.requirementsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.requirementsLabel.AutoSize = true;
            this.requirementsLabel.Location = new System.Drawing.Point(3, 142);
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
            this.contentTxt.Size = new System.Drawing.Size(765, 46);
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
            this.questionTypeComboBox.Size = new System.Drawing.Size(136, 21);
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
            this.imgPreview.Size = new System.Drawing.Size(0, 13);
            this.imgPreview.TabIndex = 29;
            this.imgPreview.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.imgPreview_LinkClicked);
            // 
            // browseImgDialog
            // 
            this.browseImgDialog.FileName = "img";
            // 
            // editBtn
            // 
            this.editBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.editBtn.Location = new System.Drawing.Point(668, 137);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(75, 23);
            this.editBtn.TabIndex = 30;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Location = new System.Drawing.Point(587, 137);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(75, 23);
            this.deleteBtn.TabIndex = 31;
            this.deleteBtn.Text = "Delete";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // CandidatePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(deleteCandidateBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
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
            this.Size = new System.Drawing.Size(851, 405);
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
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequireSort;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckEffectQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ActivateTriggerQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn OutputParameter;
    }
}
