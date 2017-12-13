using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SerialPort comn = new SerialPort();
        private StringBuilder builder = new StringBuilder();//避免在事件处理方法中反复创建，定义到外面  
        private long received_count = 0;//接收计数  
        private long send_count = 0;//发送计数  
        private bool Listening = false;//是否没有执行完invoke相关操作  
        private bool PortClosing = false;


        private void Form1_Load(object sender, EventArgs e)
        {
            String[] ports = SerialPort.GetPortNames();
            Array.Sort(ports);
            cbSerial.Items.AddRange(ports);
            cbSerial.SelectedIndex = cbSerial.Items.Count > 0 ? 0 : -1;
            cbBaudRate.SelectedIndex = cbBaudRate.Items.IndexOf("9600");
            //初始化serialPort对象  
            comn.NewLine = "/r/n";
            comn.RtsEnable = true;//根据实际情况决定  
            //添加事件注册  
            comn.DataReceived += comn_DataReceived;

        }
        void comn_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (PortClosing)
                return;//如果正常关闭，忽略操作，直接返回  
            try
            {
                Listening = true;//设置标记，说明我已经开始处理数据，一会儿要使用系统的UI  
                int n = comn.BytesToRead;//先记录下来，避免某种原因，认为的原因，操作几次之间时间长短，缓存不一致  
                byte[] buf = new byte[n];//声明一个临时数组存储当前的串口数据  
                received_count += n;//增加接收计数  
                comn.Read(buf, 0, n);//读取缓冲数据  
                builder.Clear();//清除字符串构造器的内容  
                //因为要访问UI资源，所以需要使用invoke方式同步UI  
                this.Invoke((EventHandler)(delegate
                {
                    //判断是否显示为16禁止  
                    if (checkBox1.Checked)
                    {
                        //依次拼接出16进制字符串  
                        foreach (byte b in buf)
                        {
                            builder.Append(b.ToString("X2") + "");
                        }
                    }
                    else
                    {
                        //直接按ASCII规则转换成字符串  
                        builder.Append(Encoding.ASCII.GetString(buf));
                    }
                    //追加的形式添加到文本框尾端，并滚动到最后  
                    this.txtRcv.AppendText(builder.ToString());
                    //修改接收计数  
                    label2.Text = "Get:" + received_count.ToString();
                }
                ));
            }
            finally
            {
                Listening = false;//我用完了，UI可以关闭串口了  
            }
        }
        private void checkBoxNewlineGet_CheckedChanged(object sender, EventArgs e)
        {
            txtRcv.WordWrap = checkBox2.Checked;
        }
        //  
        private void ButtonSend_Click(object sender, EventArgs e)
        {
            //定义一个变量，记录发送了几个字节  
            int n = 0;
            //16进制发送  
            if (checkBox4.Checked)
            {
                //我们不管规则了。如果写错了一些，我们是允许的，只用正则得到的有效地十六进制数  
                MatchCollection mc = Regex.Matches(txtSend.Text, @"(?i[/da-f])");
                List<byte> buf = new List<byte>();//填充到这个临时列表中  
                //依次添加到列表中  
                foreach (Match m in mc)
                {
                    buf.Add(byte.Parse(m.Value));
                }
                //转换列表为数组后发送  
                comn.Write(buf.ToArray(), 0, buf.Count);
                //记录发送的字节数  
                n = buf.Count;
            }
            else
            {
                //包含换行符  
                if (checkBox3.Checked)
                {
                    comn.WriteLine(txtSend.Text);
                    n = txtSend.Text.Length + 2;
                }
                else
                {
                    comn.Write(txtSend.Text);
                    n = txtSend.Text.Length;
                }
            }
            send_count += n;//累加发送字节数  
            label4.Text = "Send:" + send_count.ToString();//更新界面  
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
