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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNet03_Server
{
    public partial class Form1 : Form
    {
        TcpListener tcpListener = null;
        // private delegate void SafeCallDelegate(string text); 

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(3000);    // port 번호
            tcpListener.Start();
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());  // ip 주소를 가진 객체 생성

            // 현재 서버의 ip 주소를 textBox1에 띄운다.
            for (int i = 0; i < host.AddressList.Length; i++)
            {
                if (host.AddressList[i].AddressFamily == AddressFamily.InterNetwork)    // IPv4 라면
                {
                    textBox1.Text = host.AddressList[i].ToString();
                    break;
                } 
            }
        }

        // 서버 시작 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            Thread th = new Thread(AcceptClient);
            th.IsBackground = true;
            th.Start();
            //AddTextSafelyToListBox("클라이언트 IP 주소 리스트");    // 컨트롤을 가진 스레드에서는 언제나 접근 가능
        }

        // 클라이언트
        private void AcceptClient()
        {
            while (true)
            {
                TcpClient tcpClient = tcpListener.AcceptTcpClient();

                if (tcpClient.Connected)        // 연결되면 클라이언트의 ip주소를 listBox에 추가
                {
                    string clientIP = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
                    //listBox1.Items.Add(clientIP);         // 다른 스레드에서 컨트롤에 직접 접근하기 때문에 안전하지 않음. -> Error 발생
                    AddTextSafelyToListBox(clientIP);       // 다른 스레드에서 안전하게 컨트롤에 접근하여 작업을 처리하도록하는 메소드
                }

                EchoServer echoServer = new EchoServer(tcpClient);
                Thread th = new Thread(echoServer.Process);
                th.IsBackground = true;     // Main Thread가 종료되면 같이 종료
                th.Start();
            }
        }

        void AddTextSafelyToListBox(string clientIP)
        {
            if (listBox1.InvokeRequired)    // 컨트롤이 만들어진 스레드가 아닌 스레드에서 컨트롤을 호출하는 경우
            {
                Action<string> addTextToListBoxFunc = (str) => listBox1.Items.Add(str);
                listBox1.Invoke(addTextToListBoxFunc, new object[] { clientIP });   // 컨트롤 핸들이 있는 스레드에서 지정된 대리자를 실행한다.
            }
            else
            {
                listBox1.Items.Add(clientIP);
            }         
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (tcpListener != null)
            {
                tcpListener.Stop();
                tcpListener = null;
            }
        }
    }

    internal class EchoServer
    {
        TcpClient client;
        BinaryReader br;
        BinaryWriter bw;
        int intValue;
        float floatValue;
        string strValue;

        // 생성자
        public EchoServer(TcpClient client)
        {
            this.client = client;
        }

        internal void Process()
        {
            NetworkStream ns = client.GetStream();
            try
            {
                br = new BinaryReader(ns);
                bw = new BinaryWriter(ns);

                while (true)
                {
                    intValue = br.ReadInt32();
                    floatValue = br.ReadSingle();
                    strValue = br.ReadString();

                    bw.Write(intValue);
                    bw.Write(floatValue);
                    bw.Write(strValue);
                }
            }
            catch (Exception ex)
            {
                br.Close();
                bw.Close();
                ns.Close();
                client.Close();
                MessageBox.Show(ex.Message);
                Thread.CurrentThread.Abort();   // 현재 스레드 중지
            }
        }
    }
}
