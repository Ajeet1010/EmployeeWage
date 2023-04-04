using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    // UC5: Calculating monthly wage of employee.
    internal class MonthlyWage
    {
        int HOURWAGE = 20, EMPHRS = 0;
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1, WORKING_DAYS = 20;

        public void Wage()
        {

            int totalEmphrs = 0, day = 1, empWage, totalEmpWage = 0;
            Random random = new Random();
            for (day = 1; day <= WORKING_DAYS; day++)
            {
                int empAttendance = random.Next(0, 3);
                switch (empAttendance)
                {
                    case IS_FULL_TIME:
                        EMPHRS = 8;
                        Console.WriteLine("\nEmployee is Full Time Present");
                        break;
                    case IS_PART_TIME:
                        EMPHRS = 4;
                        Console.WriteLine("\nEmployee is Part Time Present");
                        break;
                    default:
                        EMPHRS = 0;
                        Console.WriteLine("\nEmployee is Absent");
                        break;
                }
                empWage = EMPHRS * HOURWAGE;
                totalEmpWage = totalEmpWage + empWage;
                totalEmphrs = totalEmphrs + EMPHRS;
                Console.WriteLine("Employee Wage for day {0} is {1}", day, empWage);
            }
            Console.WriteLine("\nEmployee total working hours for {0} days is {1} ", (day - 1), totalEmphrs);
            Console.WriteLine("\nMonthly Wage for Employee for {0} days is {1} ", (day - 1), totalEmpWage);
        }
    }
}
