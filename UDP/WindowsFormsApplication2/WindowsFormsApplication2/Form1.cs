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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private EndPoint RemotePoint;
        private Socket mySocket;
        private bool RunningFlag = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void Send_Click(object sender, EventArgs e)
        {
          
            string msg;
            msg = txtSendMsg.Text;
            //发送UDP数据包  
            byte[] data = Encoding.UTF8.GetBytes(msg);
            mySocket.SendTo(data, data.Length, SocketFlags.None, RemotePoint);
        }
        private void SendMsg(object obj)
        {
         
            string msg;
            msg = txtSendMsg.Text;
            //发送UDP数据包  
            byte[] data = Encoding.UTF8.GetBytes(msg);
            mySocket.SendTo(data, data.Length, SocketFlags.None, RemotePoint);

        }

        private void Link_Click(object sender, EventArgs e)
        {
            IPAddress ip = IPAddress.Parse(tbIP.Text);
            IPEndPoint point = new IPEndPoint(ip, int.Parse(tbPort.Text));
        

            //定义网络类型，数据连接类型和网络协议UDP  
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);

            //绑定网络地址  
            mySocket.Bind(point);

            //得到客户机IP  
            IPAddress mbip = IPAddress.Parse(mbIP.Text);
            IPEndPoint mbpoint = new IPEndPoint(ip, int.Parse(mbPort.Text));
            RemotePoint = (EndPoint)(mbpoint);

            //启动一个新的线程，执行方法this.ReceiveHandle，  
            //以便在一个独立的进程中执行数据接收的操作  

            RunningFlag = true;
            Thread thread = new Thread(new ThreadStart(this.ReceiveHandle));
            thread.Start();
        }
        public delegate void MyInvoke(string strRecv);
        private void ReceiveHandle()
        {
            //接收数据处理线程  
            string msg;
            byte[] data = new byte[1024];
            MyInvoke myI = new MyInvoke(UpdateMsgTextBox);
            while (RunningFlag)
            {

                if (mySocket == null || mySocket.Available < 1)
                {
                    Thread.Sleep(200);
                    continue;
                }
                //跨线程调用控件  
                //接收UDP数据报，引用参数RemotePoint获得源地址  
                int rlen = mySocket.ReceiveFrom(data, ref RemotePoint);
                msg = Encoding.Default.GetString(data, 0, rlen);
                txtRecMsg.BeginInvoke(myI, new object[] { RemotePoint.ToString() + " : " + msg });

            }
        }
        private void UpdateMsgTextBox(string msg)
        {
            //接收数据显示  
            this.txtRecMsg.AppendText(msg + "\n");
        }
    }
}
