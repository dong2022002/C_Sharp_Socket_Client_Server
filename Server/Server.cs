
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
            Connect();
            txt_Port.Text = DataServer.portServer;
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
                    server = new TcpListener(IPAddress.Any, int.Parse(DataServer.portServer));
                    server.Start();
                    while (true)
                    {

                        TcpClient client = server.AcceptTcpClient();
                        /// gửi port kết nối về client
                        SendIPRemote(client);
                        ReceiveMessUser(client);
                        clients.Add(client);
                        /// gửi danh sách client kết nối 
                        ///
                        Thread receive = new Thread(Receive);
                        receive.IsBackground = true;
                        receive.Start(client);
                        SendListClient(client);
                        loadLVDanhSach();

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

                    server = new TcpListener(IPAddress.Any, 9050);
                      
                    
                    loadLVDanhSach();


                }


            });
            listen.IsBackground = true;
            listen.Start();

        }

        private void ReceiveMessUser(TcpClient client)
        {

            NetworkStream stream = client.GetStream();
            StreamReader sr = new StreamReader(stream);
            string user = sr.ReadLine();
            DataServer.listUser.Add(new User(client.Client.RemoteEndPoint.ToString(),user));
        }

        private void SendListClient(TcpClient client)
        {
            if (chuoiDanhSachClient() != "")
            {
                foreach (var item in clients)
                {
                    Send(item, "guidanhsachclient!!!");
                    Send(item, chuoiDanhSachClient());
                }
            }
        }

        private void loadLVDanhSach()
        {          
           lv_DanhSach.Items.Clear();
            foreach (User item in DataServer.listUser)
            {
                lv_DanhSach.Items.Add(new ListViewItem() { Text= item.Name + " - ("+item.port+")" });               
            }
            lbl_SoLuong.Text = clients.Count.ToString();
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
            try
            {
                
                StreamReader sr = new StreamReader(stream);
                while (true)
                {
                    string str = sr.ReadLine();
                    if (str == "endConnectClient")
                    {
                        AddMessage("Client "+client.Client.RemoteEndPoint.ToString()+" vừa đóng kết nối");
                        EndClient(client);
                        return;
                    }
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
            
            }




        }

        private void EndClient(TcpClient client)
        {
            User del = new User();
            foreach (User item in DataServer.listUser)
            {
                if (item.port == client.Client.RemoteEndPoint.ToString())
                {
                    del = item;
                    break;
                }
            }
            clients.Remove(client);
            if (del != null)
            {
                DataServer.listUser.Remove(del);
            }
            client.Close();
            loadLVDanhSach();
            SendListClient(client);
        }

        private void AddMessage(string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                this.txt_KhungChat.Invoke(new MethodInvoker(delegate ()
                {
                    txt_KhungChat.AppendText(text + "\r\n");
                }));
                //lv_KhungChat.Items.Add(text);
            }
        }
        private void Send(TcpClient client,string s)
        {
            if (!string.IsNullOrEmpty(s))
            {
                NetworkStream stream = client.GetStream();
                StreamWriter sw = new StreamWriter(stream);
                string str = s;
                sw.WriteLine(str);
                sw.Flush();

            }

        }

        private void btn_Gui_Click(object sender, EventArgs e)
        {
            foreach (TcpClient item in this.clients)
            {
                Send(item,TextServer(txt_TinNhan.Text));
            }
            AddMessage(TextServer(txt_TinNhan.Text));
            txt_TinNhan.Clear();

        }
        private string chuoiDanhSachClient()
        {
            string str = "server;";
            foreach (var item in DataServer.listUser)
            {
                str += item.Name +" - ("+item.port+ ");";
            }
            return str;
        }

        private void lv_DanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
