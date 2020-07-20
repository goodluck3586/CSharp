using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex19_Property
{
    class Person_GetSet
    {
        private string name;

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetName()
        {
            return name;
        }
    }

    class Person_Property
    {
        private string name;

        public string Name
        {
            set{ name = value; }        // value : set 접근자의 암묵적 매개변수

            get{ return name;  }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person_GetSet p1 = new Person_GetSet();
            p1.SetName("이동윤");
            Console.WriteLine(p1.GetName());

            Person_Property p2 = new Person_Property();
            p2.Name = "이동윤";
            Console.WriteLine(p2.Name);
            
        }
    }
}
