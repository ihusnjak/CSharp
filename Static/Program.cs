using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPlayground
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(Circle._PI);
            Circle c1 = new Circle(5);
            Console.WriteLine(c1.CalculateArea());
        }
            
    }

    public class Circle
    {
        public static float _PI;
        int _Radius;

        static Circle()
        {
            Console.WriteLine("static const. called");
            _PI = 3.141F;
        }

        public Circle(int radius)
        {
            Console.WriteLine("instance const. called.");
                this._Radius = radius;
        }

        public float CalculateArea()
        {
            return _PI * this._Radius * this._Radius;
        }

    }

}