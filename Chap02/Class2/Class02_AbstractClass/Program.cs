using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class02_AbstractClass
{
    abstract class AbstractBase
    {
        protected void PrivateMethod()
        {
            Console.WriteLine("AbstractBase.PrivateMethod()");
        }

        public void PublicMethod()
        {
            Console.WriteLine("AbstractBase.PublicMethod()");
        }

        public abstract void AbstractMethod();
    }

    class Derived : AbstractBase
    {
        public override void AbstractMethod()
        {
            Console.WriteLine("Derived.AbstractMethod()");
            PrivateMethod();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractBase obj = new Derived();
            obj.AbstractMethod();
            obj.PublicMethod();
        }
    }
}
