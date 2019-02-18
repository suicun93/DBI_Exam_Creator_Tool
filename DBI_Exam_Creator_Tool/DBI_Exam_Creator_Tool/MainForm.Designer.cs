namespace DBI_Exam_Creator_Tool
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.questionPanel = new System.Windows.Forms.Panel();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.addQuestionBtn = new System.Windows.Forms.Button();
            this.question1Btn = new System.Windows.Forms.Button();
            this.importBtn = new System.Windows.Forms.Button();
            this.exportBtn = new System.Windows.Forms.Button();
            this.editQuestionPanel = new System.Windows.Forms.Panel();
            this.candidateControl = new System.Windows.Forms.TabControl();
            this.candidate1 = new System.Windows.Forms.TabPage();
            this.pointLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseImgDialog = new System.Windows.Forms.OpenFileDialog();
            this.addCandidateBtn = new System.Windows.Forms.Button();
            this.candidatePanel = new System.Windows.Forms.Panel();
            this.addRequirementBtn = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.RequirementId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CandidateId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ResultQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EffectTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckEffectQuery = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.requirementsLabel = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.browseImgBtn = new System.Windows.Forms.Button();
            this.imgLabel = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.contentLabel = new System.Windows.Forms.Label();
            this.questionTypeComboBox = new System.Windows.Forms.ComboBox();
            this.typeLabel = new System.Windows.Forms.Label();
            this.questionPanel.SuspendLayout();
            this.editQuestionPanel.SuspendLayout();
            this.candidateControl.SuspendLayout();
            this.candidate1.SuspendLayout();
            this.candidatePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // questionPanel
            // 
            this.questionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.questionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.questionPanel.Controls.Add(this.vScrollBar1);
            this.questionPanel.Controls.Add(this.addQuestionBtn);
            this.questionPanel.Controls.Add(this.question1Btn);
            this.questionPanel.Location = new System.Drawing.Point(12, 52);
            this.questionPanel.Name = "questionPanel";
            this.questionPanel.Size = new System.Drawing.Size(110, 461);
            this.questionPanel.TabIndex = 0;
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vScrollBar1.Location = new System.Drawing.Point(88, -1);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 460);
            this.vScrollBar1.TabIndex = 2;
            // 
            // addQuestionBtn
            // 
            this.addQuestionBtn.Location = new System.Drawing.Point(3, 32);
            this.addQuestionBtn.Name = "addQuestionBtn";
            this.addQuestionBtn.Size = new System.Drawing.Size(75, 23);
            this.addQuestionBtn.TabIndex = 1;
            this.addQuestionBtn.Text = "+";
            this.addQuestionBtn.UseVisualStyleBackColor = true;
            // 
            // question1Btn
            // 
            this.question1Btn.Location = new System.Drawing.Point(3, 3);
            this.question1Btn.Name = "question1Btn";
            this.question1Btn.Size = new System.Drawing.Size(75, 23);
            this.question1Btn.TabIndex = 0;
            this.question1Btn.Text = "Question 1";
            this.question1Btn.UseVisualStyleBackColor = true;
            // 
            // importBtn
            // 
            this.importBtn.Location = new System.Drawing.Point(12, 13);
            this.importBtn.Name = "importBtn";
            this.importBtn.Size = new System.Drawing.Size(79, 23);
            this.importBtn.TabIndex = 1;
            this.importBtn.Text = "Import";
            this.importBtn.UseVisualStyleBackColor = true;
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(97, 13);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(79, 23);
            this.exportBtn.TabIndex = 2;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            // 
            // editQuestionPanel
            // 
            this.editQuestionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editQuestionPanel.Controls.Add(this.addCandidateBtn);
            this.editQuestionPanel.Controls.Add(this.candidateControl);
            this.editQuestionPanel.Controls.Add(this.pointLabel);
            this.editQuestionPanel.Controls.Add(this.textBox1);
            this.editQuestionPanel.Location = new System.Drawing.Point(128, 52);
            this.editQuestionPanel.Name = "editQuestionPanel";
            this.editQuestionPanel.Size = new System.Drawing.Size(745, 461);
            this.editQuestionPanel.TabIndex = 3;
            // 
            // candidateControl
            // 
            this.candidateControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.candidateControl.Controls.Add(this.candidate1);
            this.candidateControl.Location = new System.Drawing.Point(0, 33);
            this.candidateControl.Name = "candidateControl";
            this.candidateControl.SelectedIndex = 0;
            this.candidateControl.Size = new System.Drawing.Size(745, 428);
            this.candidateControl.TabIndex = 2;
            // 
            // candidate1
            // 
            this.candidate1.Controls.Add(this.candidatePanel);
            this.candidate1.Location = new System.Drawing.Point(4, 22);
            this.candidate1.Name = "candidate1";
            this.candidate1.Padding = new System.Windows.Forms.Padding(3);
            this.candidate1.Size = new System.Drawing.Size(737, 402);
            this.candidate1.TabIndex = 0;
            this.candidate1.Text = "Candidate 1";
            this.candidate1.UseVisualStyleBackColor = true;
            // 
            // pointLabel
            // 
            this.pointLabel.AutoSize = true;
            this.pointLabel.Location = new System.Drawing.Point(12, 9);
            this.pointLabel.Name = "pointLabel";
            this.pointLabel.Size = new System.Drawing.Size(31, 13);
            this.pointLabel.TabIndex = 1;
            this.pointLabel.Text = "Point";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(88, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(99, 20);
            this.textBox1.TabIndex = 0;
            // 
            // browseImgDialog
            // 
            this.browseImgDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
            // 
            // addCandidateBtn
            // 
            this.addCandidateBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addCandidateBtn.Location = new System.Drawing.Point(639, 4);
            this.addCandidateBtn.Name = "addCandidateBtn";
            this.addCandidateBtn.Size = new System.Drawing.Size(102, 23);
            this.addCandidateBtn.TabIndex = 0;
            this.addCandidateBtn.Text = "Add Candidate";
            this.addCandidateBtn.UseVisualStyleBackColor = true;
            this.addCandidateBtn.Click += new System.EventHandler(this.addCandidateBtn_Click);
            // 
            // candidatePanel
            // 
            this.candidatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.candidatePanel.Controls.Add(this.addRequirementBtn);
            this.candidatePanel.Controls.Add(this.dataGridView);
            this.candidatePanel.Controls.Add(this.requirementsLabel);
            this.candidatePanel.Controls.Add(this.pictureBox);
            this.candidatePanel.Controls.Add(this.browseImgBtn);
            this.candidatePanel.Controls.Add(this.imgLabel);
            this.candidatePanel.Controls.Add(this.textBox2);
            this.candidatePanel.Controls.Add(this.contentLabel);
            this.candidatePanel.Controls.Add(this.questionTypeComboBox);
            this.candidatePanel.Controls.Add(this.typeLabel);
            this.candidatePanel.Location = new System.Drawing.Point(1, 1);
            this.candidatePanel.Name = "candidatePanel";
            this.candidatePanel.Size = new System.Drawing.Size(739, 400);
            this.candidatePanel.TabIndex = 0;
            // 
            // addRequirementBtn
            // 
            this.addRequirementBtn.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.addRequirementBtn.Location = new System.Drawing.Point(86, 193);
            this.addRequirementBtn.Name = "addRequirementBtn";
            this.addRequirementBtn.Size = new System.Drawing.Size(99, 23);
            this.addRequirementBtn.TabIndex = 18;
            this.addRequirementBtn.Text = "Add Requirement";
            this.addRequirementBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView
            // 
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
            this.dataGridView.Location = new System.Drawing.Point(86, 222);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(644, 171);
            this.dataGridView.TabIndex = 17;
            // 
            // RequirementId
            // 
            this.RequirementId.DataPropertyName = "requirementId";
            this.RequirementId.HeaderText = "RequirementId";
            this.RequirementId.Name = "RequirementId";
            this.RequirementId.ReadOnly = true;
            // 
            // CandidateId
            // 
            this.CandidateId.DataPropertyName = "CandidateId";
            this.CandidateId.HeaderText = "CandidateId";
            this.CandidateId.Name = "CandidateId";
            // 
            // Type
            // 
            this.Type.DataPropertyName = "Type";
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            // 
            // ResultQuery
            // 
            this.ResultQuery.DataPropertyName = "ResultQuery";
            this.ResultQuery.HeaderText = "ResultQuery";
            this.ResultQuery.Name = "ResultQuery";
            // 
            // EffectTable
            // 
            this.EffectTable.DataPropertyName = "EffectTable";
            this.EffectTable.HeaderText = "EffectTable";
            this.EffectTable.Name = "EffectTable";
            // 
            // CheckEffectQuery
            // 
            this.CheckEffectQuery.DataPropertyName = "CheckEffectQuery";
            this.CheckEffectQuery.HeaderText = "CheckEffectQuery";
            this.CheckEffectQuery.Name = "CheckEffectQuery";
            // 
            // requirementsLabel
            // 
            this.requirementsLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.requirementsLabel.AutoSize = true;
            this.requirementsLabel.Location = new System.Drawing.Point(6, 198);
            this.requirementsLabel.Name = "requirementsLabel";
            this.requirementsLabel.Size = new System.Drawing.Size(72, 13);
            this.requirementsLabel.TabIndex = 16;
            this.requirementsLabel.Text = "Requirements";
            // 
            // pictureBox
            // 
            this.pictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox.Location = new System.Drawing.Point(86, 124);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(646, 63);
            this.pictureBox.TabIndex = 15;
            this.pictureBox.TabStop = false;
            // 
            // browseImgBtn
            // 
            this.browseImgBtn.Location = new System.Drawing.Point(86, 95);
            this.browseImgBtn.Name = "browseImgBtn";
            this.browseImgBtn.Size = new System.Drawing.Size(99, 23);
            this.browseImgBtn.TabIndex = 13;
            this.browseImgBtn.Text = "Browse";
            this.browseImgBtn.UseVisualStyleBackColor = true;
            // 
            // imgLabel
            // 
            this.imgLabel.AutoSize = true;
            this.imgLabel.Location = new System.Drawing.Point(6, 100);
            this.imgLabel.Name = "imgLabel";
            this.imgLabel.Size = new System.Drawing.Size(36, 13);
            this.imgLabel.TabIndex = 14;
            this.imgLabel.Text = "Image";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(86, 39);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(646, 46);
            this.textBox2.TabIndex = 12;
            // 
            // contentLabel
            // 
            this.contentLabel.AutoSize = true;
            this.contentLabel.Location = new System.Drawing.Point(6, 42);
            this.contentLabel.Name = "contentLabel";
            this.contentLabel.Size = new System.Drawing.Size(44, 13);
            this.contentLabel.TabIndex = 11;
            this.contentLabel.Text = "Content";
            // 
            // questionTypeComboBox
            // 
            this.questionTypeComboBox.FormattingEnabled = true;
            this.questionTypeComboBox.Location = new System.Drawing.Point(86, 8);
            this.questionTypeComboBox.Name = "questionTypeComboBox";
            this.questionTypeComboBox.Size = new System.Drawing.Size(99, 21);
            this.questionTypeComboBox.TabIndex = 10;
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(6, 11);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(31, 13);
            this.typeLabel.TabIndex = 9;
            this.typeLabel.Text = "Type";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 525);
            this.Controls.Add(this.editQuestionPanel);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.importBtn);
            this.Controls.Add(this.questionPanel);
            this.Name = "MainForm";
            this.Text = "DBI Exam Creator";
            this.questionPanel.ResumeLayout(false);
            this.editQuestionPanel.ResumeLayout(false);
            this.editQuestionPanel.PerformLayout();
            this.candidateControl.ResumeLayout(false);
            this.candidate1.ResumeLayout(false);
            this.candidatePanel.ResumeLayout(false);
            this.candidatePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel questionPanel;
        private System.Windows.Forms.Button question1Btn;
        private System.Windows.Forms.Button addQuestionBtn;
        private System.Windows.Forms.Button importBtn;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Panel editQuestionPanel;
        private System.Windows.Forms.Label pointLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabControl candidateControl;
        private System.Windows.Forms.TabPage candidate1;
        private System.Windows.Forms.OpenFileDialog browseImgDialog;
        private System.Windows.Forms.Button addCandidateBtn;
        private System.Windows.Forms.Panel candidatePanel;
        private System.Windows.Forms.Button addRequirementBtn;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn RequirementId;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn ResultQuery;
        private System.Windows.Forms.DataGridViewTextBoxColumn EffectTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckEffectQuery;
        private System.Windows.Forms.Label requirementsLabel;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button browseImgBtn;
        private System.Windows.Forms.Label imgLabel;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label contentLabel;
        private System.Windows.Forms.ComboBox questionTypeComboBox;
        private System.Windows.Forms.Label typeLabel;
    }
}

