using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    // UC4: Using SWITCH CASE checking whether Employee is working full-time or part-time basis.
    internal class SwitchCase
    {
        public void Wage()
        {
            int HOURWAGE = 20, EMPHRS = 0;
            const int IS_FULL_TIME = 0, IS_PART_TIME = 1;
            Console.WriteLine("Working hours for\n0. Full-time employee is 8hrs\n1. Part-time employee is 4 hrs\n2. Employee is not working\n");
            Random random = new Random();
            int empAttendence = random.Next(0, 3);//0,1,2
            Console.WriteLine("Random function uses value: " + empAttendence);
            switch (empAttendence)
            {
                case IS_FULL_TIME:
                    EMPHRS = 8;
                    Console.WriteLine("\nEmployee is working Full-time");
                    break;
                case IS_PART_TIME:
                    EMPHRS = 4;
                    Console.WriteLine("\nEmployee is working Part-time");
                    break;
                case 3:
                    EMPHRS = 0;
                    Console.WriteLine("\nEmployee is neither working as Full-time nor Part-time");
                    break;
            }
            int Dailywage = EMPHRS * HOURWAGE;
            Console.WriteLine("\nDaily wage is: " + Dailywage);
        }
    }
}
