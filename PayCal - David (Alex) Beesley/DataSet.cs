using System;
using System.Data;

public class DataTableMain
{
    public DataTable table = new DataTable();
    public DataTableNewEntry ne = new DataTableNewEntry();

    public object getEmplymentStatus;
    public object getSalary;
    public object getBonus;
    public object getDayRate;
    public object getWeeksWorked;

    public int selectedID;
    public int Output;


    public DataTable MakeTable()
    {    
        table.Columns.Add("ID", typeof(int));
        table.Columns.Add("First Name", typeof(string));
        table.Columns.Add("Surname", typeof(string));
        table.Columns.Add("Permanent?", typeof(bool));
        table.Columns.Add("Salary", typeof(int));
        table.Columns.Add("Bonus", typeof(int));
        table.Columns.Add("Day Rate", typeof(int));
        table.Columns.Add("Weeks Worked", typeof(int));

        table.Rows.Add(1, "Joe", "Bloggs", true, 40000, 5000, null, null);
        table.Rows.Add(2, "John", "Smith", true, 45000, 2500, null, null);
        table.Rows.Add(3, "Clare", "Jones", false, null, null, 350, 40);

        return table;
    }
    //public void GetEntry()
    //{
    //    Console.WriteLine("from get entry: " + selectedID);
    //    Console.WriteLine(table.Columns[1].ColumnName + ":  " + table.Rows[selectedID].ItemArray.GetValue(1));
    //    object getSalary = table.Rows[selectedID].ItemArray.GetValue(4);
    //    object getBonus = table.Rows[selectedID].ItemArray.GetValue(5);
    //    object getDayRate = table.Rows[selectedID].ItemArray.GetValue(6);
    //    object getWeeksWorked = table.Rows[selectedID].ItemArray.GetValue(7);
    //    //int AnnualPay = Convert.ToInt32(getBonus) + Convert.ToInt32(getSalary);
    //    //Console.WriteLine("Salary is:  " + getSalary);
    //    //Console.WriteLine("Total Annual pay is:  " + AnnualPay);
    //}

    public void GetIDandData()
    {
        Console.Clear();
        Console.WriteLine("\n----------------------------------------------- Calculate Annual Pay ------------------------------------------------");
        PrintTable();
        Console.Write("Select ID of Employee:  ");
        string Input = Console.ReadLine();
        bool valid = int.TryParse(Input, out Output);
        if (valid)
        {
            selectedID = Output;
            selectedID = selectedID - 1;
            object getEmploymentStatus = table.Rows[selectedID].ItemArray.GetValue(3);
            object getSalary = table.Rows[selectedID].ItemArray.GetValue(4);
            object getBonus = table.Rows[selectedID].ItemArray.GetValue(5);
            object getDayRate = table.Rows[selectedID].ItemArray.GetValue(6);
            object getWeeksWorked = table.Rows[selectedID].ItemArray.GetValue(7);

            bool CheckID = (selectedID <= ne.IDCount);
            if (CheckID)
            {
                Console.WriteLine("Employee Name:  " + table.Rows[selectedID].ItemArray.GetValue(1) + " " + table.Rows[selectedID].ItemArray.GetValue(2));
                if (Convert.ToBoolean(getEmploymentStatus) == true)
                {
                    int AnnualPay = Convert.ToInt32(getBonus) + Convert.ToInt32(getSalary);
                    Console.WriteLine("Salary is:  $" + getSalary);
                    Console.WriteLine("Bonus is:  $" + getBonus);
                    Console.WriteLine("Total Annual pay is:  $" + AnnualPay);
                }
                else
                {
                    int PartTimePay = Convert.ToInt32(getDayRate) * 5 * Convert.ToInt32(getWeeksWorked);
                    Console.WriteLine("DayRate is:  $" + getDayRate);
                    Console.WriteLine("Weeks Worked is:  " + getWeeksWorked);
                    Console.WriteLine("Total Annual pay is:  $" + PartTimePay);
                }
            }
            else
            {
                Console.WriteLine("Invaild ID.");
            }

        }
        else
        {
            Console.WriteLine("Invaild ID.");
        }
    }

    public void PrintTable()
    {
        Console.Clear();
        Console.WriteLine("\n");
        foreach (DataRow dr in table.Rows)
        {
            Console.Write("ID:{0,-3} First Name:{1,-5} Surname:{2,-8} Permanent?:{3,-6} Salary:{4,-5} Bonus:{5,-5} Day Rate:{6,-5} Weeks Worked:{7,-5}"
            , dr["ID"], dr["First Name"], dr["Surname"], dr["Permanent?"], dr["Salary"], dr["Bonus"], dr["Day Rate"], dr["Weeks Worked"]);
        }
        Console.WriteLine("\n");
    }


    public void NewDataInjection()
    {
        ne.newEntry();
        Console.WriteLine($"Data to inject from NE:  {ne.newFName} / {ne.newLName} / {ne.newPermBoo} / {ne.newSalaryint} / {ne.newBonusint} / {ne.newDayRateint} / {ne.newWeeksWorkedint}");
        table.Rows.Add(ne.IDCount, ne.newFName, ne.newLName, ne.newPermBoo, ne.newSalaryint, ne.newBonusint, ne.newDayRateint, ne.newWeeksWorkedint);

        ne.newSalaryint = null;
        ne.newBonusint = null;
        ne.newDayRateint = null;
        ne.newWeeksWorkedint = null;
    }
}