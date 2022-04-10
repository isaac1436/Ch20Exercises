using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Cat : Animal
    {

        public override void noise()
        {
            Console.Write(" \tPurr");
        }
        public Cat()
        {
            Console.Write(" \tCat ");
            noise();
        }
    }
}
