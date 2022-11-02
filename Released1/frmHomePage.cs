using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Released1
{
    public partial class frnHomePage : Form
    {
        public frnHomePage()
        {
            InitializeComponent();
        }

        private void btnStatistical_Click(object sender, EventArgs e)
        {
            frmStatistical frmStatistical = new frmStatistical();
            frmStatistical.ShowDialog();
        }

        private void btnNewTest_Click(object sender, EventArgs e)
        {
            frmNewTest frmNewTest = new frmNewTest();
            frmNewTest.ShowDialog();
        }

        private void btnNewSetOfQuestion_Click(object sender, EventArgs e)
        {
            frmNewSetOfQuestion frmNewSetOfQuestion = new frmNewSetOfQuestion();
            frmNewSetOfQuestion.ShowDialog();
        }
    }
}
