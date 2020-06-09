using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex04_Polymorphism3_WinForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (var item in this.Controls) // this.Controls : Form1이 가지고 있는 Control들의 컬렉션
            {
                if (item is CheckBox)
                {
                    if (((CheckBox)item).Checked)
                    {
                        ((CheckBox)item).ForeColor = Color.Red;
                    }
                    else
                    {
                        ((CheckBox)item).ForeColor = Color.Blue;
                    }
                }
                    
            }
        }
    }
}
