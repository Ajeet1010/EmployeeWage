using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    // UC7: Calculating monthly for refactor method code.
    internal class RefactorMethod
    {
        int HOURWAGE = 20;
        const int IS_FULL_TIME = 0, IS_PART_TIME = 1, WORKING_DAYS = 20, MAX_HRS = 100;

        public void Wage()
        {

            int totalEmphrs = 0, empWage, totalEmpWage = 0, totaldays =20, EMPHRS;
            while(totaldays <= WORKING_DAYS && totalEmphrs < MAX_HRS)
            {
                Random random = new Random();
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
                totalEmphrs = totalEmphrs + EMPHRS;
                totalEmpWage = totalEmphrs * HOURWAGE;
            }
            totaldays++;

            Console.WriteLine("Employee total working hours is: {0} and wage is {1} for days {2}", totalEmphrs, totalEmpWage, totaldays-1);
        }
    }

    //   public static int computeEmpWage()
    //{
    //    int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
    //    while (totalEmpHrs <= Max_Hrs_In_Month && totalWorkingDays < Num_Of_Working_Days)
    //    {
    //        totalWorkingDays++;
    //        Random random = new Random();
    //        int check = random.Next(0, 3);
    //        switch (check)
    //        {
    //            case Full_Time:
    //                empHrs = 8;
    //                break;
    //            case Part_Time:
    //                empHrs = 4;
    //                break;
    //            default:
    //                empHrs = 0;
    //                break;
    //        }
    //        totalEmpHrs = totalEmpHrs + empHrs;
    //        Console.WriteLine("Day: " + totalWorkingDays + " Emp Hrs : " + empHrs);
    //    }
    //    int totalEmpWage = totalEmpHrs * HRSwage
    //        ;
    //    Console.WriteLine("Total Employee Wages : " + totalEmpWage);
    //    return totalEmpWage;
    }
