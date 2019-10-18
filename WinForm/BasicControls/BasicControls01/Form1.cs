using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicControls01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string str = ""; // 결과 : 문자 저장

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)   // Enter 키를 누를 때
            {
                e.Handled = true;  // 소리 없앰
                if (TextCheck() == true)
                {

                }
            }
        }

        private bool TextCheck()
        {
            if (this.txtEdit.Text != "") return true;
            else
            {
                MessageBox.Show("텍스트를 입력하세요!", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtEdit.Focus();
                return false;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (TextCheck() == true)
                this.lblResult.Text = str + this.txtEdit.Text;
        }
    }
}
