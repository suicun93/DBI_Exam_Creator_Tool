using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DBI_Exam_Creator_Tool.Entities;
using DBI_Exam_Creator_Tool.Commons;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class RequirementForm : Form
    {
        public bool discarded = false;
        public Requirement Requirement { get; set; }
        private Requirement draftReq;

        public RequirementForm()
        {
            InitializeComponent();
        }

        public RequirementForm(Requirement requirement)
        {
            InitializeComponent();
            Requirement = requirement;

            draftReq = CopyRequirement(requirement);

            // Bind data with controls
            requirementIdTxt.Text = draftReq.RequirementId.ToString();
            candidateIdTxt.Text = draftReq.CandidateId.ToString();

            typeComboBox.DataSource = new BindingSource(Constants.RequirementTypes(), null);
            typeComboBox.DisplayMember = "Key";
            typeComboBox.ValueMember = "Value";

            typeComboBox.DataBindings.Add("SelectedItem", draftReq, "Type");
            resultQueryTxt.DataBindings.Add("Text", draftReq, "ResultQuery");
            requireSortCheckBox.DataBindings.Add("Checked", draftReq, "RequireSort");
            effectTableTxt.DataBindings.Add("Text", draftReq, "EffectTable");
            checkEffectQueryTxt.DataBindings.Add("Text", draftReq, "CheckEffectQuery");
            activateTriggerQueryTxt.DataBindings.Add("Text", draftReq, "ActivateTriggerQuery");
            outputParameterTxt.DataBindings.Add("Text", draftReq, "OutputParameter");
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Are you sure?", "Save confirm", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Requirement = draftReq;
                Dispose();
            }
            else if (dialogResult == DialogResult.No)
            {
                // do nothing
            }
        }

        private Requirement CopyRequirement(Requirement req)
        {
            return new Requirement(req.RequirementId, req.CandidateId, req.Type,
                req.ResultQuery, req.RequireSort, req.EffectTable, req.CheckEffectQuery, req.ActivateTriggerQuery, req.OutputParameter);
        }

        private void RequirementForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            var dialogResult = MessageBox.Show("Discard change?", "", MessageBoxButtons.YesNo);
            discarded = (dialogResult == DialogResult.Yes);
            e.Cancel = (dialogResult == DialogResult.No);
        }
        
    }
}
