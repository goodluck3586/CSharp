using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Using문 사용(리소스 유효범위 지정) */
namespace File06_FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 리소스를 사용한 다음에는 닫아줘야 한다. */
            FileStream fs1 = new FileStream("test1.txt", FileMode.Create);
            StreamWriter sw1 = new StreamWriter(fs1, Encoding.UTF8);
            sw1.WriteLine("Hello C#");
            sw1.WriteLine("아이유");
            sw1.Write(2580);
            sw1.Close();
            fs1.Close();

            /* using 문은 리소스를 가져오고 문을 실행 한 다음 리소스를 닫는다. */
            using (FileStream fs2 = new FileStream("test2.txt", FileMode.Create))
            {
                using (StreamWriter sw2 = new StreamWriter(fs2))
                {
                    sw2.WriteLine("안녕 C#");
                    sw2.WriteLine("장만월");
                    sw2.Write(1234);
                }
            }

            /* C 드라이브의 디렉토리 이름을 가져와 "CDriveDirs.txt"에 기록 */
            DirectoryInfo[] cDirs = new DirectoryInfo(@"c:\").GetDirectories();  // Get the directories currently on the C drive.

            // Write each directory name to a file.
            using (StreamWriter sw2 = new StreamWriter("CDriveDirs.txt"))
            {
                foreach (DirectoryInfo dir in cDirs)
                {
                    sw2.WriteLine(dir.Name);
                }
            }

            // Read and show each line from the file.
            string line = "";
            using (StreamReader sr = new StreamReader("CDriveDirs.txt"))
            {
                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    }
}
