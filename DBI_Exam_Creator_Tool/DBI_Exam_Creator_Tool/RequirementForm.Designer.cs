namespace DBI_Exam_Creator_Tool
{
    partial class RequirementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.checkEffectQueryTxt = new System.Windows.Forms.TextBox();
            this.resultQueryTxt = new System.Windows.Forms.TextBox();
            this.requirementIdTxt = new System.Windows.Forms.TextBox();
            this.candidateIdTxt = new System.Windows.Forms.TextBox();
            this.effectTableTxt = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.separator1 = new System.Windows.Forms.Label();
            this.separator2 = new System.Windows.Forms.Label();
            this.saveBtn = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.activateTriggerQueryTxt = new System.Windows.Forms.TextBox();
            this.requireSortCheckBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.outputParameterTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "RequirementId";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "CandidateId";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Result Query";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 283);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Effect Table";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 317);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Check Effect Query";
            // 
            // checkEffectQueryTxt
            // 
            this.checkEffectQueryTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkEffectQueryTxt.Location = new System.Drawing.Point(131, 314);
            this.checkEffectQueryTxt.Multiline = true;
            this.checkEffectQueryTxt.Name = "checkEffectQueryTxt";
            this.checkEffectQueryTxt.Size = new System.Drawing.Size(670, 63);
            this.checkEffectQueryTxt.TabIndex = 6;
            // 
            // resultQueryTxt
            // 
            this.resultQueryTxt.Location = new System.Drawing.Point(132, 120);
            this.resultQueryTxt.Multiline = true;
            this.resultQueryTxt.Name = "resultQueryTxt";
            this.resultQueryTxt.Size = new System.Drawing.Size(669, 91);
            this.resultQueryTxt.TabIndex = 7;
            // 
            // requirementIdTxt
            // 
            this.requirementIdTxt.Location = new System.Drawing.Point(132, 6);
            this.requirementIdTxt.Name = "requirementIdTxt";
            this.requirementIdTxt.ReadOnly = true;
            this.requirementIdTxt.Size = new System.Drawing.Size(135, 20);
            this.requirementIdTxt.TabIndex = 8;
            // 
            // candidateIdTxt
            // 
            this.candidateIdTxt.Location = new System.Drawing.Point(132, 37);
            this.candidateIdTxt.Name = "candidateIdTxt";
            this.candidateIdTxt.ReadOnly = true;
            this.candidateIdTxt.Size = new System.Drawing.Size(135, 20);
            this.candidateIdTxt.TabIndex = 9;
            // 
            // effectTableTxt
            // 
            this.effectTableTxt.Location = new System.Drawing.Point(132, 280);
            this.effectTableTxt.Name = "effectTableTxt";
            this.effectTableTxt.Size = new System.Drawing.Size(135, 20);
            this.effectTableTxt.TabIndex = 10;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(132, 68);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(135, 21);
            this.typeComboBox.TabIndex = 11;
            // 
            // separator1
            // 
            this.separator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator1.Location = new System.Drawing.Point(-7, 104);
            this.separator1.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separator1.Name = "separator1";
            this.separator1.Size = new System.Drawing.Size(818, 2);
            this.separator1.TabIndex = 12;
            // 
            // separator2
            // 
            this.separator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.separator2.Location = new System.Drawing.Point(-7, 262);
            this.separator2.MaximumSize = new System.Drawing.Size(2000, 2);
            this.separator2.Name = "separator2";
            this.separator2.Size = new System.Drawing.Size(818, 2);
            this.separator2.TabIndex = 13;
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveBtn.Location = new System.Drawing.Point(692, 22);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(108, 48);
            this.saveBtn.TabIndex = 14;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Require Sort";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 401);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Activate Trigger Query";
            // 
            // activateTriggerQueryTxt
            // 
            this.activateTriggerQueryTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.activateTriggerQueryTxt.Location = new System.Drawing.Point(131, 398);
            this.activateTriggerQueryTxt.Multiline = true;
            this.activateTriggerQueryTxt.Name = "activateTriggerQueryTxt";
            this.activateTriggerQueryTxt.Size = new System.Drawing.Size(670, 62);
            this.activateTriggerQueryTxt.TabIndex = 17;
            // 
            // requireSortCheckBox
            // 
            this.requireSortCheckBox.AutoSize = true;
            this.requireSortCheckBox.Location = new System.Drawing.Point(131, 227);
            this.requireSortCheckBox.Name = "requireSortCheckBox";
            this.requireSortCheckBox.Size = new System.Drawing.Size(15, 14);
            this.requireSortCheckBox.TabIndex = 18;
            this.requireSortCheckBox.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 496);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Output Parameter";
            // 
            // outputParameterTxt
            // 
            this.outputParameterTxt.Location = new System.Drawing.Point(132, 493);
            this.outputParameterTxt.Name = "outputParameterTxt";
            this.outputParameterTxt.Size = new System.Drawing.Size(135, 20);
            this.outputParameterTxt.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label10.Location = new System.Drawing.Point(-7, 475);
            this.label10.MaximumSize = new System.Drawing.Size(2000, 2);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(818, 2);
            this.label10.TabIndex = 21;
            // 
            // RequirementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 525);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.outputParameterTxt);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.requireSortCheckBox);
            this.Controls.Add(this.activateTriggerQueryTxt);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.separator2);
            this.Controls.Add(this.separator1);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.effectTableTxt);
            this.Controls.Add(this.candidateIdTxt);
            this.Controls.Add(this.requirementIdTxt);
            this.Controls.Add(this.resultQueryTxt);
            this.Controls.Add(this.checkEffectQueryTxt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RequirementForm";
            this.Text = "RequirementForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.RequirementForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox checkEffectQueryTxt;
        private System.Windows.Forms.TextBox resultQueryTxt;
        private System.Windows.Forms.TextBox requirementIdTxt;
        private System.Windows.Forms.TextBox candidateIdTxt;
        private System.Windows.Forms.TextBox effectTableTxt;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label separator1;
        private System.Windows.Forms.Label separator2;
        private System.Windows.Forms.Button saveBtn;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox activateTriggerQueryTxt;
        private System.Windows.Forms.CheckBox requireSortCheckBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox outputParameterTxt;
        private System.Windows.Forms.Label label10;
    }
}