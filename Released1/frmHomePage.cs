using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Released1
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
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

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            cboSearchSetOfQuestion.Items.Clear();
            lstvSetOfQuestion.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(Application.StartupPath + @"\SOQ");
            FileInfo[] DataFile = d.GetFiles();//File.ReadAllLines(Application.StartupPath+ @"\Data\Data.txt");


            int i = 1;
            foreach (FileInfo datafile in DataFile)
            {
                string data = datafile.Name;
                Temp.Data_NameOfQ.Add(data);
                ListViewItem tmp = new ListViewItem();
                tmp.SubItems[0].Text = i.ToString();
                tmp.SubItems.Add(data);
                lstvSetOfQuestion.Items.Add(tmp);
                cboSearchSetOfQuestion.Items.Add(data);
                i++;
            }
            
        }

        
    }
}
