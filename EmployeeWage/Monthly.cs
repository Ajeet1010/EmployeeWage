using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Monthly
    {
        const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;
        const int Hourwage = 20;
        const int Workingdays = 20;
        public void Wage()
        {
            int emphrs = 0, totalEmphrs = 0, day =1, empWage, totalEmpWage = 0;
            Random random = new Random();
            for (day = 1; day <= Workingdays; day++)
            {
                int empAttendance = random.Next(0, 3); 
                switch (empAttendance)
                {
                    case Is_Full_Time:
                        emphrs = 8;
                        Console.WriteLine("\nEmployee is Full Time Present");
                        break;
                    case Is_Part_Time:
                        emphrs = 4;
                        Console.WriteLine("\nEmployee is Part Time Present");
                        break;
                    default:
                        emphrs = 0;
                        Console.WriteLine("\nEmployee is Absent");
                        break;
                }
                empWage = emphrs * Hourwage;
                totalEmpWage = totalEmpWage + empWage;
                Console.WriteLine("Employee Wage for day {0} is {1}", day, empWage);
            }            
            Console.WriteLine("\nMonthly Wage for Employee for {0} days is {1} ", (day - 1), totalEmpWage);
        }
    }
}
