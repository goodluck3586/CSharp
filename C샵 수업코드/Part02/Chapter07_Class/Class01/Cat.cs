class Cat
    {
        public string name = "야옹이";

        public string color;

        public Cat()
        {
            //name = "야옹이";  // 생성자의 주요 용도는 초기화
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