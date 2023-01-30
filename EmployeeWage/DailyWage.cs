using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class DailyWage
    {
        public void Salary()
        {
            int Hourwage = 20;
            Console.WriteLine("Enter the no of hours employee worked");
            int work = Convert.ToInt32(Console.ReadLine());
            int wage = work * Hourwage;
            Console.WriteLine("Employee's today wage : " + wage);
        }
    }
}
