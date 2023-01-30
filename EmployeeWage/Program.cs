using System;

namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----  Employee Wage Problems  -----");
            Console.WriteLine("Employee is Present or Absent");
            Attendance attendance= new Attendance();
            attendance.Employee();
        }
    }
}