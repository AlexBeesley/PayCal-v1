using System;
using System.Data;
public class DataTableNewEntry
{
    public void newEntry()
    {
        Console.Clear();
        Console.WriteLine("\n------------------------------------------------- NEW EMPLOYEE ENTRY ------------------------------------------------");
        Console.WriteLine("Enter First Name:  ");
        string newFName = Console.ReadLine();

        Console.WriteLine("Enter Surname:  ");
        string newLName = Console.ReadLine();

        TypeConv();

        while (true)
        {
            Console.WriteLine("Enter Salary (if applicable):  $");
            string newSalary = Console.ReadLine();
            int newSalaryint;
            bool valid = int.TryParse(newSalary, out newSalaryint);
            if (valid)
            {
                Console.WriteLine("Vaild, Salary set to: $" + newSalaryint);
                break;
            }
            else
            {
                Console.WriteLine("invaild input.");
            }
        }

        while (true)
        {
            Console.WriteLine("Enter Bonus (if applicable):  $");
            string newBonus = Console.ReadLine();
            int newBonusint;
            bool valid = int.TryParse(newBonus, out newBonusint);
            if (valid)
            {
                Console.WriteLine("Vaild, Salary set to: $" + newBonusint);
                break;
            }
            else
            {
                Console.WriteLine("invaild input.");
            }
        }

        while (true)
        {
            Console.WriteLine("Enter Day Rate (if applicable):  $");
            string newDayRate = Console.ReadLine();
            int newDayRateint;
            bool valid = int.TryParse(newDayRate, out newDayRateint);
            if (valid)
            {
                Console.WriteLine("Vaild, Salary set to: $" + newDayRateint);
                break;
            }
            else
            {
                Console.WriteLine("invaild input.");
            }
        }

        while (true)
        {
            Console.WriteLine("Enter Weeks Worked (if applicable):  ");
            string newWeeksWorked = Console.ReadLine();
            int newWeeksWorkedint;
            bool valid = int.TryParse(newWeeksWorked, out newWeeksWorkedint);
            if (valid)
            {
                Console.WriteLine("Vaild, Salary set to: $" + newWeeksWorkedint);
                break;
            }
            else
            {
                Console.WriteLine("invaild input.");
            }
        }
    }

    public void TypeConv()
    {
        var newPermBoo = false;
        while (true)
        {
            Console.WriteLine("Is Employment Permanent? [Y/N]  ");
            string newIsPerm = Console.ReadLine();
            if (newIsPerm == "Y" || newIsPerm == "y")
            {
                newPermBoo = true;
                break;
            }
            if (newIsPerm == "N" || newIsPerm == "n")
            {
                newPermBoo = false;
                break;
            }
            
        }
        Console.WriteLine("BOOLEAN SET TO:  " + newPermBoo);
    }
}

