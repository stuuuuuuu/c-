using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Crestron.SimplSharp;
using System.Net.Sockets;


namespace ILiveSmart
{
    public class UDPAPI
    {
        private static byte[] HexStrTobyte(string hexString)    //16进制转换
        {
            hexString = hexString.Replace(" ", "");
            if ((hexString.Length % 2) != 0)
                hexString += " ";
            byte[] returnBytes = new byte[hexString.Length / 2];
            for (int i = 0; i < returnBytes.Length; i++)
                returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2).Trim(), 16);
            return returnBytes;
        }
        public  void SendData(string data)
            
        {
            string host = "192.168.188.22";
            int port = 8007;
            UdpClient client = new UdpClient();
            byte[] sendBytes = Encoding.ASCII.GetBytes(data);
            client.Connect(host, port);
            client.Send(sendBytes,sendBytes.Length);
            client.Close();
        }
        public void SendData(string h, int p, string data)
        {
            string host = h;
            int port = p;
            byte[] sendBytes = HexStrTobyte(data);
            UdpClient client = new UdpClient();
            client.Connect(host, port);
            client.Send(sendBytes, sendBytes.Length);
            client.Close();

        }
    }
}
