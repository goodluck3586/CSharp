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
    public partial class Form2 : Form
    {
        public int num1, num2;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult = DialogResult.Yes;
        }

        private void btnSendToForm1_Click(object sender, EventArgs e)
        {
            if(int.TryParse(textBox1.Text, out num1) && int.TryParse(textBox2.Text, out num2))
            {
                Close();  // Form2을 닫는다.
            }
            else
            {
                MessageBox.Show("숫자를 입력하세요");
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            if (Owner != null)
            {
                Form1 mainForm = Owner as Form1;
                labelReceive.Text = mainForm.Message;
            }
        }
    }
}
