namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Employee Wage Problems  *****\n");
            RefactorMethod conditionHrs = new RefactorMethod();
            conditionHrs.Wage();
        }
    }
}