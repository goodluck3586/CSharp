using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm10_ListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static int serialNum;
        int c, cpp, csharp, total;

        private void btnModify_Click(object sender, EventArgs e)
        {
            if (CheckInputScore())
            {
                total = c + cpp + csharp;
                avg = total / 3;

                listView1.SelectedItems[0].SubItems[1].Text = c.ToString();
                listView1.SelectedItems[0].SubItems[2].Text = cpp.ToString();
                listView1.SelectedItems[0].SubItems[3].Text = csharp.ToString();
                listView1.SelectedItems[0].SubItems[4].Text = total.ToString();
                listView1.SelectedItems[0].SubItems[5].Text = avg.ToString("f2");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            //listView1.Items.RemoveAt(0);
            listView1.SelectedItems[0].Remove();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            textBoxC.Text = listView1.SelectedItems[0].SubItems[1].Text;
            textBoxCPP.Text = listView1.SelectedItems[0].SubItems[2].Text;
            textBoxCS.Text = listView1.SelectedItems[0].SubItems[3].Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 100; i > 60; i-=10)
            {
                serialNum++;
                listView1.Items.Add(new ListViewItem(new string[] { serialNum.ToString(), i.ToString(), i.ToString(), i.ToString(), (i*3).ToString(), (i*3/3.0f).ToString("f2") }));
            } 
        }

        float avg;
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckInputScore())
            {
                serialNum++;
                total = c + cpp + csharp;
                avg = total / 3;
                listView1.Items.Add(new ListViewItem(new string[] { serialNum.ToString(), c.ToString(), cpp.ToString(), csharp.ToString(), total.ToString(), avg.ToString("f2") }));
            }
        }

        private bool CheckInputScore()
        {
            if(int.TryParse(textBoxC.Text, out c) && int.TryParse(textBoxCPP.Text, out cpp) && int.TryParse(textBoxCS.Text, out csharp))
            {
                textBoxC.Clear();
                textBoxCPP.Clear();
                textBoxCS.Clear();
                return true;
            }

            MessageBox.Show("점수를 입력하세요", "알림", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }
    }
}
