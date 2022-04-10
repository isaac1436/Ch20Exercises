using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    public class Courses
    {
        public string courseName { get; set; }
        public int noOfClasses { get; set; }
        public int exerciseCount { get; set; }

        public Courses(string course, int classes, int exercises)
        {
            this.courseName = course;
            this.noOfClasses = classes;
            this.exerciseCount = exercises;
        }
    }
}
