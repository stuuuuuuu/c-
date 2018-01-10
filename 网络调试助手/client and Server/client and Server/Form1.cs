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

namespace client_and_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tcpStatus.Items.Add("TCP Server");
            tcpStatus.Items.Add("TCP Client");
            tcpStatus.SelectedIndex = 0;
            Control.CheckForIllegalCrossThreadCalls = false;

        }

        private void tcpStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tcpStatus.SelectedIndex == 1)
            {
                btnConnet.Text = "链接";
            } else
            {
                btnConnet.Text = "开始监听";
            }

        }


        bool bStatus = false;
        private void btnConnet_Click(object sender, EventArgs e)
        {
            bStatus = !bStatus;               
            if (tcpStatus.SelectedIndex == 0)
                {
                    try
                    {
                        IPAddress ip = IPAddress.Parse(tbIP.Text);
                        IPEndPoint point = new IPEndPoint(ip, int.Parse(tbPort.Text));
                        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
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
                else
                {
                    try
                    {
                    //连接到服务器
                        IPAddress ip = IPAddress.Parse(tbIP.Text);
                        IPEndPoint point = new IPEndPoint(ip, int.Parse(tbPort.Text));
                        Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        client.Connect(point);
                        ShowMsg("连接成功");
                        ShowMsg("服务器" + client.RemoteEndPoint.ToString());
                        //连接成功后，就可以接收服务器发送的信息了
                        Thread th = new Thread(ReceiveMsg);
                        th.IsBackground = true;
                        th.Start();

                    }

                    catch (Exception ex)

                    {

                        ShowMsg(ex.Message);

                    }
                }
            
        
          
        }
        Dictionary<string, Socket> dic = new Dictionary<string, Socket>();
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
                    cbIpPort.Items.Add(point);
                    dic.Add(point, tSocket);
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
        void ReceiveMsg(object o)
        {
            if (tcpStatus.SelectedIndex == 0)
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
                        ShowMsg( words);
                    }
                    catch (Exception ex)
                    {
                        ShowMsg(ex.Message);
                        break;
                    }
                }
            }else
            {
                while (true)

                {

                    try

                    {

                        byte[] buffer = new byte[1024 * 1024];

                        int n = client.Receive(buffer);

                        string s = Encoding.UTF8.GetString(buffer, 0, n);

                        ShowMsg(client.RemoteEndPoint.ToString() + ":" + s);

                    }

                    catch (Exception ex)

                    {

                        ShowMsg(ex.Message);

                        break;

                    }

                }

            }
        }
        void ShowMsg(string msg)
        {
            txtRecMsg.AppendText(msg + "\r\n");
        }
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //主窗体关闭时关闭子线程
        }
        Socket client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");//ToString("X2") 为C#中的字符串格式控制符
                }
            }
            return returnStr;
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tcpStatus.SelectedIndex == 0)
            {
                try
                {
                    ShowMsg(txtRecMsg.Text);
                    string ip = cbIpPort.Text;
                 
                    byte[] buffer = Encoding.UTF8.GetBytes(txtSendMsg.Text);
                    for(int i=0;i<buffer.Length;i++)
                    {
                        txtSendMsg.Text += buffer[i].ToString("X2");
                    }
                
                    dic[ip].Send( buffer );
                    // client.Send(buffer);
                }
                catch (Exception ex)
                {
                    ShowMsg(ex.Message);
                }
            }
            else
            {
                if (client != null)

                {

                    try

                    {

                        ShowMsg(txtRecMsg.Text);

                        byte[] buffer = Encoding.UTF8.GetBytes(txtSendMsg.Text);

                        client.Send(buffer);

                    }
                    catch (Exception ex)

                    {

                        ShowMsg(ex.Message);

                    }
                }
            }
        }
    }
}
