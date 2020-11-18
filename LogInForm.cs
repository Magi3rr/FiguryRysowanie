using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR
{
    public partial class LogInForm : Form
    {
        public LogInForm()
        {
            InitializeComponent();
        }

        private void BtnCloseLog_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnLogIn_Click(object sender, EventArgs e)
        {
            using (MainForm mf = new MainForm())
            {
                mf.ShowDialog();
            }
        }
    }
}
