using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Kitten:Animal
    {

        public override void noise()
        {
            Console.Write(" \tPurrrr");
        }
        public Kitten()
        {
            Console.Write(" \tKitten ");
            noise();
        }
    }
}
