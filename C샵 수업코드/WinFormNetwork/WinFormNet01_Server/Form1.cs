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
        BinaryWriter bw;
        BinaryReader br;

        int intValue;
        float floatValue;
        string strValue;

        private void Form1_Load(object sender, EventArgs e)
        {
            tcpListener = new TcpListener(3000);
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
            tcpClient = tcpListener.AcceptTcpClient();    // TcpClient 생성과 대기상태 유지, 정상적인 연결이 되었을 때 TcpClient가 생성됨.
            
            // 클라이언트와 연결되면 textBox2에 클라이언트의 IP 주소 표시
            if (tcpClient.Connected)
            {
                textBox2.Text = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
            }

            // 클라이언트와 데이터를 주고받을 수 있는 스트림생성
            ns = tcpClient.GetStream();
            bw = new BinaryWriter(ns);
            br = new BinaryReader(ns);
        }

        // 송수신 시작 버튼
        private void button2_Click(object sender, EventArgs e)
        {
            // 데이터 수신과 송신 상태 무한 반복
            while (true)
            {
                if (tcpClient.Connected)
                {
                    if (DataReceive() == -1)  // 수신된 데이터가 -1이면 반복 종료
                        break;
                    DataSend();
                }
                else
                {
                    AllClose();
                    break;
                }
            }
            AllClose();
        }

        // Read() 메소드들로 데이터 수신하고 MwssageBox로 출력하기
        int DataReceive()
        {
            intValue = br.ReadInt32();
            if (intValue == -1)
                return -1;

            floatValue = br.ReadSingle();
            strValue = br.ReadString();
            string str = $"클라리언트에서 보낸 데이터:\n{intValue}\n{floatValue}\n{strValue}\n";
            MessageBox.Show(str);
            return 0;
        }

        // 클라이언트로 데이터 보내기
        void DataSend()
        {
            bw.Write(intValue);
            bw.Write(floatValue);
            bw.Write(strValue);

            MessageBox.Show("서버에서 클라이언트로 데이터 전송함.");
        }

        // 모든 리소스 해제
        void AllClose()
        {
            if (bw != null)
            {
                bw.Close();
                bw = null;
            }
            if (br != null)
            {
                br.Close();
                br = null;
            }
            if (ns != null)
            {
                ns.Close();
                ns = null;
            }
            if (tcpClient != null)
            {
                tcpClient.Close();
                tcpClient = null;
            }

        }
    }
}
