﻿using System;
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
            IPAddress[] ips = Dns.GetHostAddresses("");
            tbxlocalip.Text = ips[3].ToString();
            int port = 51883;
            tbxlocalPort.Text = port.ToString();
            tbxSendtoIp.Text = ips[3].ToString();
            tbxSendtoport.Text = port.ToString();
        }
        private UdpClient sendUdpClient;
        private UdpClient receiveUpdClient;
     

        // 接受消息  
        private void btnReceive_Click(object sender, EventArgs e)
        {
            // 创建接收套接字  
            IPAddress localIp = IPAddress.Parse(tbxlocalip.Text);
            IPEndPoint localIpEndPoint = new IPEndPoint(localIp, int.Parse(tbxlocalPort.Text));
            receiveUpdClient = new UdpClient(localIpEndPoint);


            Thread receiveThread = new Thread(ReceiveMessage);
            receiveThread.Start();
        }

        // 接收消息方法  
        private void ReceiveMessage()
        {
            IPEndPoint remoteIpEndPoint = new IPEndPoint(IPAddress.Any, 0);
            while (true)
            {
                try
                {
                    // 关闭receiveUdpClient时此时会产生异常  
                    byte[] receiveBytes = receiveUpdClient.Receive(ref remoteIpEndPoint);

                    string message = Encoding.Unicode.GetString(receiveBytes);

                    // 显示消息内容  
                    ShowMessageforView(listView1, string.Format("{0}[{1}]", remoteIpEndPoint, message));
                }
                catch
                {
                    break;
                }
            }
        }

        // 利用委托回调机制实现界面上消息内容显示  
        delegate void ShowMessageforViewCallBack(ListBox listbox, string text);
        private void ShowMessageforView(ListBox listbox, string text)
        {
            if (listbox.InvokeRequired)
            {
                ShowMessageforViewCallBack showMessageforViewCallback = ShowMessageforView;
                listbox.Invoke(showMessageforViewCallback, new object[] { listbox, text });
            }
            else
            {
                listView1.Items.Add(text);
                listView1.SelectedIndex = listView1.Items.Count - 1;
                listView1.ClearSelected();
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbxMessageSend.Text == string.Empty)
            {
                MessageBox.Show("发送内容不能为空", "提示");
                return;
            }

            // 选择发送模式  
            if (chkbxAnonymous.Checked == true)
            {
                // 匿名模式(套接字绑定的端口由系统随机分配)  
                sendUdpClient = new UdpClient(0);
            }
            else
            {
                // 实名模式(套接字绑定到本地指定的端口)  
                IPAddress localIp = IPAddress.Parse(tbxlocalip.Text);
                IPEndPoint localIpEndPoint = new IPEndPoint(localIp, int.Parse(tbxlocalPort.Text));
                sendUdpClient = new UdpClient(localIpEndPoint);
            }

            Thread sendThread = new Thread(SendMessage);
            sendThread.Start(tbxMessageSend.Text);
        }

        // 发送消息方法  
        private void SendMessage(object obj)
        {
            string message = (string)obj;
            byte[] sendbytes = Encoding.Unicode.GetBytes(message);
            IPAddress remoteIp = IPAddress.Parse(tbxSendtoIp.Text);
            IPEndPoint remoteIpEndPoint = new IPEndPoint(remoteIp, int.Parse(tbxSendtoport.Text));
            sendUdpClient.Send(sendbytes, sendbytes.Length, remoteIpEndPoint);

            sendUdpClient.Close();

            // 清空发送消息框  
            ResetMessageText(tbxMessageSend);
        }

        // 采用了回调机制  
        // 使用委托实现跨线程界面的操作方式  
        delegate void ResetMessageCallback(TextBox textbox);
        private void ResetMessageText(TextBox textbox)
        {
            // Control.InvokeRequired属性代表  
            // 如果控件的处理与调用线程在不同线程上创建的，则为true,否则为false  
            if (textbox.InvokeRequired)
            {
                ResetMessageCallback resetMessagecallback = ResetMessageText;
                textbox.Invoke(resetMessagecallback, new object[] { textbox });
            }
            else
            {
                textbox.Clear();
                textbox.Focus();
            }
        }

        // 停止接收  
        private void btnStop_Click(object sender, EventArgs e)
        {
            receiveUpdClient.Close();
        }

        // 清空接受消息框  
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
        }

        private void btnSend_Click_1(object sender, EventArgs e)
        {
            if (tbxMessageSend.Text == string.Empty)
            {
                MessageBox.Show("发送内容不能为空", "提示");
                return;
            }

            // 选择发送模式  
            if (chkbxAnonymous.Checked == true)
            {
                // 匿名模式(套接字绑定的端口由系统随机分配)  
                sendUdpClient = new UdpClient(0);
            }
            else
            {
                // 实名模式(套接字绑定到本地指定的端口)  
                IPAddress localIp = IPAddress.Parse(tbxlocalip.Text);
                IPEndPoint localIpEndPoint = new IPEndPoint(localIp, int.Parse(tbxlocalPort.Text));
                sendUdpClient = new UdpClient(localIpEndPoint);
            }

            Thread sendThread = new Thread(SendMessage);
            sendThread.Start(tbxMessageSend.Text);
        }

        private void btnReceive_Click_1(object sender, EventArgs e)
        {
            IPAddress localIp = IPAddress.Parse(tbxlocalip.Text);
            IPEndPoint localIpEndPoint = new IPEndPoint(localIp, int.Parse(tbxlocalPort.Text));
            receiveUpdClient = new UdpClient(localIpEndPoint);


            Thread receiveThread = new Thread(ReceiveMessage);
            receiveThread.Start();
        }
    }
}
