using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network04_TcpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("서버");

            TcpListener tcpListener = new TcpListener(IPAddress.Any, 7);
            tcpListener.Start();
            byte[] buffer = new byte[1024];
            int totalByteCount = 0, readByteCount = 0;

            Console.WriteLine("연결 대기상태 시작");
            TcpClient tcpClient = tcpListener.AcceptTcpClient();  // 대기상태 시작
            NetworkStream ns = tcpClient.GetStream();

            while (true)
            {
                readByteCount = ns.Read(buffer, 0, buffer.Length);
                if (readByteCount == 0)
                    break;

                totalByteCount += readByteCount;
                ns.Write(buffer, 0, readByteCount);
                string receiveMsg = Encoding.ASCII.GetString(buffer);
                Console.WriteLine($"수신 메시지: {receiveMsg}");
            }

            ns.Close();
        }
    }
}
