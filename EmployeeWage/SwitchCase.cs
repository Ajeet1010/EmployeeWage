using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class SwitchCase
    {
        public void Wage()
        {
            int Hourwage = 20,emphrs = 0;
            const int Is_Full_Time = 0, Is_Part_Time = 1;
            Console.WriteLine("Working hours for\n1. Full-time employee is 8hrs\n2. Part-time employee is 4 hrs\n");
            Random random = new Random();
            int empAttendence = random.Next(0, 3);//0,1,2
            Console.WriteLine("Random function uses value: " +empAttendence);
            switch (empAttendence)
            {
                case Is_Full_Time:
                    emphrs = 8;
                    Console.WriteLine("Employee is working Full-time");
                    break;
                case Is_Part_Time:
                    emphrs = 4;
                    Console.WriteLine("Employee is working Part-time");
                    break;
                case 3:
                    emphrs = 0;
                    Console.WriteLine("Employee is neither working as Full-time nor Part-time");
                    break;
            }
            int Dailywage = emphrs * Hourwage;
            Console.WriteLine("daily wage is: " + Dailywage);
        }
    }
}
