using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Triangle:Shape
    {
        public override decimal CalculateSurface(decimal width, decimal height)
        {
            decimal area = (height * width) / 2;
            return area;
        }
        public Triangle(decimal width, decimal height)
        {
            Console.WriteLine("The area of the Triangle is: {0} ", CalculateSurface(width, height));
        }
    }
}
