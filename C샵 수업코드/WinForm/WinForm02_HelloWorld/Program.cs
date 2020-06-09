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
            Application.EnableVisualStyles();  // 애플리케이션에 대한 비주얼 스타일(비주얼 스타일은 색, 글꼴 및 운영체제 테마를 구성하는 시각적 요소) 사용
            Application.SetCompatibleTextRenderingDefault(false);  // false이면 GDI 기반의 TextRenderer 클래스 사용, true이면 GDI+ 기반의 Graphics 클래스 사용 
            Application.Run(new Form1());  // 현재 스레드에서 표준 애플리케이션 메시지 루프의 실행을 시작하고 지정된 폼을 표시
        }
    }
}
