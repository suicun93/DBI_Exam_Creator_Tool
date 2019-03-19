using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class InputScriptForm : Form
    {
        private delegate bool HandleClose(List<string> scripts);
        private HandleClose handleClose;

        public InputScriptForm()
        {
            InitializeComponent();
        }

        public InputScriptForm(Func<List<string>, bool> _handleClose, List<string> scriptList)
        {
            InitializeComponent();
            this.handleClose = new HandleClose(_handleClose);

            for (var i = 0; i < tabControl.TabPages.Count; i++)
            {
                RichTextBox box = new RichTextBox();
                box.Name = "scriptTextBox";
                box.Dock = DockStyle.Fill;

                tabControl.TabPages[i].Controls.Add(box);
            }

            for (var i = 0; i < scriptList.Count && i < tabControl.TabPages.Count; i++)
            {
                tabControl.TabPages[i].Controls["scriptTextBox"].Text = scriptList[i];
            }
        }

        private void InputScriptForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            List<string> scriptList = new List<string>();
            foreach (TabPage tab in tabControl.TabPages)
            {
                string script = ((RichTextBox)tab.Controls["scriptTextBox"]).Text;
                scriptList.Add(script);
            }
            handleClose(scriptList);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
