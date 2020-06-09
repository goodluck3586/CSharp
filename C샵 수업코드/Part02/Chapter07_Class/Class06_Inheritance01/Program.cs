// 기본 클래스와 파생 클래스의 생성자, 소멸자 호출 순서
namespace Class05_Inheritance
{
    class Base
    {
        public Base()
        {
            Console.WriteLine("Base()");
        }
        ~Base()
        {
            Console.WriteLine("~Base()");
        }
        public void BaseMethod()
        {
            Console.WriteLine("BaseMethod()");
        }
    }

    class Derived : Base
    {
        public Derived()
        {
            Console.WriteLine("Derived()");
        }
        ~Derived()
        {
            Console.WriteLine("~Derived()");
        }
        public void DerivedMethod()
        {
            base.BaseMethod();
            Console.WriteLine("DerivedMethod()");
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Derived derived = new Derived(); 
            derived.DerivedMethod();
        }
    }
}
