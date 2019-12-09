using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Network06_TcpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("서버");

            TcpListener tcpListener = new TcpListener(3000);  // port 번호
            tcpListener.Start();
            TcpClient tcpClient = tcpListener.AcceptTcpClient();    // 대기상태 시작 -> TcpClient 객체 생성
            Console.WriteLine($"클라이언트 연결{tcpClient.Client.RemoteEndPoint}");

            using (NetworkStream ns = tcpClient.GetStream())    // 데이터 송수신 스트림
            {
                using (StreamWriter sw = new StreamWriter(ns))
                {
                    sw.AutoFlush = true;            // sw.WriteLine() 실행후 버퍼 비우기
                    //sw.WriteLine("Hi");      // '\r\n'의 종결자가 추가되어 전송됨.
                    //sw.WriteLine("Client");

                    string str = "";
                    while ((str = Console.ReadLine()) != "exit")
                    {
                        sw.WriteLine(str);
                    }
                }
            }
            Console.WriteLine("서버 종료");
            tcpClient.Close();
            tcpListener.Stop();
        }
    }
}