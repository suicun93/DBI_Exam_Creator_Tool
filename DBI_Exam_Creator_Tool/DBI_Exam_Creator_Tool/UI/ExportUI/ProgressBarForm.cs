﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBI_Exam_Creator_Tool.UI
{
    public partial class ProgressBarForm : Form
    {
        public Action Worker { get; set; }
        public ProgressBarForm(Action worker)
        {
            InitializeComponent();
            Worker = worker;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            Task.Factory.StartNew(Worker).ContinueWith(task => { Close(); },
                TaskScheduler.FromCurrentSynchronizationContext());
        }


    }
}
