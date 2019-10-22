using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Stream에 문자열 데이터를 쓰려면 반드시 그 전에 Encoding 타입을 이용해 바이트 배열로 변환해야 한다.
namespace File05_StreamWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            string path1 = @"D:\CSharpWorkspace\StreamWriterTest1.txt";
            string path2 = @"D:\CSharpWorkspace\StreamWriterTest2.txt";

            /* FileStream(파일을 다루기 위한 BCL의 가장 기본적인 타입) */
            // MemoryStream은 메모리에 할당한 바이트 배열을 읽기/쓰기 했다면, FileStream은 디스크의 파일을 대상으로 읽기/쓰기 작업

            #region FileStream으로 데이터 쓰고 읽기
            // FileStream으로 데이터 쓰기
            FileStream fs1 = new FileStream(path1, FileMode.Create);
            byte[] buf = Encoding.UTF8.GetBytes("Hello World\n");  // 문자열을 쓸 때마다 매번 이런 식으로 변환하는 것은 번거롭다.
            fs1.Write(buf, 0, buf.Length);
            buf = Encoding.UTF8.GetBytes(32000.ToString());
            fs1.Write(buf, 0, buf.Length);
            Console.WriteLine($"fs1.Position: {fs1.Position}");
            
            // FileStream으로 읽기
            byte[] readBytes = new byte[fs1.Position];
            fs1.Position = 0;
            fs1.Read(readBytes, 0, readBytes.Length);
            UTF8Encoding temp = new UTF8Encoding();
            Console.WriteLine(temp.GetString(readBytes));
            fs1.Close();
            #endregion
            // FileStream 클래스는 파일 처리를 위한 모든 것을 갖고 있지만, 데이터를 저장할 때 반드시 byte 배열 형식으로 변환해야 하기 때문에 불편하다.

            /* StreamWriter/StreamReader(문자로 이루어진 스트림을 쉽게 사용할 수 있도록 도와줌) */
            #region StreamWriter, StreamReader로 데이터 쓰고 읽기
            // StreamWriter로 데이터 쓰기
            // FileStream fs2 = new FileStream(path2, FileMode.Create);
            StreamWriter sw = new StreamWriter(new FileStream(path2, FileMode.Create));
            sw.WriteLine("Hello World");  // 정해진 인코딩 방식에 따라 자동으로 바이트 배열로 변환 후 Stream에 쓴다.
            sw.Write(32000);  // 인자가 문자열이 아니어도 ToString() 메서드를 이용해 변환한 문자열을 쓴다.
            sw.Close();

            // StreamReader로 데이터 읽기
            StreamReader sr = new StreamReader(new FileStream(path2, FileMode.Open));  // 인자로 path2를 넣어줄 수도 있다.
            Console.WriteLine(sr.ReadToEnd());  // 현재 위치에서 끝까지의 스트림은 문자열
            sr.Close();
            #endregion
        }
    }
}
