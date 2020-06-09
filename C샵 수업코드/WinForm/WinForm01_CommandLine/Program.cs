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

        // 이벤트 핸들러(이벤트에 바인딩된 메서드), 이벤트가 발생하면 이벤트 핸들러의 코드가 실행됨. 
        private void button1_Click(object sender, EventArgs e)  // 이벤트를 처리하는 두 개의 매개변수 제공(이벤트를 발생 시킨 개체에 대한 참조, 유형별 이벤트 처리 객체)
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
