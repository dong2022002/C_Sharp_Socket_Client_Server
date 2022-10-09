using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCp_MultiChat
{
    public partial class form_ServerPort : Form
    {
        public form_ServerPort()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtPort.Text))
            {
                var frmServer = new form_ServerPort();
                frmServer.ShowDialog();
            }
            else
            {
                MessageBox.Show("Nh?p port ð? kh?i ð?ng server", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void form_ServerPort_Load(object sender, EventArgs e)
        {

        }
    }
}