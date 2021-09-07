using System;
using System.Data;

public class DataTableMain
{
    public DataTable table = new DataTable();
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
            int x = 0;
            for (int i = 0; i < 8; i++)
            {
                Console.WriteLine(table.Columns[i].ColumnName + ":  " + table.Rows[x].ItemArray.GetValue(i));
                if (i == 4)
                {
                    x++;
                    if (x == 3)
                    {
                        break;
                    }
                    i = -1;
                }
                Console.WriteLine("\n");
            }
    }

}