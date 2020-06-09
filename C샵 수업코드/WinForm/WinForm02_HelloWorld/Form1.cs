using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Form은 GUI 애플리케이션의 기본 단위로 정보를 사용자에게 표시하는 비주얼 화면
// Form UI는 Form1.cs과 Form1.Designer.cs 파일에서 정의 
// Form1.cs는 Form1.designer.cs와 동일한 클래스로서 주로 UI의 이벤트를 핸들링 하는 코드들을 적게된다. 
namespace HelloWorld
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 생성자에서 반드시 InitializeComponent()를 호출해야 한다.
            InitializeComponent();  // UI 컴포넌트를 생성하는 역활
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.label1.Text = "Hello World!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "Button Clicked";
        }
    }
}
