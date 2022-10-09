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
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_KetNoi_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_Port.Text))
            {
                MessageBox.Show("Nhập port để kết nối tới server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                DataClient.port = txt_Port.Text;
            }
        }

        private void form_ClientConnect_Load(object sender, EventArgs e)
        {

        }
    }
}
