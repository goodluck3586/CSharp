using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

/* 네트워크 연결 클래스 */
namespace Network02_TcpListener
{
    class Program
    {
        static void Main(string[] args)
        {
            #region TcpListener(서버), TcpClient(서버&클라이언트)

            IPAddress ipAdd = IPAddress.Parse("127.0.0.1");             // 서버의 ip 주소
            TcpListener tcpListener = new TcpListener(ipAdd, 7);
            Console.WriteLine(tcpListener.LocalEndpoint.ToString());    // 127.0.0.1:7

            tcpListener.Start();                                  
            Console.WriteLine("클라이언트 연결 대기상태 시작");
            TcpClient tcpClient = tcpListener.AcceptTcpClient();  // 대기상태 시작 -> TcpClient 객체 생성

            NetworkStream ns = tcpClient.GetStream();   // 데이터 송수신 스트림

            // 클라이언트 메시지 수신
            byte[] receiveMsg = new byte[100];          // NetworkStream의 데이터는 byte 단위로 처리된다.
            ns.Read(receiveMsg, 0, 100);                // 클라이언트의 데이터 수신
            string strMsg = Encoding.ASCII.GetString(receiveMsg);   // byte[] → string
            Console.WriteLine($"클라이언트가 보낸 메시지: {strMsg}");

            // 클라이언트로 메시지 송신
            string echoMsg = "Hi Client~";
            byte[] sendMsg = Encoding.ASCII.GetBytes(echoMsg);  // string → byte[]
            ns.Write(sendMsg, 0, sendMsg.Length);               // 클라이언트로 데이터 송신
            ns.Close();

            tcpClient.Close();
            tcpListener.Stop();
            Console.WriteLine("연결 대기상태 종료");
            #endregion

            #region UdpClient(서버&클라이언트)

            #endregion
        }
    }
}
