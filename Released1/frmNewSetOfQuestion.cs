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
    public partial class frmNewSetOfQuestion : Form
    {
        public frmNewSetOfQuestion()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtName.Text.Trim() == "")
            {
                errorProvider1.SetError(txtName, "Không được bỏ trống!");
                return;
            }
            if (txtNumber.Text.Trim() == "")
            {
                errorProvider1.SetError(txtNumber, "Không được bỏ trống!");
                return;
            }
            foreach (char c in txtNumber.Text)
            {
                if (!char.IsDigit(c))
                {
                    errorProvider1.SetError(txtNumber, "Vui lòng nhập số");
                    return;
                }
            }
            Temp.soq._iNumOfQ = Convert.ToInt32(txtNumber.Text.Trim());
            if (rdbImportFile.Checked)
            {
                frmImportFileQuestion question = new frmImportFileQuestion();
                question.ShowDialog();
                
            }
            else
            {
                if (rdbNewQuestion.Checked)
                {
                    Temp.soq.qa.Clear();
                    for (int i = 0; i< Convert.ToInt32(txtNumber.Text); i++)
                    {
                        Temp.soq.qa.Add(new QuestionAnswer());
                    }
                    frmNewQuestion question = new frmNewQuestion();
                    question.ShowDialog();
                    if (Temp.Check)
                    {
                        this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn hình thức thêm câu hỏi!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            
            if (txtName.Text.Trim() == "")
            {
                
                errorProvider1.SetError(txtName, "Không được bỏ trống!");
            }
            else
            {
                errorProvider1.Clear();
            }
           
        }

        private void txtNumber_Leave(object sender, EventArgs e)
        {
            if (txtNumber.Text.Trim() == "")
            {

                errorProvider1.SetError(txtNumber, "Không được bỏ trống!");
            }
            else
            {
                errorProvider1.Clear();
            }
        }
    }
}
