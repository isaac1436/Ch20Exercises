using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Classes
    {
        public string classID { get; set; }

        public class Students
        {
            public string name { get; set; }
            public string studentCode { get; set; }

            public Students(string name, string studentCode)
            {
                this.name = name;
                this.studentCode = studentCode;
            }

        }
    }
}
