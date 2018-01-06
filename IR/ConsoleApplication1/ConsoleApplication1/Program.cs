using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ckas;
using System.Net.Sockets;
namespace ConsoleApplication1
{
    class Program
    {
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
        public static void SendData(string data)
        {
            string host = "192.168.188.112";
            int port = 8080;
            UdpClient client = new UdpClient();
            byte[] sendBytes = HexStrTobyte(data);
            client.Connect(host, port);
            client.Send(sendBytes, sendBytes.Length);
            client.Close();
        }
        static void Main(string[] args)
        {
            SendData("010203");
           Class1  ea = new  Class1();
           ea.Clas();
           Console.ReadLine();


        }
    }
}
