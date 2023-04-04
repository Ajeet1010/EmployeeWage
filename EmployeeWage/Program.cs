using System.Runtime;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Employee Wage Problems  *****\n");
            Console.Write("1. Employee Attendance\n2. DailyWage\n3. Working type.\n4. SwitchCase.\n5. Monthly wage.\n6. Refactor Method.\nEnter your choice:  ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Check whether employee is present or absent");
                    Attendance attendance = new Attendance();
                    attendance.PreAbs();
                    break;

                case 2:
                    Console.WriteLine("Calculating Employee's wage on daily basis.");
                    DailyWage daily = new DailyWage();
                    daily.Salary();
                    break;

                case 3:
                    Console.WriteLine("Checking whether Employee is working full-time or part-time basis.");
                    Employement emp =   new Employement();
                    emp.Wage();
                    break;
                case 4:
                    Console.WriteLine("Using SWITCH CASE checking whether Employee is working full-time or part-time basis");
                    SwitchCase switchCase = new SwitchCase();
                    switchCase.SwitchWage();
                    break; 
                case 5:
                    Console.WriteLine("Calculating monthly wage of employee.");
                    MonthlyWage monthly = new MonthlyWage();
                    monthly.Wage();
                    break;

                case 6 & 7:
                    Console.WriteLine("");
                    RefactorMethod conditionHrs = new RefactorMethod();
                    conditionHrs.Wage();
                    break;
                default:
                    Console.WriteLine("Enter correct choice");
                    break;
            }
        }
    }
}