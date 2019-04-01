using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class ProgressBarForm : Form
    {
        public ProgressBarForm(Action worker)
        {
            InitializeComponent();
            Worker = worker;
        }

        public Action Worker { get; set; }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(task => { Close(); },
                TaskScheduler.FromCurrentSynchronizationContext());
        }
    }
}