using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Project
{
    public class DataContainer
    {
        public static Player player;
        public static Room room;
        static string Server_IP = "26.239.12.190"; // nhớ chỉnh lại IP

        public static string respone_msg = string.Empty;
        public static TcpClient tcpClient;
        static IPEndPoint ipEP;
        public static NetworkStream ns;
        public static Byte[] recv_data = new Byte[2048];
        public static int currentRound = 1;

        public static void connect()
        {
            try
            {
                tcpClient = new TcpClient();
                ipEP = new IPEndPoint(IPAddress.Parse(Server_IP), Int32.Parse("12000"));
                tcpClient.Connect(ipEP);
                ns = tcpClient.GetStream();
                MessageBox.Show("Kết nối thành công!");
                Thread listen = new Thread(receive);
                listen.IsBackground = true;
                listen.Start();
            }
            catch
            {
                MessageBox.Show("Không thể kết nối server (port chưa đúng hoặc server chưa được khởi động)!");
                Application.Restart();
            }
        }

        public static void flush()
        {
            respone_msg = String.Empty;
            ns.Flush();
        }
        public static void receive()
        {
            while (true)
            {
                //respone_msg = String.Empty;
                Int32 bytes = ns.Read(recv_data, 0, recv_data.Length);
                respone_msg = System.Text.Encoding.UTF8.GetString(recv_data, 0, bytes);
                //ns.Flush();

                //MessageBox.Show(respone_msg);
            }
        }
    }
}
