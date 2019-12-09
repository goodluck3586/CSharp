using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

/* 네트워크 정보 클래스: IPAddress, Dns, IPHostEntry, IPEndPoint */
namespace Network01_IPAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            #region IPAddress 클래스: ip 주소 ↔ long형 값 변환 
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            Console.WriteLine($"iPAddress.Address: {iPAddress.Address}");           // iPAddress.Address: 16777343
            Console.WriteLine($"iPAddress.ToString() : {iPAddress.ToString()}");    // iPAddress.ToString() : 127.0.0.1
            Console.WriteLine();
            #endregion

            #region Dns 클래스 테스트
            Console.WriteLine($"Dns.GetHostName(): {Dns.GetHostName()}");   // 로컬 컴퓨터의 호스트이름(LAPTOP-FN03UG3K)
            IPAddress[] ips = Dns.GetHostAddresses("www.naver.com");        // 해당 호스트이름의 IP 주소들
            foreach (IPAddress ip in ips)
            {
                Console.WriteLine($"Dns.GetHostAddresses(\"www.naver.com\"): {ip}");
            }
            Console.WriteLine();
            #endregion

            #region IPHostEntry :인터넷 호스트 주소 정보에 대한 컨테이너 클래스
            // www.naver.com
            IPHostEntry naverIPHostEntry = Dns.GetHostEntry("www.naver.com");
            foreach (IPAddress ip in naverIPHostEntry.AddressList)
            {
                Console.WriteLine($"iPHostEntry.AddressList: {ip}");    
            }
            Console.WriteLine($"iPHostEntry.HostName: {naverIPHostEntry.HostName}");
            Console.WriteLine();

            // myPC
            IPHostEntry myIPHostEntry = Dns.GetHostEntry(Dns.GetHostName());    // 로컬 컴퓨터의 호스트이름으로 IPHostEntry객체 얻기
            foreach (IPAddress ip in myIPHostEntry.AddressList)                 // IPv6, Ipv4주소 출력
            {
                Console.WriteLine($"myIPHostEntry.AddressList: {ip}");          // 0번은 IPv6, 1번은 IPv4
            }
            Console.WriteLine($"myIPHostEntry.HostName: {myIPHostEntry.HostName}");  // 호스트 이름(컴퓨터 이름)
            Console.WriteLine();
            #endregion

            #region IPEndPotin : 목적지 ip 주소와 포트번호 저장
            int port = 13;
            IPEndPoint iPEndPoint = new IPEndPoint(iPAddress, port);
            Console.WriteLine($"iPEndPoint.Address: {iPEndPoint.Address}");
            Console.WriteLine($"iPEndPoint.Port: {iPEndPoint.Port}");
            Console.WriteLine($"iPEndPoint.ToString(): {iPEndPoint.ToString()}");
            Console.WriteLine();
            #endregion
        }
    }
}
