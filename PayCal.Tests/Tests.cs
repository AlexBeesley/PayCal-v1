using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

[TestFixture]
public class GetIDandDate_Test
{
    [Test]
    public void CheckGlobalVariables()
    {
        var sut = new DataTableNewEntry();
        Assert.False(sut.newPermBoo);
        Object[] varNames = {sut.newFName, sut.newLName, sut.newSalaryint, sut.newBonusint, 
                             sut.newBonusint, sut.newDayRateint, sut.newWeeksWorkedint};
        for (int i = 0; i < 6; i++)
        {
            Assert.Null(varNames[i]);
        }
    }

    [Test]
    public void CheckTableTypes()
    {
        var sut = new DataTableMain();
        sut.MakeTable();
        Object[] dtTypes = { typeof(string), typeof(Int32), typeof(bool), typeof(DBNull) };
        Assert.AreEqual(sut.table.Rows[0].ItemArray.Length, 8);

        for (int x = 0; x < 2; x++)
        {
            if (Convert.ToBoolean(sut.table.Rows[x].ItemArray.GetValue(3)) == true)
            {
                for (int i = 1; i < 7; i++)
                {
                    if (i == 1 || i == 2)
                    {
                        Assert.That(sut.table.Rows[x].ItemArray.GetValue(i), Is.TypeOf((Type)dtTypes[0]));
                    }
                    if (i == 3)
                    {
                        Assert.That(sut.table.Rows[x].ItemArray.GetValue(i), Is.TypeOf((Type)dtTypes[2]));
                    }
                    if (i == 4 || i == 5)
                    {
                        Assert.That(sut.table.Rows[x].ItemArray.GetValue(i), Is.TypeOf((Type)dtTypes[1]));
                    }
                    if (i == 6 || i == 7)
                    {
                        Assert.That(sut.table.Rows[x].ItemArray.GetValue(i), Is.TypeOf((Type)dtTypes[3]));
                    }
                }
            }

            else
            {
                for (int i = 1; i < 7; i++)
                {                    
                    if (i == 1 || i == 2)
                    {
                        Assert.That(sut.table.Rows[x].ItemArray.GetValue(i), Is.TypeOf((Type)dtTypes[0]));
                    }
                    if (i == 3)
                    {
                        Assert.That(sut.table.Rows[x].ItemArray.GetValue(i), Is.TypeOf((Type)dtTypes[2]));
                    }
                    if (i == 4 || i == 5)
                    {
                        Assert.That(sut.table.Rows[x].ItemArray.GetValue(i), Is.TypeOf((Type)dtTypes[3]));
                    }
                    if (i == 6 || i == 7)
                    {
                        Assert.That(sut.table.Rows[x].ItemArray.GetValue(i), Is.TypeOf((Type)dtTypes[1]));
                    }
                }
            }
        }
    }
}
