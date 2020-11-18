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

        private void SlidePanel (Button btn)
        {
            slidePanel.Top = btn.Top;
            slidePanel.Height = btn.Height;
            slidePanel.Visible = btn.Enabled;
           
        }

    

        private void BtnWorkers_Click(object sender, EventArgs e)
        {
            SlidePanel(btnWorkers);

            WorkersForm wf = new WorkersForm();
            wf.TopLevel = false;
            centerPanel.Controls.Add(wf);
            wf.Show();
        }



        private void BtnSalary_Click(object sender, EventArgs e)
        {
            SlidePanel(btnSalary);
        }

        private void BtnPosition_Click(object sender, EventArgs e)
        {
            SlidePanel(btnPosition);
        }
    }
}
