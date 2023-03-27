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
        var l1Teams = new List<Team>();
        l1Teams.Add(t1);
        l1Teams.Add(t2);
        l1Teams.Add(t3);
        l1Teams.Add(t4);
        l1Teams.Add(t5);
        l1Teams.Add(t6);
        l1Teams.Add(t7);
        l1Teams.Add(t8);
        l1Teams.Add(t9);
        l1Teams.Add(t10);
        l1Teams.Add(t11);
        l1Teams.Add(t12);
        League l1 = new League("Superliga", l1Teams);
        
        IEnumerable<Tuple<int, string, string>> tableLG =
            new[]
            {
                //read teams from table

                Tuple.Create(1, l1Teams[0].Name, l1Teams[0].Abbr),
                Tuple.Create(2, l1Teams[1].Name, l1Teams[1].Abbr),
                Tuple.Create(3, l1Teams[2].Name, l1Teams[2].Abbr),
                Tuple.Create(4, l1Teams[3].Name, l1Teams[3].Abbr),
                Tuple.Create(5, l1Teams[4].Name, l1Teams[4].Abbr),
                Tuple.Create(6, l1Teams[5].Name, l1Teams[5].Abbr),
                Tuple.Create(7, l1Teams[6].Name, l1Teams[6].Abbr),
                Tuple.Create(8, l1Teams[7].Name, l1Teams[7].Abbr),
                Tuple.Create(9, l1Teams[8].Name, l1Teams[8].Abbr),
                Tuple.Create(10, l1Teams[9].Name, l1Teams[9].Abbr),
                Tuple.Create(11, l1Teams[10].Name, l1Teams[10].Abbr),
                Tuple.Create(12, l1Teams[11].Name, l1Teams[11].Abbr),



            };

        Console.WriteLine(tableLG.ToStringTable(
            new[] { "Id", "name", "abbr" },
            a => a.Item1, a => a.Item2, a => a.Item3
            
        ));
        
        
        //desplay by alphabetical order ask user for input
        Console.WriteLine("Sort by alphabetical order? (y/n)");
        var input = Console.ReadLine();
        if (input == "y")
        {
            Console.WriteLine(tableLG.OrderBy(a => a.Item2).ToStringTable(
                new[] { "Id", "name", "abbr" },
                a => a.Item1, a => a.Item2, a => a.Item3));
        }
        else
        {
            Console.WriteLine(tableLG.ToStringTable(
                new[] { "Id", "name", "abbr" },
                a => a.Item1, a => a.Item2, a => a.Item3));
        }
       
        
        
                










    }
}

  