using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControl02_TextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string resultStr = "";

        private void Form1_Load(object sender, EventArgs e)
        {
            resultStr = this.labelResult.Text;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TextChecker() == true)
            {
                this.labelResult.Text = resultStr + this.textBox.Text;
            }
        }

        private void txtEdit_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.labelResult.Text = resultStr + this.textBox.Text;
            if (e.KeyChar == (char)Keys.Enter)  // (char)13
            {
                if (TextChecker() == true)
                {
                    this.labelResult.Text = resultStr + this.textBox.Text;
                }
            }
        }

        private bool TextChecker()
        {
            if (this.textBox.Text != "")
                return true;
            else
            {
                MessageBox.Show("텍스트를 입력하세요!");
                this.textBox.Focus();
                return false;
            }
        }
    }
}
