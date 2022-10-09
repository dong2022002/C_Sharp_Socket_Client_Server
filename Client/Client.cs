using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_MultiChat
{
    public partial class form_Client : Form
    {
        private TcpClient client;

        public form_Client()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

        }

        private void form_Client_Load(object sender, EventArgs e)
        {

            var frmClientPort = new form_ClientConnect();
            frmClientPort.ShowDialog();
            if (frmClientPort.DialogResult != DialogResult.OK)
            {
                Application.Exit();
                return;
            }
            this.Show();
            Connect();
            txt_Port.Text = DataClient.ip;
           
        }
        private void Receive()
        {
            NetworkStream stream = client.GetStream();
            StreamReader sr = new StreamReader(stream);

            try
            {

                while (true)
                {
                    string str = sr.ReadLine();
                    if (str=="guidanhsachclient!!!")
                    {
                        string ds = sr.ReadLine();
                        LoadLVDanhSach(ds);
                    }
                    else
                    {
                        if (str != null)
                            AddMessage(str);
                    }
                   
                }

            }
            catch (Exception)
            {
                Close();
            }


        }

        private void LoadLVDanhSach(string str)
        {
            lv_DanhSach.Items.Clear();
            string[] ds = getListDSClient(str);
          
            foreach (var item in ds)
            {
                if (DataClient.ip!=item)
                {
                lv_DanhSach.Items.Add(new ListViewItem() { Text = item.ToString() });
                }
            }
        }

        private string[] getListDSClient(string str)
        {
           return str.Split(';');
        }

        private void AddMessage(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
              
                txt_KhungChat.AppendText(text +"\r\n");
                txt_TinNhan.Clear();
            }

        }

        private void Send()
        {
            if (!String.IsNullOrEmpty(txt_TinNhan.Text) && client != null)
            {
                NetworkStream stream = client.GetStream();
                StreamWriter sw = new StreamWriter(stream);
                string str = TextClient(txt_TinNhan.Text);
                sw.WriteLine(str);
                sw.Flush();

                AddMessage(str);
            }
        }
        private string TextClient(string text)
        {
            return DataClient.ip+":   "+ text;
        }
        private void Connect()
        {
            try
            {
                client = new TcpClient("127.0.0.1",int.Parse( DataClient.port));
                ReceiveIpRemote(client);
            }
            catch (Exception)
            {

                MessageBox.Show("Không kết nối được với server", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Thread listen = new Thread(Receive);
            listen.IsBackground = true;
            listen.Start();

        }

        private void ReceiveIpRemote(TcpClient client)
        {

            NetworkStream stream = client.GetStream();
            StreamReader sr = new StreamReader(stream);
            string str = sr.ReadLine();
            DataClient.ip = str;
        }

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            Send();
        }

        private void form_Client_FormClosed(object sender, FormClosedEventArgs e)
        {
            endClient();
           client.Close();
        }

        private void endClient()
        {
            try
            {
                NetworkStream stream = client.GetStream();
                StreamWriter sw = new StreamWriter(stream);
                string str = "endConnectClient";
                sw.WriteLine(str);
                sw.Flush();
                stream.Close();
            }
            catch (Exception)
            {
                client.Close();
                Application.Exit();
            }
          
        }
    }
}
