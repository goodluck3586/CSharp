using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* FileStream(파일을 다루기 위한 BCL의 가장 기본적인 타입) */
// MemoryStream은 메모리에 할당한 바이트 배열을 읽기/쓰기 했다면, FileStream은 디스크의 파일을 대상으로 읽기/쓰기 작업
namespace File06_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream fs = new FileStream("test.txt", FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
            sw.WriteLine("Hello Wrold");
            sw.WriteLine("이동윤");
            sw.Write(33000);
            sw.Flush();
            sw.Close();
            fs.Close();
        }
    }
}
