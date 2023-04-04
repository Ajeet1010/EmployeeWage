namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Employee Wage Problems  *****\n");
            ConditionHrs conditionHrs = new ConditionHrs();
            conditionHrs.Wage();
        }
    }
}