using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Employement
    {
        public void Wage()
        {
            int Hourwage = 20;
            Console.WriteLine("Working hours for\n1. Full-time employee is 8hrs\n2. Part-time employee is 4 hrs\n");
            Console.WriteLine("Enter no of working hours");
            int emphrs = Convert.ToInt32(Console.ReadLine());
            if (emphrs == 8)
            {
                Console.WriteLine("Employee is working Full-time");
            }
            else if (emphrs == 4)
            {
                Console.WriteLine("Employee is working Part-time");
            }
            else
            {
                emphrs = 0;
                Console.WriteLine("Employee is not working");
            }
            int Dailywage = emphrs * Hourwage; ;
            Console.WriteLine("daily wage is: " + Dailywage);
        }
    }
}
