using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm14_FileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnReadPath_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  // 파일 열기 대화상자 호출
            {
                txtReadPath.Text = openFileDialog1.FileName;  // 선택한 파일의 전체 경로를 txtReadPath에 나타냄.
            }
        }

        private void btnReadAll_Click(object sender, EventArgs e)
        {
            if (File.Exists(txtReadPath.Text))
            {
                using(StreamReader sr = new StreamReader(txtReadPath.Text))
                {
                    txtReadView.Text = sr.ReadToEnd();
                }
            }
            else
            {
                MessageBox.Show("읽을 수 있는 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnReadLine_Click(object sender, EventArgs e)
        {
            txtReadView.Clear();

            if (File.Exists(txtReadPath.Text))
            {
                using (StreamReader sr = new StreamReader(txtReadPath.Text))
                {
                    string line = null;
                    while((line=sr.ReadLine()) != null)
                    {
                        txtReadView.AppendText(line + "\r\n");
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("읽을 수 있는 파일이 없습니다.", "에러", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnWritePath_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtWritePath.Text = saveFileDialog1.FileName;
            }
        }

        private void btnWriteAll_Click(object sender, EventArgs e)
        {
            using(StreamWriter sw = new StreamWriter(txtWritePath.Text))
            {
                sw.WriteLine(txtWriteView.Text);
            }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnWriteLine_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = new StreamWriter(txtWritePath.Text))
            {
                foreach (var str in txtWriteView.Lines)
                {
                    sw.WriteLine(str);
                }
            }
            MessageBox.Show("파일이 정상적으로 저장되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
