using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Released1
{
    public partial class frmShowQuestionInTest : Form
    {
        public frmShowQuestionInTest()
        {
            InitializeComponent();
        }
        int i;
        private void frmShowQuestionInTest_Load(object sender, EventArgs e)
        {
            i = 0;
            rdbA.Checked = true;
            btnBack.Enabled = false;
            lblIndex.Text = "<Câu hỏi số " + (i + 1).ToString() + ">";
            rtbContent.Text = Temp.test._qaListQuestionAnswer[i]._strContentQuestion;
            txtA.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[0];
            txtB.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[1];
            txtC.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[2];
            txtD.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[3];
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rdbA.Checked)
                Temp.test._iUserAnswer[i] = 0;
            else if (rdbB.Checked)
                Temp.test._iUserAnswer[i] = 1;
            else if (rdbC.Checked)
                Temp.test._iUserAnswer[i] = 2;
            else if (rdbD.Checked)
                Temp.test._iUserAnswer[i] = 3;

            i++;

            if (i == 0)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
            }
            else if (i == Temp.test._iNumOfQ - 1)
            {
                btnBack.Enabled = true;
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnBack.Enabled = true;
            }
            lblIndex.Text = "<Câu hỏi số " + (i + 1).ToString() + ">";
            rtbContent.Text = Temp.test._qaListQuestionAnswer[i]._strContentQuestion;
            txtA.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[0];
            txtB.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[1];
            txtC.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[2];
            txtD.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[3];
            if (Temp.test._iUserAnswer[i] == 0)
                rdbA.Checked = true;
            else if (Temp.test._iUserAnswer[i] == 1)
                rdbB.Checked = true;
            else if (Temp.test._iUserAnswer[i] == 2)
                rdbC.Checked = true;
            else if (Temp.test._iUserAnswer[i] == 3)
                rdbD.Checked = true;


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (rdbA.Checked)
                Temp.test._iUserAnswer[i] = 0;
            else if (rdbB.Checked)
                Temp.test._iUserAnswer[i] = 1;
            else if (rdbC.Checked)
                Temp.test._iUserAnswer[i] = 2;
            else if (rdbD.Checked)
                Temp.test._iUserAnswer[i] = 3;
            i--;

            if (i == 0)
            {
                btnBack.Enabled = false;
                btnNext.Enabled = true;
            }
            else if (i == Temp.test._iNumOfQ - 1)
            {
                btnBack.Enabled = true;
                btnNext.Enabled = false;
            }
            else
            {
                btnNext.Enabled = true;
                btnBack.Enabled = true;
            }
            lblIndex.Text = "<Câu hỏi số " + (i + 1).ToString() + ">";
            rtbContent.Text = Temp.soq.qa[i]._strContentQuestion;
            txtA.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[0];
            txtB.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[1];
            txtC.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[2];
            txtD.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[3];
            if (Temp.test._iUserAnswer[i] == 0)
                rdbA.Checked = true;
            else if (Temp.test._iUserAnswer[i] == 1)
                rdbB.Checked = true;
            else if (Temp.test._iUserAnswer[i] == 2)
                rdbC.Checked = true;
            else if (Temp.test._iUserAnswer[i] == 3)
                rdbD.Checked = true;

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (rdbA.Checked)
                Temp.test._iUserAnswer[i] = 0;
            else if (rdbB.Checked)
                Temp.test._iUserAnswer[i] = 1;
            else if (rdbC.Checked)
                Temp.test._iUserAnswer[i] = 2;
            else if (rdbD.Checked)
                Temp.test._iUserAnswer[i] = 3;
            DialogResult r = MessageBox.Show("Bạn có muốn nộp bài?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Hide();
                frmResultAndReviewTest frmResultAndReviewTest = new frmResultAndReviewTest();
                frmResultAndReviewTest.ShowDialog();
            }
        }
    }
}
