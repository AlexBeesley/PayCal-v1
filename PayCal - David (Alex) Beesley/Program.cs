using System;
namespace PayCal
{
    public class MainThread
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the PayCal System, a Salary Calculator.");
            DataTableMain dt = new DataTableMain();
            dt.MakeTable();
            dt.PrintTable();
        }
    }
}
