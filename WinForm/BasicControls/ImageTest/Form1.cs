using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageTest
{
    public partial class Form1 : Form
    {
        Bitmap bitmap;

        public Form1()
        {
            InitializeComponent();

            bitmap = new Bitmap(400, 300);
            SetClientSizeCore(400, 300);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            // 메모리에 그려지는 부분
            Graphics bitmapGraphics = Graphics.FromImage(bitmap);
            bitmapGraphics.Clear(Color.Yellow);
            for (int i = 0; i < 10; i++)
            {
                bitmapGraphics.DrawString("C# Programming", Font, Brushes.Black, 10, 10);
            }
            bitmapGraphics.DrawRectangle(Pens.Black, 100, 10, 200, 100);

            e.Graphics.DrawImage(bitmap, 0, 0);

            ////Bitmap myBitmap = new Bitmap("../../Images/iu-png.png");
            //Bitmap myBitmap = new Bitmap("iu-png.png");
            //SetClientSizeCore(myBitmap.Width, myBitmap.Height);
            //e.Graphics.DrawImage(myBitmap, 0, 0);
        }
    }
}
