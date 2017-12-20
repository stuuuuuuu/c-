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
        IPEndPoint mbpoint;
        private bool RunningFlag = false;
        bool ReHex ;


        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
        // 16进制字符串转字节数组
        private static byte[] HexStrTobyte(string hexString)
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);
            return returnBytes;
        }
        // 字节数组转16进制字符串   
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
        public static string Encode(string strEncode)
        {
            string strReturn = "";//  存储转换后的编码
            foreach (short shortx in strEncode.ToCharArray())
            {
                strReturn += shortx.ToString("X2")+" ";
            }
            return strReturn;
        }
       

        private void Send_Click(object sender, EventArgs e)
        {

            string msg;            
            msg =txtSendMsg.Text;
            if (SpHex == true)
            {
                msg = Encode(msg);
            }
            byte[] data = Encoding.Default.GetBytes(msg);
            mySocket.SendTo(data, data.Length, SocketFlags.None, RemotePoint);
         
        }

  
        private void Link_Click(object sender, EventArgs e)
        {
            mySocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            IPAddress ip = IPAddress.Parse(tbIP.Text);
            IPEndPoint point = new IPEndPoint(ip, int.Parse(tbPort.Text));
    

            //定义网络类型，数据连接类型和网络协议UDP  
           

            //绑定网络地址  
            mySocket.Bind(point);

            //得到客户机IP  
            IPAddress mbip = IPAddress.Parse(mbIP.Text);
            mbpoint = new IPEndPoint(ip, int.Parse(mbPort.Text));
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
                if (ReHex == true)
                {
                    msg = Encode(msg);
                }
              
                txtRecMsg.BeginInvoke(myI, new object[] { RemotePoint.ToString() + " : " + msg });

            }
        }
        private void UpdateMsgTextBox(string msg)
        {
            //接收数据显示  
            this.txtRecMsg.AppendText(msg + "\n");
        }
        bool SpHex;
        private void isHex_CheckedChanged(object sender, EventArgs e)
        {

            if (isHex.Checked == true)
            {
                SpHex = true;
                //txtSendMsg.Text = Encode(txtSendMsg.Text);
            }
            else SpHex = false;
          
        }

        private void txtRecMsg_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tbHex_CheckedChanged(object sender, EventArgs e)
        {
            if (tbHex.Checked == true)
            {
                ReHex = true;

            }
            else ReHex = false;
        }
    }
}
