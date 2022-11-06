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
using System.Xml;

namespace Released1
{
    public partial class frmShowQuestionInTest : Form
    {
        public frmShowQuestionInTest()
        {
            InitializeComponent();
            timer1.Start();
            Temp.Check = false;
        }
        
        int i;

        private void frmShowQuestionInTest_Load(object sender, EventArgs e)
        {
            try
            {
                lblTime.Text = Temp.test._TimeLimits.ToString() + ":00";
                i = 0;
                rdbA.Checked = true;
                btnBack.Enabled = false;
                lblIndex.Text = "<Câu hỏi số " + (i + 1).ToString() + ">";
                rtbContent.Text = Temp.test._qaListQuestionAnswer[i]._strContentQuestion;
                lblA.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[0];
                lblB.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[1];
                lblC.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[2];
                lblD.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[3];
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
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
                lblA.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[0];
                lblB.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[1];
                lblC.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[2];
                lblD.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[3];
                if (Temp.test._iUserAnswer[i] == 0)
                    rdbA.Checked = true;
                else if (Temp.test._iUserAnswer[i] == 1)
                    rdbB.Checked = true;
                else if (Temp.test._iUserAnswer[i] == 2)
                    rdbC.Checked = true;
                else if (Temp.test._iUserAnswer[i] == 3)
                    rdbD.Checked = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
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
                lblA.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[0];
                lblB.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[1];
                lblC.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[2];
                lblD.Text = Temp.test._qaListQuestionAnswer[i]._strListAnswer[3];
                if (Temp.test._iUserAnswer[i] == 0)
                    rdbA.Checked = true;
                else if (Temp.test._iUserAnswer[i] == 1)
                    rdbB.Checked = true;
                else if (Temp.test._iUserAnswer[i] == 2)
                    rdbC.Checked = true;
                else if (Temp.test._iUserAnswer[i] == 3)
                    rdbD.Checked = true;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
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
                    timer1.Stop();
                    Temp.Check = true;
                    this.Hide();
                    frmResultAndReviewTest frmResultAndReviewTest = new frmResultAndReviewTest();
                    frmResultAndReviewTest.ShowDialog();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        int mi = Temp.test._TimeLimits, se;

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                se--;
                if (mi == 0 && se == 0)
                {
                    timer1.Stop();

                    if (rdbA.Checked)
                        Temp.test._iUserAnswer[i] = 0;
                    else if (rdbB.Checked)
                        Temp.test._iUserAnswer[i] = 1;
                    else if (rdbC.Checked)
                        Temp.test._iUserAnswer[i] = 2;
                    else if (rdbD.Checked)
                        Temp.test._iUserAnswer[i] = 3;
                    MessageBox.Show("Hết thời gian làm bài!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Hide();
                    frmResultAndReviewTest frmResultAndReviewTest = new frmResultAndReviewTest();
                    frmResultAndReviewTest.ShowDialog();
                    return;
                }
                if (se == -1)
                {
                    se = 59;
                    mi--;
                }
                string stmi = "", stse = "";
                if (mi < 10)
                {
                    stmi = "0" + mi.ToString();
                }
                else
                {
                    stmi = mi.ToString();
                }
                if (se < 10)
                {
                    stse = "0" + se.ToString();
                }
                else
                {
                    stse = se.ToString();
                }
                lblTime.Text = stmi + ":" + stse;
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            try
            {
                if (lblTime.Visible)
                {
                    lblTime.Visible = false;
                }
                else
                {
                    lblTime.Visible = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmShowQuestionInTest_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (Temp.Check == false)
                {
                    DialogResult r = MessageBox.Show("Bạn có muốn nộp bài?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (r == DialogResult.Yes)
                    {
                        timer1.Stop();
                        Temp.Check = true;
                        this.Hide();
                        frmResultAndReviewTest frmResultAndReviewTest = new frmResultAndReviewTest();
                        frmResultAndReviewTest.ShowDialog();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

    }
}
