using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm08_progress
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int Num = 0;
        string strStatus = "";
        bool isFull = false;

        private void Form1_Load(object sender, EventArgs e)
        {
            strStatus = this.labelStatus.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isFull)
            {
                // 초기화
                Num = 0;
                this.btnStart.Text = "시작";
                this.progressBar1.Value = 0;
                this.labelStatus.Text = "진행 상태";
                isFull = false;
            }
            else
            {
                // ProgressBar 진행
                this.timer1.Enabled = true;
            }   
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Num++;
            if (Num > 100)
            {
                this.timer1.Enabled = false;
                isFull = true;
                this.btnStart.Text = "초기화";
                return;
            }
            this.progressBar1.Value = Num;
            this.labelStatus.Text = $"{strStatus} : {Num}%";
        }
    }
}
