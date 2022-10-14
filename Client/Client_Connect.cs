using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_MultiChat
{
    public partial class form_ClientConnect : Form
    {
        public form_ClientConnect()
        {
            InitializeComponent();
            txt_Port.Text = "9050";
            txtMK.PasswordChar = '*';
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Port.Text)||string.IsNullOrEmpty(txtTaiKhoan.Text)||string.IsNullOrEmpty(txtMK.Text))
            {
                MessageBox.Show("Nhập thông tin để kết nối tới server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                bool flag = false;
                DataClient.createUserData();

                foreach (Account account in DataClient.dataLogin)
                    {

                    if (string.Compare(account.user,txtTaiKhoan.Text)==0 && string.Compare(account.password,txtMK.Text) == 0)
                        {
                            DataClient.portClient = txt_Port.Text;
                            DataClient.user = txtTaiKhoan.Text;
                            DataClient.password = txtMK.Text;
                            this.DialogResult = DialogResult.OK;
                            flag = true;
                            break;
                        }
                    }
                if (!flag)
                {
                    MessageBox.Show("sai tài khoản hoặc mật khẩu", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;

                }
                   
            
               
            }
        }

        private void form_ClientConnect_Load(object sender, EventArgs e)
        {

        }
    }
}
