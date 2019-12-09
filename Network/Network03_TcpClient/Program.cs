using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network03_TcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient tcpClient = new TcpClient("127.0.0.1", 7);
            if (tcpClient.Connected)
            {
                Console.WriteLine("서버 연결 성공");
                NetworkStream ns = tcpClient.GetStream();

                // 서버로 데이터 전송
                string msg = "Hello Server";
                byte[] sendByteMsg = Encoding.ASCII.GetBytes(msg);
                ns.Write(sendByteMsg, 0, sendByteMsg.Length);

                // 서버의 데이터 수신
                byte[] receiveByteMsg = new byte[100];
                ns.Read(receiveByteMsg, 0, 100);
                string receiveMsg = Encoding.ASCII.GetString(receiveByteMsg);
                Console.WriteLine($"서버가 보낸 메시지: {receiveMsg}");

                ns.Close();
            }
            else
            {
                Console.WriteLine("서버 연결 실패");
            }

            tcpClient.Close();
        }
    }
}
