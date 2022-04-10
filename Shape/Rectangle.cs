using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape
{
    internal class Rectangle : Shape
    {
        public override decimal CalculateSurface(decimal width, decimal height)
        {
            decimal area = height * width;
            return area;
        }

        public Rectangle(decimal width, decimal height)
        {
            Console.WriteLine("The area of the rectangle is: {0} ",CalculateSurface(width,height));
        }
    }
}
