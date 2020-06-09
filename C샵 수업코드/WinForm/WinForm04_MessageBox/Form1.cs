using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm04_MessageBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        MessageBoxButtons msgBoxBtns;  //메시지 버튼 옵션 설정
        MessageBoxIcon msgBoxIcon;    //메시지 버튼 아이콘 설정

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (this.rbOK.Checked == true)
                msgBoxBtns = MessageBoxButtons.OK;
            else if (this.rbOKCancel.Checked == true)
                msgBoxBtns = MessageBoxButtons.OKCancel;
            else if (this.rbYesNo.Checked == true)
                msgBoxBtns = MessageBoxButtons.YesNo;

            if (this.rbError.Checked == true)
                msgBoxIcon = MessageBoxIcon.Error;
            else if (this.rbInformation.Checked == true)
                msgBoxIcon = MessageBoxIcon.Information;
            else if (this.rbQuestion.Checked == true)
                msgBoxIcon = MessageBoxIcon.Question;

            MessageBox.Show("메시지 박스를 확안하세요.", "알림", msgBoxBtns, msgBoxIcon);
        }
    }
}
