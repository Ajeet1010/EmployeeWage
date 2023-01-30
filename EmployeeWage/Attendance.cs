using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Attendance
    {
        public void Employee()
        {
            Random random = new Random();
            int empAttendence = random.Next(0, 2);//0 or 1
            if (empAttendence == 0)
            {
                Console.WriteLine("Employee is Present");
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
        }
    }
}
