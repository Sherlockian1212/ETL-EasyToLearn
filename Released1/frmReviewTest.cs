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
    public partial class frmReviewTest : Form
    {
        public frmReviewTest()
        {
            InitializeComponent();
        }
        int i;
        string correct(int i)
        {
            if (Temp.test._qaListQuestionAnswer[i]._iCorrectAnswer == 0) return "A";
            if (Temp.test._qaListQuestionAnswer[i]._iCorrectAnswer == 1) return "B";
            if (Temp.test._qaListQuestionAnswer[i]._iCorrectAnswer == 2) return "C";
            if (Temp.test._qaListQuestionAnswer[i]._iCorrectAnswer == 3) return "D";
            return "0";

        }
        private void frmReviewTest_Load(object sender, EventArgs e)
        {
            i = 0;
            
            btnBack.Enabled = false;
            lblIndex.Text = "<Câu hỏi số " + (i + 1).ToString() + ">";
            lblCorrectAnswer.Text = "Câu trả lời đúng: " + correct(i);
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
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
            lblCorrectAnswer.Text = "Câu trả lời đúng: " + correct(i);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
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
            lblCorrectAnswer.Text = "Câu trả lời đúng: " + correct(i);
        }
    }
}
