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

namespace WinForm13_FileDialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void 저장ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                // 파일 처리
                if ((myStream = saveFileDialog1.OpenFile()) != null)
                {
                    //myStream.Close();
                    using(StreamWriter sw = new StreamWriter(myStream))
                    {
                        sw.WriteLine(textBox1.Text);
                    }
                    textBox1.Clear();
                }
            }
        }

        private void 열기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stream myStream;
            openFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    using(StreamReader sr = new StreamReader(myStream))
                    {
                        //MessageBox.Show(sr.ReadToEnd());
                        textBox1.Text = sr.ReadToEnd();
                    }
                }
            }
        }

        private void textBox지우기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Clear();  
        }
    }
}
