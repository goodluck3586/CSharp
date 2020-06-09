using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormNet02_Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        TcpClient tcpClient = null;
        NetworkStream ns;
        BinaryReader br;
        BinaryWriter bw;

        int intValue;
        float floatValue;
        string strValue;

        // 접속 버튼 클릭
        private void button1_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient(textBox1.Text, 3000);

            if (tcpClient.Connected)
            {
                ns = tcpClient.GetStream();     // 서버와 연결 스트림 생성
                br = new BinaryReader(ns);
                bw = new BinaryWriter(ns);
                labelConnection.Text = "서버 접속 성공";
                labelConnection.ForeColor = Color.Green;
            }
            else
            {
                labelConnection.Text = "서버 접속 실패";
                labelConnection.ForeColor = Color.Red;
            }
        }

        // 전송 및 수신
        private void button2_Click(object sender, EventArgs e)
        {
            // 데이터 전송
            bw.Write(int.Parse(textBox2.Text));
            bw.Write(float.Parse(textBox3.Text));
            bw.Write(textBox4.Text);

            // 데이터 수신: read메소드는 대기하다가 데이터를 받음
            intValue = br.ReadInt32();
            floatValue = br.ReadSingle();
            strValue = br.ReadString();

            string str = $"[서버 데이터 수신]\n{intValue}\n{floatValue}\n{strValue}";
            MessageBox.Show(str);
        }

        // 폼이 닫힐 때 모든 리소스 해제
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            bw.Write(-1);   // 서버에게 클라이언트의 종료를 알림.
            bw.Close();
            br.Close();
            ns.Close();
            tcpClient.Close();
        }
    }
}
