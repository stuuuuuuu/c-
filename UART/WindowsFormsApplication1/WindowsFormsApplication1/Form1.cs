using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        SerialPort sp = new SerialPort();
        bool isOpen = false;
        bool isSetProperty = false;
        bool isHex = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void cbSerial_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        //public bool SendData(byte[] data)
        //{
        //    if (sp.IsOpen)
        //    {
        //        try
        //        {
        //           sp.Write(data, 0, data.Length);//发送数据
        //            return true;
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show(ex.Message, "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("串口未打开", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //    return false;
        //}
        private void btn_Click(object sender, EventArgs e)
        {
           
            if (isOpen)//写串口数据
            {
                try
                {
                    sp.WriteLine(txtSend.Text);
                }
                catch (Exception)
                {
                    MessageBox.Show("发送数据时发生错误！", "错误提示");
                    return;
                }
            }
            else
            {
                MessageBox.Show("串口未打开！", "错误提示");
                return;
            }
            //byte[] sendData = null;
            //if (rbRcv16.Checked)
            //{
            //    sendData = strToHexByte(txtSend.Text.Trim());
            //}
            //else
            //{
            //    sendData = Encoding.ASCII.GetBytes(txtSend.Text.Trim());
            //}

        }
        //private byte[] strToHexByte(string hexString)
        //{
        //    hexString = hexString.Replace(" ", "");
        //    if ((hexString.Length % 2) != 0)
        //        hexString += " ";
        //    byte[] returnBytes = new byte[hexString.Length / 2];
        //    for (int i = 0; i < returnBytes.Length; i++)
        //        returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Replace(" ", ""), 16);
        //    return returnBytes;
        //}

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            this.MaximizeBox = false;
            for (int i = 0; i < 10; i++)
            {
                cbSerial.Items.Add("COM" + (i + 1).ToString());

            }
            cbSerial.Text = "COM1";
            cbSerial.SelectedIndex = 0;
            cbBaudRate.Items.Add("1200");
            cbBaudRate.Items.Add("2400");
            cbBaudRate.Items.Add("4800");
            cbBaudRate.Items.Add("9600");
            cbBaudRate.Items.Add("14400");
            cbBaudRate.Items.Add("19200");
            cbBaudRate.Items.Add("38400");
            cbBaudRate.Items.Add("56000");
            cbBaudRate.Items.Add("57600");
            cbBaudRate.Items.Add("115200");
            cbBaudRate.SelectedIndex = 3;
            for (int i = 8; i > 4; i--)
            {
                cbDataBits.Items.Add((i) .ToString());

            }
            cbDataBits.Text = "8";
            cbParity.Items.Add("None");
            cbParity.Items.Add("Odd");
            cbParity.Items.Add("Even");
            cbParity.Items.Add("Mark");
            cbParity.Items.Add("Space");
            cbParity.Text = "None";
            cbStop.Items.Add("1");
            cbStop.Items.Add("1.5");
            cbStop.Items.Add("2");
            cbStop.Text = "1";
            sp.ReadBufferSize = 1024;
            sp.WriteBufferSize = 1024;
            sp.ReceivedBytesThreshold = 2;
            sp.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);


        }

        private void cbParity_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbBaudRate_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbStop_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            sp.PortName = cbSerial.Text;
            sp.BaudRate = Convert.ToInt32(cbBaudRate.Text);
            sp.DataBits = Convert.ToInt32(cbDataBits.Text);

            if (cbStop.Text == "None")
            {
                sp.StopBits = StopBits.None;
            }
            else if (cbStop.Text == "1")
            {
                sp.StopBits = StopBits.One;
            }
            else if (cbStop.Text == "1.5")
            {
                sp.StopBits = StopBits.OnePointFive;
            }
            else if (cbStop.Text == "2")
            {
                sp.StopBits = StopBits.Two;
            }

            if (cbParity.Text == "None")
            {
                sp.Parity = Parity.None;
            }
            else if (cbParity.Text == "Odd")
            {
                sp.Parity = Parity.Odd;
            }
            else if (cbParity.Text == "Even")
            {
                sp.Parity = Parity.Even;
            }
            else if (cbParity.Text == "Mark")
            {
                sp.Parity = Parity.Mark;
            }
            else if (cbParity.Text == "Space")
            {
                sp.Parity = Parity.Space;
            }
            
            sp.Open();
            cbState.Text = "打开";
            isOpen = true;
            //txtRcv.Text = Convert.ToString( DateTime.Now);


        }
        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(100);//延时100ms等待接收完数据
            // this.Invoke就是跨线程访问ui的方法
            this.Invoke((EventHandler)(delegate
            {
                if (isHex == false)
                {
                    txtRcv.Text += sp.ReadLine();
                   
                }
                else
                {
                    Byte[] ReceivedData = new Byte[sp.BytesToRead];
                    sp.Read(ReceivedData, 0, ReceivedData.Length);
                    String RecvDataText = null;
                    for (int i = 0; i < ReceivedData.Length - 1; i++)
                    {
                        if(cbHbr.Checked == false)
                        RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + " ");
                        else RecvDataText += ("0x" + ReceivedData[i].ToString("X2") + "\r\n");
                    }
                    txtRcv.Text += RecvDataText;
                }
                sp.DiscardInBuffer();//丢弃接收缓冲区数据
            }));
        }


        private void rbRcv16_CheckedChanged(object sender, EventArgs e)
        {
            if(rbRcv16.Checked)
            {
                isHex = true;
            }
            else
            {
                isHex = false;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtRcv.Text = "";
            txtSend.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)   //串口扫描
        {
            
            bool comExistence = false;//有可用串口标志位
            cbSerial.Items.Clear();//清除当前串口号中的所有串口名称
            for (int i = 0; i < 10; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbSerial.Items.Add("COM" + (i + 1).ToString());
                    comExistence = true;

                }
                catch (Exception)
                {
                    continue;
                }
            }

            if (comExistence)
            {
                cbSerial.SelectedIndex = 0;//使ListBox显示第1个添加的索引
            }
            else
            {
                MessageBox.Show("没有找到可用串口！", "错误提示");
            }
        
     }
    }
}
