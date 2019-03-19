namespace DBI_Exam_Creator_Tool.UI
{
    partial class ExportConfirm
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
            this.label2 = new System.Windows.Forms.Label();
            this.papersNumberInput = new System.Windows.Forms.NumericUpDown();
            this.exportBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.browseBtn = new System.Windows.Forms.Button();
            this.locationTxt = new System.Windows.Forms.TextBox();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.papersNumberInput)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Papers number:";
            // 
            // papersNumberInput
            // 
            this.papersNumberInput.Location = new System.Drawing.Point(99, 12);
            this.papersNumberInput.Name = "papersNumberInput";
            this.papersNumberInput.Size = new System.Drawing.Size(90, 20);
            this.papersNumberInput.TabIndex = 2;
            // 
            // exportBtn
            // 
            this.exportBtn.Location = new System.Drawing.Point(420, 86);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Size = new System.Drawing.Size(75, 23);
            this.exportBtn.TabIndex = 3;
            this.exportBtn.Text = "Export";
            this.exportBtn.UseVisualStyleBackColor = true;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(46, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Save to:";
            // 
            // browseBtn
            // 
            this.browseBtn.Location = new System.Drawing.Point(420, 49);
            this.browseBtn.Name = "browseBtn";
            this.browseBtn.Size = new System.Drawing.Size(75, 23);
            this.browseBtn.TabIndex = 5;
            this.browseBtn.Text = "Browse";
            this.browseBtn.UseVisualStyleBackColor = true;
            this.browseBtn.Click += new System.EventHandler(this.browseBtn_Click);
            // 
            // locationTxt
            // 
            this.locationTxt.Enabled = false;
            this.locationTxt.Location = new System.Drawing.Point(99, 51);
            this.locationTxt.Name = "locationTxt";
            this.locationTxt.Size = new System.Drawing.Size(303, 20);
            this.locationTxt.TabIndex = 6;
            // 
            // ExportConfirm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 126);
            this.Controls.Add(this.locationTxt);
            this.Controls.Add(this.browseBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exportBtn);
            this.Controls.Add(this.papersNumberInput);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ExportConfirm";
            this.ShowInTaskbar = false;
            this.Text = "ExportConfirm";
            ((System.ComponentModel.ISupportInitialize)(this.papersNumberInput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown papersNumberInput;
        private System.Windows.Forms.Button exportBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button browseBtn;
        private System.Windows.Forms.TextBox locationTxt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
    }
}