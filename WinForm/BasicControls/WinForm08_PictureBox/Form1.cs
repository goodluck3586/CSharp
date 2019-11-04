using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinForm08_PictureBox
{
    public partial class Form1 : Form
    {
        int ImgCount = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.pictureBox1.Image = this.imageList1.Images[0];
            ImgCount = this.imageList1.Images.Count;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            ImgCount--;
            if (ImgCount < 0)
                ImgCount = this.imageList1.Images.Count - 1;
            this.pictureBox1.Image = this.imageList1.Images[ImgCount];
        }
    }
}
