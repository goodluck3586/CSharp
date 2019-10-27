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
            //Console.WriteLine(CopySync(path + @"\source.txt", path + @"\target.txt"));
            //Console.WriteLine(CopySyncUsingStremWriter(path + @"\source.txt", path + @"\target.txt"));

            //Task<long> CopyTask = CopyAsync(path + @"\source.txt", path + @"\target2.txt");
            //CopyTask.Wait();
            //Console.WriteLine($"Copied Total {CopyTask.Result} Bytes");

            Task.Run(() => { DoCopy(path + @"\source.txt", path + @"\target2.txt"); });
            
            Console.WriteLine("메인 스레드 종료");
            Console.ReadLine();
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

        static async void DoCopy(string FromPath, string ToPath)
        {
            long totalCopied = await CopyAsync(FromPath, ToPath);
            Console.WriteLine($"Copied Total {totalCopied} Bytes");

            var copyTask = CopyAsyncUsingStreamWriter(FromPath, ToPath);
            Console.WriteLine($"str: {str}");
            copyTask.Wait();
            Console.WriteLine($"str: {str}");
            Console.WriteLine($"Copied Total {totalCopied} Bytes");
        }

        async static Task<long> CopyAsync(string FromPath, string ToPath)
        {
            using(var fromStream = new FileStream(FromPath, FileMode.Open))
            {
                long totalCopied = 0;

                using (var toStream = new FileStream(ToPath, FileMode.Create))
                {
                    byte[] buffer = new byte[1024];
                    int nRead = 0;
                    while((nRead = await fromStream.ReadAsync(buffer, 0, buffer.Length)) != 0)
                    {
                        await toStream.WriteAsync(buffer, 0, nRead);
                        totalCopied += nRead;
                    }
                }
                return totalCopied;
            }
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
