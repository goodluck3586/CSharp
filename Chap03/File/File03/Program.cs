using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 577p 예제 */
namespace File03
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Usage : File03.exe <Path> [Type:File/Derectory]");
                return;
            }

            string path = args[0];
            string type = "File";
            if (args.Length > 1)
                type = args[1];

            if(File.Exists(path) || Directory.Exists(path))
            {
                if (type == "File")
                    File.SetLastWriteTime(path, DateTime.Now);
                else if (type == "Directory")
                    Directory.SetLastWriteTime(path, DateTime.Now);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Updated {path} {type}");
            }
            else
            {
                if (type == "File")
                    File.Create(path).Close();
                else if (type == "Directory")
                    Directory.CreateDirectory(path);
                else
                {
                    OnWrongPathType(path);
                    return;
                }
                Console.WriteLine($"Created {path} {type}");
            }
        }

        private static void OnWrongPathType(string type)
        {
            Console.WriteLine($"{type} is wrong type");
            return;
        }
    }
}
