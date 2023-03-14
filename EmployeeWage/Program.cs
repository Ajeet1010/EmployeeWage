namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Employee Wage Problems  *****\n");
            DailyWage dailyWage = new DailyWage();
            dailyWage.Salary();
        }
    }
}