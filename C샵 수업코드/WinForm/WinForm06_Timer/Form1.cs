using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm06_Timer
{
    public partial class Form1 : Form
    {
        int countdownNum;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (IntCheck())
            {
                this.timer1.Enabled = true;
            }
        }

        private bool IntCheck()
        {
            if(Int32.TryParse(this.textBox1.Text, out countdownNum))
            {
                return true;
            }
            else
            {
                MessageBox.Show("잘못된 입력입니다.", "Wrong Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }   
        }

        // Interval 속성에 따라 주기적으로 호출되는 코드
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (countdownNum >= 0)
            {
                this.label1.Text = countdownNum.ToString();
                countdownNum--;
            }
            else
            {
                this.timer1.Enabled = false;
                MessageBox.Show("타이머 종료", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
