using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    internal class Worker : Human
    {
        public decimal wage { get; set; }
        public int hoursWorked { get; set; }

        public Worker(decimal wage, int hours)
        {
            this.wage = wage;
            this.hoursWorked = hours;
        }

        public decimal calculateHourlyWage(decimal wage, int hours)
        {
            decimal hourlyWage;

            hourlyWage = wage / hours;
            return hourlyWage;
        }
    }
}
