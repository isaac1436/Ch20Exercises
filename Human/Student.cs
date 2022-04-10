using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal class Student:Human
    {
        public decimal mark { get; set; }

        public Student(decimal mark)
        {
            this.mark = mark;   
        }
    }
}
