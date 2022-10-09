using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class form_ServerPort : Form
    {
       
        public form_ServerPort()
        {
            InitializeComponent();
            txtPort.Text = "9050";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e) { 
        
            if (string.IsNullOrEmpty(txtPort.Text))
            {
                MessageBox.Show("Nhập port để khởi động server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
                DataServer.port = txtPort.Text;
            }
            
           
        }

        private void form_ServerPort_Load(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        
        
       
    }
}
