using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceTest01
{
    class Animal
    {
        protected string name;

        public void BaseMethod()
        {
            Console.WriteLine("BaseMethod()");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            name = "멍멍이";
        }

        public string GetName()
        {
            return name;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            Console.WriteLine(dog.GetName());
        }
    }
}
