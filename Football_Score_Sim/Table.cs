using System.Security.Cryptography;

namespace Football_Score_Sim;



public static class Table
{
    public static void PrintTable()
    {
        Team t1 = new Team("F.C. København", "FCK");
        Team t2 = new Team("FC Nordsjælland", "FCN");
        Team t3 = new Team("Lyngby Boldklub", "LBK");
        Team t4 = new Team("Viborg FF", "VFF");
        Team t5 = new Team("AGF", "AGF");
        Team t6 = new Team("Randers FC", "RFC");
        Team t7 = new Team("Brøndby IF", "BIF");
        Team t8 = new Team("Silkeborg IF", "SIF");
        Team t9 = new Team("FC Midtjylland", "FCM");
        Team t10 = new Team("OB", "OB");
        Team t11 = new Team("AC Horsens", "ACH");
        Team t12 = new Team("AaB", "AAB");
        
        IEnumerable<Tuple<int, string, string>> authors =
            new[]
            {
                //read teams from table

                Tuple.Create(1, t1.Name, t1.Abbr),
                Tuple.Create(2, t2.Name, t2.Abbr),
                Tuple.Create(3, t3.Name, t3.Abbr),
                Tuple.Create(4, t4.Name, t4.Abbr),
                Tuple.Create(5, t5.Name, t5.Abbr),
                Tuple.Create(6, t6.Name, t6.Abbr),
                Tuple.Create(7, t7.Name, t7.Abbr),
                Tuple.Create(8, t8.Name, t8.Abbr),
                Tuple.Create(9, t9.Name, t9.Abbr),
                Tuple.Create(10, t10.Name, t10.Abbr),
                Tuple.Create(11, t11.Name, t11.Abbr),
                Tuple.Create(12, t12.Name, t12.Abbr),
            };

        Console.WriteLine(authors.ToStringTable(
            new[] { "Id", "name", "abbr" },
            a => a.Item1, a => a.Item2, a => a.Item3));



    }
}

  