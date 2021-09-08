using System;
using System.Data;

public class DataTableMain
{
    public DataTable table = new DataTable();
    public DataTableNewEntry ne = new DataTableNewEntry();
    
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

    public void PrintTable()
    {
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
    }
}