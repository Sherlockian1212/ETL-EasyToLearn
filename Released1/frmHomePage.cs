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
            try
            {
                cboSearchSetOfQuestion.Items.Clear();
                lstvSetOfQuestion.Items.Clear();


                //load tên bộ câu hỏi
                DirectoryInfo d = new DirectoryInfo(Application.StartupPath + @"\SOQ");
                FileInfo[] DataFile = d.GetFiles();
                int i = 1;
                foreach (FileInfo datafile in DataFile)
                {
                    string data = datafile.Name;
                    Temp.Data_NameOfQ.Add(data);
                    Temp.soq.checkFile(Application.StartupPath + @"\SOQ\" + data);
                    ListViewItem tmp = new ListViewItem();
                    tmp.SubItems[0].Text = i.ToString();
                    tmp.SubItems.Add(data);
                    tmp.SubItems.Add(Temp.soq._iNumOfQ.ToString());
                    lstvSetOfQuestion.Items.Add(tmp);
                    cboSearchSetOfQuestion.Items.Add(data);
                    i++;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboSearchSetOfQuestion.SelectedItem != null)
                {
                    Temp.soq = new SetOfQuestion();
                    Temp.soq._strName = cboSearchSetOfQuestion.Text;
                    Temp.soq.checkFile(Application.StartupPath + @"\SOQ\" + Temp.soq._strName);
                    frmEditSetOfQuestion frmEditSetOfQuestion = new frmEditSetOfQuestion();
                    frmEditSetOfQuestion.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void lstvSetOfQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach(ListViewItem list in lstvSetOfQuestion.Items)
                {
                    if (list.Focused)
                    {
                        cboSearchSetOfQuestion.Text = list.SubItems[1].Text;
                        return;
                    }
                    
                }
                
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void chbShow_CheckedChanged(object sender, EventArgs e)
        {
            if (chbShow.Checked)
            {
                lstvSetOfQuestion.Hide();
                
               
            }
            else
            {
                lstvSetOfQuestion.Show();
                 
            }
        }

        
    }
}
