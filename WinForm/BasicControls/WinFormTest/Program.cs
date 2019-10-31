using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace WinFormTest
{
    public class Form1 : Form
    {
        public Button button1;

        public Form1()
        {
            button1 = new Button();
            button1.Size = new Size(40, 40);
            button1.Location = new Point(0, 0);
            button1.Text = "Click me";
            this.Controls.Add(button1);
            button1.Click += new EventHandler(button1_Click);  // 메서드에 Click 이벤트 연결
        }

        // Button 클릭 이벤트 핸들러 메소드
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello World");
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();  // 응용 프로그램에 운영체제 스타일 적용
            Application.Run(new Form1());      // 폼 인스턴스 생성 및 실행
        }

    }
}
