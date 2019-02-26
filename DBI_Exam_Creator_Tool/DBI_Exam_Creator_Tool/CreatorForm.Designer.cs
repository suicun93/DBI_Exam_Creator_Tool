namespace DBI_Exam_Creator_Tool
{
    partial class CreatorForm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeQuestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addCandidateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.removeCandidateToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.previewBtn = new System.Windows.Forms.Button();
            this.questionTabControl = new System.Windows.Forms.TabControl();
            this.exportBtn = new System.Windows.Forms.Button();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.questionToolStripMenuItem,
            this.candidateToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1079, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem,
            this.exportToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // questionToolStripMenuItem
            // 
            this.questionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addQuestionToolStripMenuItem,
            this.removeQuestionToolStripMenuItem});
            this.questionToolStripMenuItem.Name = "questionToolStripMenuItem";
            this.questionToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.questionToolStripMenuItem.Text = "Question";
            // 
            // addQuestionToolStripMenuItem
            // 
            this.addQuestionToolStripMenuItem.Name = "addQuestionToolStripMenuItem";
            this.addQuestionToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.addQuestionToolStripMenuItem.Text = "Add";
            this.addQuestionToolStripMenuItem.Click += new System.EventHandler(this.addQuestionToolStripMenuItem_Click);
            // 
            // removeQuestionToolStripMenuItem
            // 
            this.removeQuestionToolStripMenuItem.Name = "removeQuestionToolStripMenuItem";
            this.removeQuestionToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.removeQuestionToolStripMenuItem.Text = "Remove";
            // 
            // candidateToolStripMenuItem
            // 
            this.candidateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCandidateToolStripMenuItem1,
            this.removeCandidateToolStripMenuItem1});
            this.candidateToolStripMenuItem.Name = "candidateToolStripMenuItem";
            this.candidateToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.candidateToolStripMenuItem.Text = "Candidate";
            // 
            // addCandidateToolStripMenuItem1
            // 
            this.addCandidateToolStripMenuItem1.Name = "addCandidateToolStripMenuItem1";
            this.addCandidateToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.addCandidateToolStripMenuItem1.Text = "Add";
            // 
            // removeCandidateToolStripMenuItem1
            // 
            this.removeCandidateToolStripMenuItem1.Name = "removeCandidateToolStripMenuItem1";
            this.removeCandidateToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.removeCandidateToolStripMenuItem1.Text = "Remove";
            // 
            // previewBtn
            // 
            this.previewBtn.Location = new System.Drawing.Point(915, 27);
            this.previewBtn.Name = "previewBtn";
            this.previewBtn.Size = new System.Drawing.Size(75, 23);
            this.previewBtn.TabIndex = 2;
            this.previewBtn.Text = "Preview";
            this.previewBtn.UseVisualStyleBackColor = true;
            this.previewBtn.Click += new System.EventHandler(this.previewBtn_Click);
            // 
            // questionTabControl
            // 
            this.questionTabControl.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.questionTabControl.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.questionTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.questionTabControl.ItemSize = new System.Drawing.Size(25, 100);
            this.questionTabControl.Location = new System.Drawing.Point(12, 56);
            this.questionTabControl.Multiline = true;
            this.questionTabControl.Name = "questionTabControl";
            this.questionTabControl.SelectedIndex = 0;
            this.questionTabControl.Size = new System.Drawing.Size(1059, 614);
            this.questionTabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.questionTabControl.TabIndex = 0;
            this.questionTabControl.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.questionTabControl_DrawItem);
            this.questionTabControl.Selected += new System.Windows.Forms.TabControlEventHandler(this.questionTabControl_Selected);
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(996, 27);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 3;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            // 
            // CreatorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 675);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.previewBtn);
            this.Controls.Add(this.questionTabControl);
            this.Controls.Add(this.menuStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "CreatorForm";
            this.Text = "CreatorForm";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem questionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeQuestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addCandidateToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem removeCandidateToolStripMenuItem1;
        private System.Windows.Forms.Button previewBtn;
        private System.Windows.Forms.TabControl questionTabControl;
        private System.Windows.Forms.Button exportBtn;
    }
}