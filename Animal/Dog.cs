using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Dog : Animal
    {
        public override void noise()
        {
            Console.Write(" \tBark");
        }
        public Dog()
        {
            Console.Write(" \tDog ");
            noise();
        }
    }
}
