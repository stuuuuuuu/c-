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

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void btnServerConn_Click(object sender, EventArgs e)
        {

            IPAddress ip = IPAddress.Parse(txtIP.Text);
            // IPAddress ip = IPAddress.Any;
            //端口号
            IPEndPoint point = new IPEndPoint(ip, int.Parse(txtPORT.Text));
            //创建监听用的Socket
            /*
             * AddressFamily.InterNetWork：使用 IP4地址。
SocketType.Stream：支持可靠、双向、基于连接的字节流，而不重复数据。此类型的 Socket 与单个对方主机进行通信，并且在通信开始之前需要远程主机连接。Stream 使用传输控制协议 (Tcp) ProtocolType 和 InterNetworkAddressFamily。
ProtocolType.Tcp：使用传输控制协议。
             */
            //使用IPv4地址，流式socket方式，tcp协议传递数据
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //创建好socket后，必须告诉socket绑定的IP地址和端口号。
            //让socket监听point
            try
            {
                //socket监听哪个端口
                socket.Bind(point);
                //同一个时间点过来10个客户端，排队
                socket.Listen(10);
                ShowMsg("服务器开始监听");
                Thread thread = new Thread(AcceptInfo);
                thread.IsBackground = true;
                thread.Start(socket);
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }


        }
        Dictionary<string, Socket> dic = new Dictionary<string, Socket>();
        // private Socket client;
        void AcceptInfo(object o)
        {
            Socket socket = o as Socket;
            while (true)
            {
                //通信用socket
                try
                {
                    //创建通信用的Socket
                    Socket tSocket = socket.Accept();
                    string point = tSocket.RemoteEndPoint.ToString();
                    //IPEndPoint endPoint = (IPEndPoint)client.RemoteEndPoint;
                    //string me = Dns.GetHostName();//得到本机名称
                    //MessageBox.Show(me);
                    ShowMsg(point + "连接成功！");
                    //cboIpPort.Items.Add(point);
                    //dic.Add(point, tSocket);
                    //接收消息
                    Thread th = new Thread(ReceiveMsg);
                    th.IsBackground = true;
                    th.Start(tSocket);
                }
                catch (Exception ex)
                {
                    ShowMsg(ex.Message);
                    break;
                }
            }
        }
        //接收消息
        void ReceiveMsg(object o)
        {
            Socket client = o as Socket;
            while (true)
            {
                //接收客户端发送过来的数据
                try
                {
                    //定义byte数组存放从客户端接收过来的数据
                    byte[] buffer = new byte[1024 * 1024];
                    //将接收过来的数据放到buffer中，并返回实际接受数据的长度
                    int n = client.Receive(buffer);
                    //将字节转换成字符串
                    string words = Encoding.UTF8.GetString(buffer, 0, n);
                    ShowMsg(client.RemoteEndPoint.ToString() + ":" + words);
                }
                catch (Exception ex)
                {
                    ShowMsg(ex.Message);
                    break;
                }
            }
        }
        void ShowMsg(string msg)
        {
            txtMsg.AppendText(msg + "\r\n");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //主窗体关闭时关闭子线程
        }
        //给客户端发送消息


        private void btnSend_Click_1(object sender, EventArgs e)
        {
            try
            {
                ShowMsg(txtMsg.Text);
                string ip = cboIpPort.Text;
                byte[] buffer = Encoding.UTF8.GetBytes(txtSendMsg.Text);
                dic[ip].Send(buffer);
                // client.Send(buffer);
            }
            catch (Exception ex)
            {
                ShowMsg(ex.Message);
            }

        }


        //客户端
        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        private void btnConnection_Click(object sender, EventArgs e)
        {
            //连接到的目标IP

            IPAddress ip = IPAddress.Parse(textip.Text);

            //IPAddress ip = IPAddress.Any;

            //连接到目标IP的哪个应用(端口号！)

            IPEndPoint point = new IPEndPoint(ip, int.Parse(textBox2.Text));

            try

            {

                //连接到服务器

                client.Connect(point);

                ShowMsg1("连接成功");

                ShowMsg1("服务器" + client.RemoteEndPoint.ToString());

                ShowMsg1("客户端:" + client.LocalEndPoint.ToString());

                //连接成功后，就可以接收服务器发送的信息了

                Thread th = new Thread(ReceiveMsg1);

                th.IsBackground = true;

                th.Start();

            }

            catch (Exception ex)

            {

                ShowMsg1(ex.Message);

            }

        }
        void ReceiveMsg1()

        {

            while (true)

            {

                try

                {

                    byte[] buffer = new byte[1024 * 1024];

                    int n = client.Receive(buffer);

                    string s = Encoding.UTF8.GetString(buffer, 0, n);

                    ShowMsg1(client.RemoteEndPoint.ToString() + ":" + s);

                }

                catch (Exception ex)

                {

                    ShowMsg1(ex.Message);

                    break;

                }

            }



        }

        void ShowMsg1(string msg)

        {

            txtInfo.AppendText(msg + "\r\n");

        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (client != null)

            {

                try

                {

                    ShowMsg1(txtInfo.Text);

                    byte[] buffer = Encoding.UTF8.GetBytes(textBox4.Text);

                    client.Send(buffer);

                }

                catch (Exception ex)

                {

                    ShowMsg1(ex.Message);

                }
            }
        }
    }
}

