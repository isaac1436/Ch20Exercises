using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Frog:Animal
    {

        public override void noise()
        {
            Console.Write(" \tRibbit");
        }
        public Frog()
        {
            Console.Write(" \tFrog ");
            noise();
        }
    }
}
