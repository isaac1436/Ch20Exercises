using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Circle : Shape
    {
        public override decimal CalculateSurface(decimal radius, decimal Radius)
        {
            decimal pi =(decimal) Math.PI;
            decimal area =pi * radius * Radius;
            return area;
        }

        public Circle(decimal radius)
        {
            Console.WriteLine("The area of the Circle is: {0} ", CalculateSurface(radius, radius));
        }
    }
}
