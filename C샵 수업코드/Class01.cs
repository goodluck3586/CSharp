namespace Class01
{
    class Cat
    {
        public string Name;
        public string Color;

        public Cat()
        {
        }

        public Cat(string name, string color)
        {
            Name = name;
            Color = color;
        }

        public void Meow()
        {
            Console.WriteLine($"{Name} : 야옹");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            Console.WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            Console.WriteLine($"{nero.Name} : {nero.Color}");

            Cat nabi = new Cat("나비", "갈색");
            nabi.Meow();
            Console.WriteLine($"{nabi.Name} : {nabi.Color}");
        }
    }  
}
