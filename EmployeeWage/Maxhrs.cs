using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Maxhrs
    {
        const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;
        const int Hourwage = 20;
        const int Workingdays = 20;
        const int maxhrs = 100;
        public void Wage()
        {
            int emphrs = 0, totalEmphrs = 0, day =1, empWage, totalEmpWage = 0;
            Random random = new Random();
            while (day <= Workingdays && totalEmphrs <= maxhrs)
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
                Console.WriteLine("Employee Wage for day {0} is {1} and working hours is {2}", day, empWage, totalEmphrs);
                day++;
                if (day < 21)
                    totalEmphrs = totalEmphrs + emphrs;
                else
                    totalEmphrs = totalEmphrs;
            }            
            Console.WriteLine("\nMonthly Wage for Employee for {0} days is {1} and total working hours in month is {2}", (day - 1), totalEmpWage, totalEmphrs);
        }
    }
}
