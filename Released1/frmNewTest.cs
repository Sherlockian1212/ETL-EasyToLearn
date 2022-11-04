using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            int i = 1;
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
                
                txtNumOfQ.Text = Temp.Data_NumberOfQ[cboSetOfQuestion.SelectedIndex];
            }
           
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
            if (Convert.ToInt32(txtNumOfQ.Text) > Convert.ToInt32(Temp.Data_NumberOfQ[cboSetOfQuestion.SelectedIndex]))
            {
                MessageBox.Show("Số lượng câu hỏi trong bài kiểm tra lớn hơn số câu hỏi trong bộ câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            frmShowQuestionInTest frmShowQuestionInTest = new frmShowQuestionInTest();
            frmShowQuestionInTest.ShowDialog();
        }
    }
}
