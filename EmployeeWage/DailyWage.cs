using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    // UC2: Calculating Employee's wage on daily basis.
    internal class DailyWage
    {
        public void Salary()
        {
            int HOURWAGE = 20;
            Console.Write("Enter the no of hours employee worked today:  ");
            int work = Convert.ToInt32(Console.ReadLine());
            int wage = work * HOURWAGE;
            Console.WriteLine("\nEmployee today's wage : " + wage);
        }
    }
}
