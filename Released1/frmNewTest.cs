using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Released1
{
    public partial class frmNewTest : Form
    {
        public frmNewTest()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmNewTest_Load(object sender, EventArgs e)
        {
            cboSetOfQuestion.Items.Clear();
            DirectoryInfo d = new DirectoryInfo(Application.StartupPath + @"\SOQ");
            FileInfo[] DataFile = d.GetFiles();
            
            foreach (FileInfo datafile in DataFile)
            {
                string data = datafile.Name;
                cboSetOfQuestion.Items.Add(data);
            }
        }

        private void cboSetOfQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSetOfQuestion.SelectedIndex != -1)
            {
                string list = cboSetOfQuestion.Text;
                Temp.soq = new SetOfQuestion();
                string path = Application.StartupPath + @"\SOQ\" + list;
                Temp.soq.checkFile(path);
                txtNumOfQ.Text = Temp.soq._iNumOfQ.ToString();
            }
           
        }

        List <QuestionAnswer> random(int i, SetOfQuestion soq)
        {
            List<QuestionAnswer> result = soq.qa;
            int j = 0;
            while (j < soq.qa.Count-i)
            {
                Random random = new Random();
                int r = random.Next(result.Count);
                result.Remove(result[r]);
                j++;
            }
            return result;
        }

        private void btnBeginTest_Click(object sender, EventArgs e)
        {
            if (txtNumOfQ.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNumOfQ, "Không được bỏ trống!");
                return;
            }
            foreach (char c in txtNumOfQ.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Số lượng câu hỏi: \nVui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (txtTime.Text.Trim() == "")
            {
                errorProvider1.SetError(txtTime, "Không được bỏ trống!");
                return;
            }
            foreach (char c in txtTime.Text)
            {
                if (!char.IsDigit(c))
                {
                    MessageBox.Show("Thời gian: \nVui lòng nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            if (Convert.ToInt32(txtNumOfQ.Text) > Temp.soq._iNumOfQ)
            {
                MessageBox.Show("Số lượng câu hỏi trong bài kiểm tra lớn hơn số câu hỏi trong bộ câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Convert.ToInt32(txtNumOfQ.Text) <=0)
            {
                MessageBox.Show("Số lượng câu hỏi trong bài kiểm tra phải lớn hơn 0", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // khởi tạo đối tượng bài kiểm tra;
            Temp.test._strName = cboSetOfQuestion.Text;
            Temp.test._iNumOfQ = Convert.ToInt32(txtNumOfQ.Text);
            for(int i = 0; i < Temp.test._iNumOfQ; i++)
            {
                Temp.test._iUserAnswer.Add(-1);
            }
            if (Convert.ToInt32(txtNumOfQ.Text) == Temp.soq.qa.Count)
                Temp.test._qaListQuestionAnswer = Temp.soq.qa;
            else
                Temp.test._qaListQuestionAnswer = random(int.Parse(txtNumOfQ.Text), Temp.soq);

            Temp.test._TimeLimits = Convert.ToInt32(txtTime.Text);
            this.Hide();
            frmShowQuestionInTest frmShowQuestionInTest = new frmShowQuestionInTest();
            frmShowQuestionInTest.ShowDialog();
            
        }
    }
}
