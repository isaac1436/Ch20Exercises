using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    internal class Tomcat : Animal
    {

        public override void noise()
        {
            Console.Write(" \tMiauuu!!! ");
        }
        public Tomcat()
        {
            Console.Write(" \tTomCat ");
            noise();
        }
    }
}
