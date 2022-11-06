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
    public partial class frmNewSetOfQuestion : Form
    {
        public frmNewSetOfQuestion()
        {
            InitializeComponent();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult r = MessageBox.Show("Bạn có muốn thoát?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (r == DialogResult.Yes)
                {
                    this.Close();
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text.Trim() == "")
                {
                    errorProvider1.SetError(txtName, "Không được bỏ trống!");
                    return;
                }
                if (txtNumber.Text.Trim() == "" && !rdbImportFile.Checked)
                {
                    errorProvider1.SetError(txtNumber, "Không được bỏ trống!");
                    return;
                }
                if (!rdbImportFile.Checked && Convert.ToInt32(txtNumber.Text) == 0)
                {
                    errorProvider1.SetError(txtNumber, "Số lượng câu hỏi phải lớn hơn 0");
                    return;
                }
                if (!rdbImportFile.Checked)
                    foreach (char c in txtNumber.Text)
                    {
                        if (!char.IsDigit(c))
                        {
                            errorProvider1.SetError(txtNumber, "Vui lòng nhập lại");
                            return;
                        }
                    }



                if (rdbImportFile.Checked)
                {
                    Temp.soq._strName = txtName.Text;
                    frmImportFileQuestion question = new frmImportFileQuestion();
                    question.ShowDialog();
                    if (Temp.Check)
                    {
                        this.Close();
                    }

                }
                else
                {
                    if (rdbNewQuestion.Checked)
                    {
                        Temp.soq._iNumOfQ = Convert.ToInt32(txtNumber.Text.Trim());
                        Temp.soq._strName = txtName.Text;
                        Temp.soq.qa.Clear();
                        for (int i = 0; i < Convert.ToInt32(txtNumber.Text); i++)
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            try
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
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void rdbImportFile_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (rdbImportFile.Checked)
                {
                    txtNumber.Text = "";
                    txtNumber.Enabled = false;
                    errorProvider1.Clear();

                }
                else
                {
                    txtNumber.Enabled = true;
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
