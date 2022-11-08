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
    public partial class frmEditQuestion : Form
    {
        int i;
        public frmEditQuestion()
        {
            InitializeComponent();
        }

        private void frmEditQuestion_Load(object sender, EventArgs e)
        {
            try
            {
                Temp.qa = Temp.soq.qa;

                i = 0;
                rtbContent.Text = Temp.qa[i]._strContentQuestion;
                txtA.Text = Temp.qa[i]._strListAnswer[0];
                txtB.Text = Temp.qa[i]._strListAnswer[1];
                txtC.Text = Temp.qa[i]._strListAnswer[2];
                txtD.Text = Temp.qa[i]._strListAnswer[3];
                if (Temp.qa[i]._iCorrectAnswer == 0)
                {
                    rdbA.Checked = true;
                }
                if (Temp.qa[i]._iCorrectAnswer == 1)
                {
                    rdbB.Checked = true;
                }
                if (Temp.qa[i]._iCorrectAnswer == 2)
                {
                    rdbC.Checked = true;
                }
                if (Temp.qa[i]._iCorrectAnswer == 3)
                {
                    rdbD.Checked = true;
                }
                btnBack.Enabled = false;

                if (Temp.soq._iNumOfQ == 1)
                {
                    btnNext.Enabled = false;
                }
                else
                {
                    btnNext.Enabled = true;
                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                Temp.qa[i]._strContentQuestion = rtbContent.Text;
                Temp.qa[i]._strListAnswer = new List<string> { txtA.Text, txtB.Text, txtC.Text, txtD.Text };
                if (rdbA.Checked)
                    Temp.qa[i]._iCorrectAnswer = 0;
                else if (rdbB.Checked)
                    Temp.qa[i]._iCorrectAnswer = 1;
                else if (rdbC.Checked)
                    Temp.qa[i]._iCorrectAnswer = 2;
                else if (rdbD.Checked)
                    Temp.qa[i]._iCorrectAnswer = 3;
                else
                {
                    MessageBox.Show("Bạn chưa chọn đáp án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

                        }
                        else
                        {
                            btnNext.Enabled = true;
                        }
                    }

                }
                rtbContent.Text = Temp.qa[i]._strContentQuestion;
                txtA.Text = Temp.qa[i]._strListAnswer[0];
                txtB.Text = Temp.qa[i]._strListAnswer[1];
                txtC.Text = Temp.qa[i]._strListAnswer[2];
                txtD.Text = Temp.qa[i]._strListAnswer[3];
                if (Temp.qa[i]._iCorrectAnswer == 0)
                {
                    rdbA.Checked = true;
                }
                if (Temp.qa[i]._iCorrectAnswer == 1)
                {
                    rdbB.Checked = true;
                }
                if (Temp.qa[i]._iCorrectAnswer == 2)
                {
                    rdbC.Checked = true;
                }
                if (Temp.qa[i]._iCorrectAnswer == 3)
                {
                    rdbD.Checked = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            try
            {
                Temp.qa[i]._strContentQuestion = rtbContent.Text;
                Temp.qa[i]._strListAnswer = new List<string> { txtA.Text, txtB.Text, txtC.Text, txtD.Text };

                if (rdbA.Checked)
                    Temp.qa[i]._iCorrectAnswer = 0;
                else if (rdbB.Checked)
                    Temp.qa[i]._iCorrectAnswer = 1;
                else if (rdbC.Checked)
                    Temp.qa[i]._iCorrectAnswer = 2;
                else if (rdbD.Checked)
                    Temp.qa[i]._iCorrectAnswer = 3;
                else
                {
                    MessageBox.Show("Bạn chưa chọn đáp án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

                        }
                        else
                        {
                            btnNext.Enabled = true;

                        }
                    }


                }
                rtbContent.Text = Temp.qa[i]._strContentQuestion;
                txtA.Text = Temp.qa[i]._strListAnswer[0];
                txtB.Text = Temp.qa[i]._strListAnswer[1];
                txtC.Text = Temp.qa[i]._strListAnswer[2];
                txtD.Text = Temp.qa[i]._strListAnswer[3];
                if (Temp.qa[i]._iCorrectAnswer == 0)
                {
                    rdbA.Checked = true;
                }
                if (Temp.qa[i]._iCorrectAnswer == 1)
                {
                    rdbB.Checked = true;
                }
                if (Temp.qa[i]._iCorrectAnswer == 2)
                {
                    rdbC.Checked = true;
                }
                if (Temp.qa[i]._iCorrectAnswer == 3)
                {
                    rdbD.Checked = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                Temp.qa = new List<QuestionAnswer>();
                this.Close();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                Temp.qa[i]._strContentQuestion = rtbContent.Text;
                Temp.qa[i]._strListAnswer = new List<string> { txtA.Text, txtB.Text, txtC.Text, txtD.Text };

                if (rdbA.Checked)
                    Temp.qa[i]._iCorrectAnswer = 0;
                else if (rdbB.Checked)
                    Temp.qa[i]._iCorrectAnswer = 1;
                else if (rdbC.Checked)
                    Temp.qa[i]._iCorrectAnswer = 2;
                else if (rdbD.Checked)
                    Temp.qa[i]._iCorrectAnswer = 3;
                else
                {
                    MessageBox.Show("Bạn chưa chọn đáp án!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                DialogResult r = MessageBox.Show("Bạn có muốn lưu và thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    Temp.soq.qa = Temp.qa;
                    Temp.Check = true;
                    this.Close();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
