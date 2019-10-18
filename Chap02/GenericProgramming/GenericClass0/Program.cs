using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClass0
{
    class Array_int
        {
            private int[] array;
        public int this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }
    class Array_double
    {
        private double[] array;
        public double this[int index]
        {
            get { return array[index]; }
            set { array[index] = value; }
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Array_int arr1 = new Array_int();
            arr1[0] = 100;
            Console.WriteLine(arr1[0]);

            Array_double arr2 = new Array_double();
            arr2[0] = 3.14;
            Console.WriteLine(arr2[0]);
        }
    }
}
