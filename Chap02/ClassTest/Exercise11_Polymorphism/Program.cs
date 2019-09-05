using System;

namespace Exercise11_Polymorphism
{
    class Shape
    {
        protected int width, height;

        public Shape(int a = 0, int b = 0)
        {
            width = a;
            height = b;
        }
        public virtual int area()
        {
            Console.Write("도형의 넓이 : ");
            return 0;
        }
    }

    class Rectangle : Shape
    {
        public Rectangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int area()
        {
            Console.Write("사각형의 넓이 : ");
            return (width * height);
        }
    }

    class Triangle : Shape
    {
        public Triangle(int a = 0, int b = 0) : base(a, b)
        {
        }
        public override int area()
        {
            Console.Write("삼각형의 넓이 : ");
            return (width * height / 2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r = new Rectangle(10, 7);
            Triangle t = new Triangle(10, 5);

            PrintArea(r);
            PrintArea(t);
        }

        static void PrintArea(Shape sh)
        {
            Console.WriteLine("{0}\n", sh.area());
        }
    }
}
