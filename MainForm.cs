using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HR
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void menuClick (Button btn)
        {
            slidePanel.Top = btn.Top;
            slidePanel.Height = btn.Height;

        }

        private void btnWorkers_Click(object sender, EventArgs e)
        {
            menuClick(btnWorkers);
        }

        private void btnContracts_Click(object sender, EventArgs e)
        {
            menuClick(btnContracts);
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            menuClick(btnSalary);
        }

        private void btnPosition_Click(object sender, EventArgs e)
        {
            menuClick(btnPosition);
        }
    }
}
