using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* 575p 예제 */
namespace File02
{
    class Program
    {
        static void Main(string[] args)
        {
            string directory;
            if (args.Length < 1)
                directory = ".";  // 현재 디렉토리
            else
                directory = args[0];  // 매개변수로 넘어온 경로

            Console.WriteLine($"{directory} directory info");
            Console.WriteLine("- Directories :");
            var directories = (from dir in Directory.GetDirectories(directory)  // 지정된 디렉터리에 있는 하위 디렉터리의 이름(경로 포함)을 string[] 배열로 반환 
                               let info = new DirectoryInfo(dir)  // let은 LINQ 안에서 사용할 수 있는 변수를 만든다.(LINQ의 var)
                               select new { Name = info.Name, Attributes = info.Attributes }).ToList();

            foreach (var d in directories)
                Console.WriteLine($"{d.Name} : {d.Attributes}");
            Console.WriteLine();

            Console.WriteLine("- Files :");
            var files = (from file in Directory.GetFiles(directory)
                         let info = new FileInfo(file)
                         select new { Name = info.Name, FileSize = info.Length, Attributes = info.Attributes }).ToList();

            foreach (var f in files)
                Console.WriteLine($"{f.Name} : {f.FileSize}, {f.Attributes}");
        }
    }
}