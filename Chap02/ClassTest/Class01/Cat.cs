using System;

namespace Class01
{
    class Cat
    {
        public string name = "야옹이";

        public string color;

        public Cat()
        {
            //name = "야옹이";
        }

        public Cat(string name, string color)
        {
            name = name;
            color = color;
        }

        public void Meow()
        {
            Console.WriteLine($"{name} : 야옹");
        }
    }
}
