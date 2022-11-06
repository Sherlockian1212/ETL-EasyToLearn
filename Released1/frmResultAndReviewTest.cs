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
    public partial class frmResultAndReviewTest : Form
    {
        public frmResultAndReviewTest()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            
            frmReviewTest frmReviewTest = new frmReviewTest();
            frmReviewTest.ShowDialog();
        }

        private void btnBeginTestAgain_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < Temp.test._iUserAnswer.Count; i++)
                {
                    Temp.test._iUserAnswer[i] = 0;
                }
                this.Hide();
                frmShowQuestionInTest frmShowQuestionInTest = new frmShowQuestionInTest();
                frmShowQuestionInTest.ShowDialog();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frmResultAndReviewTest_Load(object sender, EventArgs e)
        {
            try
            {
                lblName.Text = Temp.test._strName;
                lblAnswer.Text = Temp.test.result().ToString() + "/" + Temp.test._iNumOfQ.ToString();
                double score = (10.0 / Temp.test._iNumOfQ) * Temp.test.result();
                lblScore.Text = Math.Round(score, 2).ToString();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
