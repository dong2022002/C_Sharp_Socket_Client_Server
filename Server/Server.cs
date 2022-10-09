
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class form_Server : Form
    {
        private List<TcpClient> clients;
        private TcpListener server;

        public form_Server()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
       
         
        }
    



        private void form_Server_Load(object sender, EventArgs e)
        {
          
            var frmServerPort =new form_ServerPort();
            frmServerPort.ShowDialog();
            if (frmServerPort.DialogResult != DialogResult.OK)
            {
                Application.Exit();
                return;
            }
            this.Show();
            txt_Port.Text = DataServer.port;
            Connect();
        }

        private string TextServer(string text)
        {
            return  "server:   " + text;
        }
        private void Connect()
        {
            clients = new List<TcpClient>();

            Thread listen = new Thread(() => {
                try
                {
                    server = new TcpListener(IPAddress.Any, int.Parse(DataServer.port));
                    server.Start();
                    while (true)
                    {

                        TcpClient client = server.AcceptTcpClient();
                        lv_DanhSach.Items.Add(new ListViewItem() { Text = client.Client.RemoteEndPoint.ToString() });
                        SendIPRemote(client);
                        clients.Add(client);
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                    }
                }
                catch
                {
                    //MessageBox.Show("Một client vừa đóng kết nối", "thông báo", MessageBoxButtons.OK);
                    if (clients == null)
                    {
                        server.Stop();
                        return;
                    }
                    else
                    {
                      
                        server = new TcpListener(IPAddress.Any, 9050);
                      
                    }

                }


            });
            listen.IsBackground = true;
            listen.Start();

        }

        private void SendIPRemote(TcpClient client)
        {
            NetworkStream stream = client.GetStream();
            StreamWriter sw = new StreamWriter(stream);
            string str = client.Client.RemoteEndPoint.ToString();
            sw.WriteLine(str);
            sw.Flush();
        }

        private void Receive(Object obj)
        {

            TcpClient client = obj as TcpClient;
            NetworkStream stream = client.GetStream();
            StreamReader sr = new StreamReader(stream);
            try
            {
                while (true)
                {
                    string str = sr.ReadLine();
                    if (str != null)
                        AddMessage(str);
                    foreach (TcpClient item in clients)
                    {
                        if (item != null && item != client)
                        {
                            stream = item.GetStream();
                            StreamWriter sw = new StreamWriter(stream);
                            string s = str;
                            sw.WriteLine(s);
                            sw.Flush();

                        }
                    }
                }

            }
            catch
            {

                clients.Remove(client);
                client.Close();
                stream.Close();

            }




        }
        private void AddMessage(string text)
        {
            lv_KhungChat.Items.Add(text);
        }
        private void Send(TcpClient client)
        {
            if (!string.IsNullOrEmpty(txt_TinNhan.Text))
            {
                NetworkStream stream = client.GetStream();
                StreamWriter sw = new StreamWriter(stream);
                string str = TextServer(txt_TinNhan.Text);
                sw.WriteLine(str);
                sw.Flush();

            }

        }

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            foreach (TcpClient item in this.clients)
            {
                Send(item);
            }
            AddMessage(TextServer(txt_TinNhan.Text));
            txt_TinNhan.Clear();

        }
    }
}
