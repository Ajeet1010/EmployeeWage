namespace EmployeeWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****  Employee Wage Problems  *****\n");
            Monthlywage monthlywage = new Monthlywage();
            monthlywage.Wage();
        }
    }
}