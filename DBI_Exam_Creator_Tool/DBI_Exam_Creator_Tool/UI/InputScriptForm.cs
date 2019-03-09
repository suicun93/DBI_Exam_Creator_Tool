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

            foreach (string s in scriptList)
            {
                addScriptTab(s);
            }
        }

        private void addScriptTab(string script)
        {

            RichTextBox box = new RichTextBox();
            box.Name = "scriptTextBox";
            box.Text = script;
            box.Dock = DockStyle.Fill;

            TabPage tab = new TabPage();
            tab.Controls.Add(box);

            tabControl.TabPages.Add(tab);

            printTabName();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            addScriptTab("");
        }

        private void removeBtn_Click(object sender, EventArgs e)
        {
            TabPage tab = tabControl.TabPages[tabControl.SelectedIndex];
            tabControl.TabPages.Remove(tab);

            printTabName();
        }

        private void printTabName()
        {
            for (int i = 0; i < tabControl.TabPages.Count; i++)
            {
                tabControl.TabPages[i].Text = "Database " + (i + 1);
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
    }
}
