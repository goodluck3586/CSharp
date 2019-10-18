using System;

namespace Interface2
{
    interface IProduct
    {
        string ProductName { get; set; }
        int Price { get; set; }
    }

    class Product : IProduct
    {
        // 파생 클래스는 부모 인터페이스에 선언된 모든 프로퍼티를 구현해야 한다.
        //public string ProductName { get { return ProductName; } set { ProductName = value; } }
        private string productName;
        public string ProductName
        {
            get { return productName; }
            set { productName = value; }
        }

        public int Price { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Product p = new Product();
            p.ProductName = "노트북";
            p.Price = 2_000_000;
            Console.WriteLine($"{p.ProductName}: {p.Price}원");
        }
    }
}
