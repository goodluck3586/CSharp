using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    struct City
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string CountryCode { get; set; }
        public string District { get; set; }
        public string Population { get; set; }

        public City(string iD, string name, string countryCode, string district, string population)
        {
            ID = iD;
            Name = name;
            CountryCode = countryCode;
            District = district;
            Population = population;
        }

        public void Print()
        {
            Console.WriteLine($"{ID}, {Name}, {CountryCode}, {District}, {Population}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<string> strList = new List<string>();

            string filePath = @"D:\CSharpWorkspace\TextFiles\City.csv";
            FileStream fs = new FileStream(filePath, FileMode.Open);
            StreamReader sr = new StreamReader(fs);
            string line;

            List<City> cityList = new List<City>();
            while ((line = sr.ReadLine()) != null)
            {
                string[] strArr = line.Split(',');
                /*for (int i = 0; i < strArr.Length; i++)
                {
                    Console.Write($"{strArr[i]} ");
                }
                Console.WriteLine();*/
                /*foreach (var item in strArr)
                {
                    Console.Write($"{item} ");
                }
                Console.WriteLine();*/
                cityList.Add(new City(strArr[0], strArr[1], strArr[2], strArr[3], strArr[4]));
            }
            sr.Close();

            foreach (var item in cityList)
            {
                item.Print();
            }
        }

        static string ModifyString(string str)
        {
            string[] strArray = str.Split(',');
            foreach (var item in strArray)
            {
                item.Trim();
                Console.WriteLine(item.IndexOf("'"));
                item.Remove(item.IndexOf("'"), 1);
                Console.WriteLine(item);
            }
            return str;
        }
    }
}
