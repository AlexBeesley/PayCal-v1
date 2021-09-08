using System;
using System.Data;
public class DataTableNewEntry
{
    public bool newPermBoo = false;
    public string newFName;
    public string newLName;
    public int newSalaryint;
    public int newBonusint;
    public int newDayRateint;
    public int newWeeksWorkedint;
    public int IDCount = 3;
    public void newEntry()
    {
        //Console.Clear();
        Console.WriteLine("\n------------------------------------------------- NEW EMPLOYEE ENTRY ------------------------------------------------");
        
        Console.WriteLine("Enter First Name:  ");
        newFName = Console.ReadLine();

        Console.WriteLine("Enter Surname:  ");
        newLName = Console.ReadLine();

        TypeConv();

        while (true)
        {
            Console.WriteLine("Enter Salary (if applicable):  $");
            string newSalary = Console.ReadLine();
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
            bool valid = int.TryParse(newBonus, out newBonusint);
            if (valid)
            {
                Console.WriteLine("Vaild, Bonus set to: $" + newBonusint);
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
            bool valid = int.TryParse(newDayRate, out newDayRateint);
            if (valid)
            {
                Console.WriteLine("Vaild, Day Rate set to: $" + newDayRateint);
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
            bool valid = int.TryParse(newWeeksWorked, out newWeeksWorkedint);
            if (valid)
            {
                Console.WriteLine("Vaild, Weeks Worked set to:  " + newWeeksWorkedint);
                break;
            }
            else
            {
                Console.WriteLine("invaild input.");
            }
        }
        Console.WriteLine($"Data to inject from NE:  {newFName} / {newLName} / {newPermBoo} / {newSalaryint} / {newBonusint} / {newDayRateint} / {newWeeksWorkedint}");
        IDCount++;
    }
    
    public void TypeConv()
    {
        
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