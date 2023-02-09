using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Multiple
    {
        const int Is_Full_Time = 1;
        const int Is_Part_Time = 2;
        public void Companies(string company, int hourwage, int workingdays, int workinghrs)
        {
            int emphrs = 0, totalEmphrs = 0, day =1, empWage, totalEmpWage = 0;
            Random random = new Random();
            while (day <= workingdays && totalEmphrs <= workinghrs)
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
                empWage = emphrs * hourwage;
                totalEmpWage = totalEmpWage + empWage;
                //Console.WriteLine("Employee Wage for day {0} is {1} and working hours is {2}", day, empWage, totalEmphrs);
                day++;
                totalEmphrs = totalEmphrs + emphrs;
            }            
            Console.WriteLine("\nMonthly Wage for Employee working in {0} for {1} days and total working hours is {2} and salary will be {3}", company, (day - 1),
                totalEmphrs, totalEmpWage);
        }
    }
}
