using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Employee Wage Problems  -----");
            Console.WriteLine("Calculating the monthly salary of Employee\n");
            Monthly monthly = new Monthly();
            monthly.Wage();
        }
    }
}