using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network05_TcpClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("클라이언트");

            TcpClient tcpClient = new TcpClient("localhost", 7);
            NetworkStream ns = tcpClient.GetStream();
            
            byte[] buffer = new byte[1024];
            byte[] sendMsg = Encoding.ASCII.GetBytes("Hello Server");
            ns.Write(sendMsg, 0, sendMsg.Length);   // 서버로 데이터 전송
            int totalCount = 0, readCount = 0;

            // 수신된 데이터가 서버로 보낸 데이터 바이트가 될 때까지 반복
            while (totalCount < sendMsg.Length)
            {
                readCount = ns.Read(buffer, 0, buffer.Length);
                totalCount += readCount;

                string receiveMsg = Encoding.ASCII.GetString(buffer);
                Console.WriteLine($"수신 메시지: {receiveMsg}");
            }

            Console.WriteLine($"받은 문자열 바이트 수 : {totalCount}");
            ns.Close();
            tcpClient.Close();
        }
    }
}
