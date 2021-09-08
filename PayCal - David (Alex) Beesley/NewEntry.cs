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
    public int Output;
    public bool commit = true;

    string[] Fields = { "Enter First Name:  ", "Enter Surname:  ", "Enter Salary (if applicable):  $", "Enter Bonus (if applicable):  $",
                        "Enter Day Rate (if applicable):  $", "Enter Weeks Worked (if applicable):  " };

    public void newEntry()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------------------------- NEW EMPLOYEE ENTRY ------------------------------------------------");

            Console.WriteLine(Fields[0]);
            newFName = Console.ReadLine();

            Console.WriteLine(Fields[1]);
            newLName = Console.ReadLine();

            TypeConv();

            GetIntInputs();

            Console.WriteLine($"Data to inject:  {newFName} / {newLName} / {newPermBoo} / {newSalaryint} / {newBonusint} / {newDayRateint} / {newWeeksWorkedint}");
            
            while (true)
            {
                Console.WriteLine("Confirm data is correct and fit for injection. [Y/n]  ");
                string confirm = Console.ReadLine();
                if (confirm == "Y" || confirm == "y" || confirm == "")
                {
                    IDCount++;
                    commit = false;
                    break;
                }
                if (confirm == "N" || confirm == "n")
                {
                    break;
                }
            }
            
            if (commit == false)
            {
                break;
            }

        }
        
    }

    public void GetIntInputs()
    {
        for (int i = 2; i < 6; i++)
        {
           Console.WriteLine(Fields[i]);
            string Input = Console.ReadLine();
            bool valid = int.TryParse(Input, out Output);
            if (valid)
            {
                if (i == 2) //Salary
                {
                    Console.WriteLine("Vaild, Salary set to: $" + Output);
                    newSalaryint = Output;
                }
                if (i == 3) //Bonus
                {
                    Console.WriteLine("Vaild, Bonus set to: $" + Output);
                    newBonusint = Output;
                }
                if (i == 4) //Day Rate
                {
                    Console.WriteLine("Vaild, Day Rate set to: $" + Output);
                    newDayRateint = Output;
                }
                if (i == 5) //Weeks Worked
                {
                    Console.WriteLine("Vaild, Weeks Worked set to:  " + Output);
                    newWeeksWorkedint = Output;
                }
            }
           
            else
            {
                Console.WriteLine("invaild input.");
            }
        }
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
    }

    


}