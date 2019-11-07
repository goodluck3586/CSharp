using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm11_DialogueBox
{
    public partial class Form1 : Form
    {
        int sum;
        public string Message { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            // Dig.ShowDialog();  // 폼 띄우기(Modal)
            if (Dig.ShowDialog() == DialogResult.Yes)
            {
                MessageBox.Show("정상 종료");
            }
            Dig.Dispose();  // Form2의 리소스 제거
        }

        private void btnSendToForm2_Click(object sender, EventArgs e)
        {
            Form2 Dig = new Form2();
            Dig.Owner = this;
            Message = textBox1.Text;
            textBox1.Clear();
            Dig.ShowDialog();

            sum = Dig.num1 + Dig.num2;
            labelReceiveResult.Text = $"계산 결과: {sum}";

            Dig.Dispose();
        }
    }
}
