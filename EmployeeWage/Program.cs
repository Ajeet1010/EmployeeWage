using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Employee Wage Problems  -----");
            Console.WriteLine("Calculating the monthly salary of Employee working in multiple companies\n");
            Multiple monthly1 = new Multiple();
            monthly1.Companies("HCL", 12, 10, 5);
            Multiple monthly2 = new Multiple();
            monthly2.Companies("Tata Motors", 25, 20, 30);
            Multiple monthly3 = new Multiple();
            monthly3.Companies("Wipro", 25, 30, 45);
        }
    }
}