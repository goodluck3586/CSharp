using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 삼각형과 사각형 도형의 넓이를 구하는 메소드를 매개변수로 넘기기 */
namespace Exercise17_Delegate
{
    delegate double AreaDelegate(double w, double h);

    class ShapeArea
    {
        public void PrintShapeArea(string name, double a, double b, AreaDelegate areaDelegate)
        {
            Console.WriteLine($"{name} 도형의 넓이 : {areaDelegate(a, b)}");
        }
    }

    class Program
    {
        static double RectangleArea(double a, double b)
        {
            return a * b;
        }

        static double TriangleArea(double a, double b)
        {
            return a * b / 2;
        }

        static void Main(string[] args)
        {
            ShapeArea shapeArea = new ShapeArea();
            shapeArea.PrintShapeArea("사각형", 20, 30, new AreaDelegate(RectangleArea));
            shapeArea.PrintShapeArea("삼각형", 20, 30, TriangleArea);
        }
    }
}
