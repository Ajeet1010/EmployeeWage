using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Employee Wage Problems  -----");
            Console.WriteLine("Calculating the monthly salary of Employee\n");
            Maxhrs monthly = new Maxhrs();
            monthly.Wage();
        }
    }
}