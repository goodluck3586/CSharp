using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace File01
{
    class Program
    {
        static void Main(string[] args)
        {
            // 디렉토리가 존재하지 않으면 생성하고 존재하면 삭제한다.
            Console.WriteLine("***** Directory, File 클래스 사용 *****");
            CreateDirectoryUsingDirectory();
            Console.WriteLine();

            //Console.WriteLine("***** DirectoryInfo, FileInfo 클래스 사용 *****");
            //CreateDirectoryUsingDirectoryInfo();
        }

        #region Directory, File
        static void CreateDirectoryUsingDirectory()
        {
            string path = @"D:\CSharpWorkspace\TestDirectory";  // 디렉토리 경로

            if (Directory.Exists(path))                  // 해당 디렉토리가 존재하면
            {
                ReadFileUsingFile(path);                 // MyText.txt 파일 내용 읽기
                DeleteFileUsingFile(path);               // MyText.txt 파일 제거
                Directory.Delete(path);                  // TestDirectory 디렉토리 제거
                Console.WriteLine($"디렉토리가 삭제됨. {path} ");
            }
            else
            {
                Directory.CreateDirectory(path);        // TestDirectory 디렉토리 생성
                Console.WriteLine($"디렉토리 생성됨. {path} ");
                CreateFileUsingFile(path);              // MyText.txt 파일 생성, "Hello World" 작성          
                ReadFileUsingFile(path);                // MyText.txt 파일 내용 읽기
            }

            #region 현재 디렉토리에 존재하는 모든 디렉토리의 List 반환 및 출력
            var directories = (from dir in Directory.GetDirectories(@"D:\CSharpWorkspace")  // string[] 배열
                               let info = new DirectoryInfo(dir)
                               select new { Name = info.Name, Attributes = info.Attributes }).ToList();

            foreach (var d in directories)
                Console.WriteLine($"directories : {d.Name} : {d.Attributes}");
            #endregion
        }

        private static void DeleteFileUsingFile(string path)
        {
            path = path + @"\MyText.txt";
            File.Delete(path);
            Console.WriteLine($"파일 삭제됨. {path}");
        }

        static void CreateFileUsingFile(string path)
        {
            path = path + @"\MyText.txt";
            if (!File.Exists(path))
            {
                FileStream fs = File.Create(path);
                StreamWriter sw = new StreamWriter(fs);
                sw.WriteLine("Hello File");
                sw.Close();

                Console.WriteLine($"파일 생성됨. {path}");
            }
        }

        static void ReadFileUsingFile(string path)
        {
            path = path + @"\MyText.txt";
            StreamReader sr = File.OpenText(path);
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            sr.Close();
            Console.WriteLine($"파일 내용 읽음. {path}");
        }
        #endregion

        #region DirectoryInfo, FileInfo
        static void CreateDirectoryUsingDirectoryInfo()
        {
            string dirPath = @"D:\CSharpWorkspace\TestDirectoryInfo";  // 디렉토리 경로
            string filePath = dirPath + @"\MyText.txt";

            DirectoryInfo dirInfo = new DirectoryInfo(dirPath);  // DirectoryInfo 객체 생성, 파일, 폴더 또는 드라이브의 이름을 나타내는 문자열을 생성자에 전달하여 이러한 클래스의 인스턴스를 만들 수다.
            FileInfo fi = new FileInfo(filePath);

            if (dirInfo.Exists)
            {
                ReadFileUsingFileInfo(fi);             // MyText.txt 파일 내용 읽기
                DeleteFileUsingFileInfo(fi);           // MyText.txt 파일 제거
                dirInfo.Delete();                      // 디렉토리 삭제
                Console.WriteLine($"디렉토리 삭제됨. {dirInfo.FullName}");
            }
            else
            {
                dirInfo.Create();                      // TestDirectoryInfo 디렉토리 생성
                Console.WriteLine($"디렉토리 생성됨. {dirInfo.FullName}");
                CreateFileUsingFileInfo(fi);
                ReadFileUsingFileInfo(fi);
            }
        }

        private static void DeleteFileUsingFileInfo(FileInfo fi)
        {
            fi.Delete();
            Console.WriteLine($"파일 삭제됨. {fi.FullName}");
        }

        private static void ReadFileUsingFileInfo(FileInfo fi)
        {
            StreamReader sr = fi.OpenText();
            string s;
            while ((s = sr.ReadLine()) != null)
            {
                Console.WriteLine(s);
            }
            sr.Close();
            Console.WriteLine($"파일 내용 읽음. {fi.FullName}");
        }

        private static void CreateFileUsingFileInfo(FileInfo fi)
        {
            FileStream fs = fi.Create();
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine("Hello FileInfo");
            sw.Close();

            Console.WriteLine($"파일 생성됨. {fi.FullName}");
        }
        #endregion
    }
}
