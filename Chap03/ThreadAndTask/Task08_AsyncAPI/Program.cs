using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
/* 파일을 복사하고 파일 복사를 마친 뒤 파일의 크기를 반환한다. */
namespace Task08_AsyncAPI
{
    class Program
    {
        static string str = "안녕 세상아";

        static void Main(string[] args)
        {
            string path = @"D:\CSharpWorkspace";

            // 파일 생성 및 텍스트 작성
            CreateFile(path+@"\source.txt");

            #region 동기식 파일 복제
            // 1. FileStream 사용
            Console.WriteLine(CopySync(path + @"\source.txt", path + @"\target1.txt"));

            // 2. StreamReader, StreamWriter 사용
            Console.WriteLine(CopySyncUsingStremWriter(path + @"\source.txt", path + @"\target2.txt"));
            #endregion

            #region 비동기식 파일 복제
            // 1. FileStream 사용
            Task<long> asyncTask1 = CopyAsync(path + @"\source.txt", path + @"\target3.txt");

            // 2. StreamReader, StreamWriter 사용
            var asyncTask2 = CopyAsyncUsingStreamWriter(path + @"\source.txt", path + @"\target4.txt");
            #endregion

            Console.WriteLine("메인 스레드 종료");
            Console.WriteLine($"Copied Total {asyncTask1.Result} Bytes");
            Console.WriteLine($"Copied Total {asyncTask2.Result} Bytes");
            //Console.ReadLine();
        }

        private static void CreateFile(string path)
        {
            using(var sw = new StreamWriter(path))
            {
                sw.Write("Hello World!!!");
            }
        }

        static long CopySync(string FromPath, string ToPath)
        {
            using(var fromStream = new FileStream(FromPath, FileMode.Open))
            {
                long totalCopied = 0;
                using (var toStream = new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    while((nRead=fromStream.Read(buffer, 0, buffer.Length)) != 0)
                    {
                        toStream.Write(buffer, 0, nRead);
                        totalCopied += nRead;
                    }
                }
                return totalCopied;
            }
        }

        static long CopySyncUsingStremWriter(string FromPath, string ToPath)
        {
            using(var fromStream = new StreamReader(FromPath))
            {
                using (var toStream = new StreamWriter(ToPath))
                {
                    string line;
                    line = fromStream.ReadToEnd();
                    toStream.Write(line);
                    return line.Length;
                }
            }
        }

        async static Task<long> CopyAsync(string FromPath, string ToPath)
        {
            Console.WriteLine("CopyAsync() 시작");
            using (var fromStream = new FileStream(FromPath, FileMode.Open))
            {
                long totalCopied = 0;

                using (var toStream = new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    while ((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;
                    }
                }
                return totalCopied;
            }
            Console.WriteLine("CopyAsync() 종료");

            /* Task를 이용한 비동기 작업이어야 비동기로 실행된다. */
            //Task.Run(() =>
            //{
            //    Thread.Sleep(100);
            //    Console.WriteLine("비동기 테스트");
            //});

            //return 100;
        }

        async static Task<long> CopyAsyncUsingStreamWriter(string FromPath, string ToPath)
        {
            using (var fromStream = new StreamReader(FromPath))
            {
                using (var toStream = new StreamWriter(ToPath))
                {
                    str = await fromStream.ReadToEndAsync();
                    await toStream.WriteAsync(str);
                    return str.Length;
                }
            }
        }
    }
}
