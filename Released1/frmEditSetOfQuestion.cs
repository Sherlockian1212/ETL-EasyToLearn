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
    public partial class frmEditSetOfQuestion : Form
    {
        public frmEditSetOfQuestion()
        {
            InitializeComponent();
        }

        private void frmEditSetOfQuestion_Load(object sender, EventArgs e)
        {
            try
            {
                txtName.Text = Temp.soq._strName;
                txtName.Text = txtName.Text.Remove(txtName.Text.LastIndexOf('.'), 4);

                lblNum.Text = Temp.soq._iNumOfQ.ToString();
            }catch(Exception ex) { MessageBox.Show(ex.Message); }

        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                File.Delete(Application.StartupPath + @"\SOQ\" + Temp.soq._strName);
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //đổi tên file
            try
            {
                if (Temp.soq._strName != txtName.Text +".csv")
                {
                    string oldFilePath = Application.StartupPath + @"\SOQ\" + Temp.soq._strName; // Full path of old file
                    string newFilePath = Application.StartupPath + @"\SOQ\" + txtName.Text + ".csv"; // Full path of new file

                    if (File.Exists(newFilePath))
                    {
                        File.Delete(newFilePath);
                    }
                    File.Move(oldFilePath, newFilePath);

                    Temp.soq._strName = txtName.Text;

                    
                }
                this.Close();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            frmEditQuestion frmEditQuestion = new frmEditQuestion();
            frmEditQuestion.ShowDialog();
            if (Temp.Check == true) {this.Close();Temp.Check = false;}  
            
        }
    }
}
