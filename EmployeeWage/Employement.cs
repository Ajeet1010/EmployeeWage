using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    // UC3: Checking whether Employee is working full-time or part-time basis.
    internal class Employement
    {
        public void Wage()
        {
            int HOURWAGE = 20;
            Console.WriteLine("Working hours for employee either\n1. Full-time employee is 8hrs\n2. Part-time employee is 4 hrs\n");
            Console.Write("Enter no of working hours:  ");
            int emphrs = Convert.ToInt32(Console.ReadLine());
            if (emphrs == 8)
                Console.WriteLine("\nEmployee is working Full-time");
            else if (emphrs == 4)
                Console.WriteLine("\nEmployee is working Part-time");
            else
            {
                emphrs = 0;
                Console.WriteLine("\nEmployee is not working");
            }
            int Dailywage = emphrs * HOURWAGE; ;
            Console.WriteLine("\nEmployee's wage is: " + Dailywage);
        }
    }
}
