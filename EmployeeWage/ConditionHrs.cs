using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    // UC6: Calculating monthly wage of employee until it reaches condition for total 100 hrs or 20 days.
    internal class ConditionHrs
    {
        int HOURWAGE = 20;
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1, WORKING_DAYS = 20, MAX_HRS = 100;

        public void Wage()
        {

            int totalEmphrs = 0, empWage, totalEmpWage = 0, totaldays =20, EMPHRS;
            while(totaldays <= 20 || totalEmphrs < MAX_HRS)
            {
                Random random = new Random();
                int empAttendance = random.Next(0, 3);
                totaldays++;
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

                totalEmphrs = totalEmphrs + EMPHRS;
                totalEmpWage = totalEmphrs * HOURWAGE;
                Console.WriteLine("Employee total working hours is: {0} and wage is {1} for days {2}", totalEmphrs, totalEmpWage, totaldays);
            }            
            
        }
    }
}
