using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Employee Wage Problems  -----");
            Console.WriteLine("Checking employee is working part-time or full-time\n");
            Employement employement = new Employement();
            employement.Wage();
        }
    }
}