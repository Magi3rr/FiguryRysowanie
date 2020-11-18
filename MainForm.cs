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

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuClick (Button btn)
        {
            slidePanel.Top = btn.Top;
            slidePanel.Height = btn.Height;
            slidePanel.Visible = btn.Enabled;
           
        }


        public void BtnWorkers_Click(object sender, EventArgs e)
        {
            MenuClick(btnWorkers);
           
           
            workersForm wf = new workersForm();

            wf.Show();

        }

        private void BtnContracts_Click(object sender, EventArgs e)
        {
            MenuClick(btnContracts);
        }

        private void BtnSalary_Click(object sender, EventArgs e)
        {
            MenuClick(btnSalary);
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            MenuClick(btnPosition);
        }
    }
}
