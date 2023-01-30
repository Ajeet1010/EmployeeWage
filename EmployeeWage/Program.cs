using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Employee Wage Problems  -----");
            Console.WriteLine("Calculating Employee's Daily wage\n");
            DailyWage dailyWage = new DailyWage();
            dailyWage.Salary();
        }
    }
}