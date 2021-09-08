using System;
using System.Data;
public class DataTableNewEntry
{
    
    public string newFName;
    public string newLName;
    public bool newPermBoo = false;
    public int newSalaryint;
    public int newBonusint;
    public int newDayRateint;
    public int newWeeksWorkedint;

    public int IDCount = 3;
    public int Output;
    public bool commit = false;
    
        

    string[] Fields = { "Enter First Name:  ", "Enter Surname:  ", "Enter Salary (if applicable):  $", "Enter Bonus (if applicable):  $",
                        "Enter Day Rate (if applicable):  $", "Enter Weeks Worked (if applicable):  " };

    public void newEntry()
    {
        bool commitComplete = false;
        bool NELoopComplete = false;
        while (NELoopComplete == false)
        {
            Console.Clear();
            Console.WriteLine("\n------------------------------------------------- NEW EMPLOYEE ENTRY ------------------------------------------------");

            Console.Write(Fields[0]);
            newFName = Console.ReadLine();

            Console.Write(Fields[1]);
            newLName = Console.ReadLine();

            TypeConv();

            GetIntInputs();

            Console.WriteLine($"Data to inject:  {newFName} / {newLName} / {newPermBoo} / {newSalaryint} / {newBonusint} / {newDayRateint} / {newWeeksWorkedint}");
            
            while (commitComplete == false)
            {
                Console.Write("Confirm data is correct and fit for injection. [Y/n]  ");
                string confirm = Console.ReadLine();
                if (confirm == "Y" || confirm == "y" || confirm == "")
                {
                    IDCount++;
                    commit = true;
                    commitComplete = true;
                }
                if (confirm == "N" || confirm == "n")
                {
                    commitComplete = true;
                }
            }
            
            if (commit == true)
            {
                NELoopComplete = true;
            }

        }
        
    }

    public void GetIntInputs()
    {
        for (int i = 2; i < 6; i++)
        {
           Console.Write(Fields[i]);
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
        bool typeConvComplete = false;
        while (typeConvComplete  == false)
        {
            Console.WriteLine("Is Employment Permanent? [Y/N]  ");
            string newIsPerm = Console.ReadLine();
            if (newIsPerm == "Y" || newIsPerm == "y")
            {
                newPermBoo = true;
                typeConvComplete = true;
            }
            if (newIsPerm == "N" || newIsPerm == "n")
            {
                newPermBoo = false;
                typeConvComplete = true;
            }
            
        }
    }
}