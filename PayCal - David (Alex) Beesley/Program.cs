using System;
namespace PayCal
{
    public class MainThread
    {

        static void Main(string[] args)
        {
            Console.SetWindowSize(117,50);
            Console.WriteLine("Welcome to the PayCal System, a Salary Calculator.");
            Console.WriteLine("");

            DataTableMain dt = new DataTableMain();
            DataTableNewEntry ne = new DataTableNewEntry();
            
            dt.MakeTable();

            while (true)
            {
                Console.WriteLine(@"
Please Select from the following options:
Display Employee Information --------------------------------------------------------------------------------- 1
Add new Employee --------------------------------------------------------------------------------------------- 2");
                Console.WriteLine(">>>  ");
                string Selection = Console.ReadLine();
                if (Selection == "1")
                {
                    dt.PrintTable();
                }
                if (Selection == "2")
                {
                    dt.NewDataInjection();
                }
            }
        }
    }
}
