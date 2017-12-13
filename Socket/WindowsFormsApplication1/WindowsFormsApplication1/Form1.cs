using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;


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
            //初始化控件
            txtSendMssg.Text = "测试数据";

            //打开Listener开始监听
            Thread thrListener = new Thread(new ThreadStart(Listen));
            thrListener.Start();
        }
        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //强制关闭程序（强行终止Listener）
            Environment.Exit(0);
        }

        //发送数据
        private void btnSend_Click(object sender, EventArgs e)
        {
            TcpClient tcpClient = new TcpClient();
            //tcpClient.Connect(IPAddress.Parse("170.0.0.78"), 2014);
            tcpClient.Connect(IPAddress.Parse("192.168.32.1"),64404);

            NetworkStream ntwStream = tcpClient.GetStream();
            if (ntwStream.CanWrite)
            {
                Byte[] bytSend = Encoding.UTF8.GetBytes(txtSendMssg.Text);
                ntwStream.Write(bytSend, 0, bytSend.Length);
            }
            else
            {
                MessageBox.Show("无法写入数据流");

                ntwStream.Close();
                tcpClient.Close();

                return;
            }

            ntwStream.Close();
            tcpClient.Close();
        }

        //监听数据
        private void Listen()
        {
            Socket listener = new Socket(AddressFamily.InterNetwork,
                SocketType.Stream, ProtocolType.Tcp);
            listener.Bind(new IPEndPoint(IPAddress.Any,64404));

            //不断监听端口
            while (true)
            {
                listener.Listen(0);
                Socket socket = listener.Accept();
                NetworkStream ntwStream = new NetworkStream(socket);
                StreamReader strmReader = new StreamReader(ntwStream);
                Invoke(new PrintRecvMssgDelegate(PrintRecvMssg),
                    new object[] { strmReader.ReadToEnd() });
                socket.Close();
            }

            //程序的listener一直不关闭
            //listener.Close();
        }

        //线程内向文本框txtRecvMssg中添加字符串及委托
        private delegate void PrintRecvMssgDelegate(string s);
        private void PrintRecvMssg(string info)
        {
            txtRecvMssg.Text += string.Format("[{0}]:{1}\r\n",
                DateTime.Now.ToLongTimeString(), info);
        }
    }
}
