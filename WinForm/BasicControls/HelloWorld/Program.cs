using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloWorld
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Application.Run() : Form 객체를 화면에 보여주고, 
            // 메시지 루프를 만들어 
            // 마우스,키보드 등의 입력을 UI (User Interface) 쓰레드에 전달하는 기능
            Application.Run(new Form1());  
        }
    }
}
