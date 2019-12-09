using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNet01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpListener tcpListener;
        TcpClient tcpClient;
        NetworkStream ns;

        StreamWriter sw;
        StreamReader sr;
        string msg;

        private void Form1_Load(object sender, EventArgs e)
        {
            IPAddress iPAddress = IPAddress.Parse("127.0.0.1");
            tcpListener = new TcpListener(iPAddress, 3000);
            tcpListener.Start();

            #region 서버의 IP 주소를 textBox1에 표시
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());     // IPHostEntry :인터넷 호스트 주소 정보의 컨테이너 클래스
            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)    // IPv4 주소인 경우(0번은 IPv6)  
                {
                    textBox1.Text = host.AddressList[i].ToString();
                    break;
                }
            }
            #endregion

        }

        // 접속시작 버튼: 클라이언트 접속 대기
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxPrint.Text += "클라이언트 연결 대기중\n\r";
            tcpClient = tcpListener.AcceptTcpClient();    // TcpClient 생성과 대기상태 유지, 정상적인 연결이 되었을 때 TcpClient가 생성됨.
            
            // 클라이언트와 연결되면 textBox2에 클라이언트의 IP 주소 표시
            if (tcpClient.Connected)
            {
                textBoxPrint.Text += "클라이언트 연결 성공\n\r";
                textBox2.Text = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
                ns = tcpClient.GetStream();  // 클라이언트와 데이터를 주고받을 수 있는 스트림생성
                sw = new StreamWriter(ns);
                sr = new StreamReader(ns);
            }   
        }

        // 송수신 시작 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            // 데이터 수신과 송신 상태 무한 반복
            while (true)
            {
                if (tcpClient.Connected)
                {
                    if ((msg = sr.ReadLine()) != "")
                    {
                        if (msg == "exit")
                            break;
                        textBoxPrint.Text += $"{msg}\n";
                    }

                    //DataSend();
                }
                else
                {
                    AllClose();
                    break;
                }
            }
            AllClose();
        }

        // 클라이언트로 데이터 보내기
        void DataSend()
        {
            sw.WriteLine(msg);
        }

        // 모든 리소스 해제
        void AllClose()
        {
            sw.Close();
            sr.Close();
            ns.Close();
            tcpClient.Close();
        }
    }
}
