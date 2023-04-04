using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWage
{
    internal class Attendance
    {
        public void PreAbs()
        {
            Random random = new Random();
            int empAttendance = random.Next(0, 2);

            if (empAttendance == 0)
                Console.WriteLine("Employee is Present");
            else
                Console.Write("Employee is Absent");
        }
    }
}
