using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Employee Wage Problems  -----");
            Console.WriteLine("Checking employee is working part-time or full-time using Switch statement\n");
            SwitchCase switchCase = new SwitchCase();
            switchCase.Wage();
        }
    }
}