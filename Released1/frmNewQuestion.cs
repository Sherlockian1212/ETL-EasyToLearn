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
    public partial class frmNewQuestion : Form
    {
        int i;
        public frmNewQuestion()
        {
            InitializeComponent();
        }

        private void frmNewQuestion_Load(object sender, EventArgs e)
        {
            i = 0;
            btnBack.Enabled = false;
            btnSave.Enabled = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            
            Temp.soq.qa[i]._strContentQuestion = rtbContent.Text;
            Temp.soq.qa[i]._strListAnswer = new List<string> { txtA.Text, txtB.Text, txtC.Text, txtD.Text };

            i++;
            if (i < Temp.soq._iNumOfQ)
            {
                lblIndex.Text = "<Câu hỏi số " + (i + 1).ToString() + ">";
                if (i == 0)
                {
                    btnBack.Enabled = false;
                }
                else
                {
                    btnBack.Enabled = true;
                    if (i == Temp.soq._iNumOfQ - 1)
                    {
                        btnNext.Enabled = false;
                        btnSave.Enabled = true;
                    }
                    else
                    {
                        btnNext.Enabled = true;
                        btnSave.Enabled = false;
                    }
                }

            }
            rtbContent.Text = Temp.soq.qa[i]._strContentQuestion;
            txtA.Text = Temp.soq.qa[i]._strListAnswer[0];
            txtB.Text = Temp.soq.qa[i]._strListAnswer[1];
            txtC.Text = Temp.soq.qa[i]._strListAnswer[2];
            txtD.Text = Temp.soq.qa[i]._strListAnswer[3];

        }

       

        private void btnBack_Click(object sender, EventArgs e)
        {
            Temp.soq.qa[i]._strContentQuestion = rtbContent.Text;
            Temp.soq.qa[i]._strListAnswer = new List<string> { txtA.Text, txtB.Text, txtC.Text, txtD.Text };
            i--;
            if (i < Temp.soq._iNumOfQ)
            {
                lblIndex.Text = "<Câu hỏi số " + (i + 1).ToString() + ">";
                if (i == 0)
                {
                    btnBack.Enabled = false;
                }
                else
                {
                    btnBack.Enabled = true;
                    if (i == Temp.soq._iNumOfQ - 1)
                    {
                        btnNext.Enabled = false;
                        btnSave.Enabled = true;
                    }
                    else
                    {
                        btnNext.Enabled = true;
                        btnSave.Enabled = false;
                    }
                }


            }
            rtbContent.Text = Temp.soq.qa[i]._strContentQuestion;
            txtA.Text = Temp.soq.qa[i]._strListAnswer[0];
            txtB.Text = Temp.soq.qa[i]._strListAnswer[1];
            txtC.Text = Temp.soq.qa[i]._strListAnswer[2];
            txtD.Text = Temp.soq.qa[i]._strListAnswer[3];
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            DialogResult r = MessageBox.Show("Bạn có muốn lưu và thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                Temp.Check = true;
                this.Close();

            }

        }
    }
}
