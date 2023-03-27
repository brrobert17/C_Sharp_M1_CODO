using System.Security.Cryptography;

namespace Football_Score_Sim;



public static class TableDK
{
    public static void PrintTable(League league)
    {

        List<Team> l1Teams = league.Teams;
        IEnumerable<Tuple< int, string, string,int,int,int,int>> tableLG =
            new[]
            {
                //read teams from table

                Tuple.Create(l1Teams[0].Position, l1Teams[0].Name, l1Teams[0].Abbr,
                    l1Teams[0].Matches,l1Teams[0].Points,l1Teams[0].Won,
                    l1Teams[0].Drawn)
                /*Tuple.Create(2, l1Teams[1].Name, l1Teams[1].Abbr),
                Tuple.Create(3, l1Teams[2].Name, l1Teams[2].Abbr),
                Tuple.Create(4, l1Teams[3].Name, l1Teams[3].Abbr),
                Tuple.Create(5, l1Teams[4].Name, l1Teams[4].Abbr),
                Tuple.Create(6, l1Teams[5].Name, l1Teams[5].Abbr),
                Tuple.Create(7, l1Teams[6].Name, l1Teams[6].Abbr),
                Tuple.Create(8, l1Teams[7].Name, l1Teams[7].Abbr),
                Tuple.Create(9, l1Teams[8].Name, l1Teams[8].Abbr),
                Tuple.Create(10, l1Teams[9].Name, l1Teams[9].Abbr),
                Tuple.Create(11, l1Teams[10].Name, l1Teams[10].Abbr),
                Tuple.Create(12, l1Teams[11].Name, l1Teams[11].Abbr),*/



            };

        Console.WriteLine(tableLG.ToStringTable(
            new[] { "Position", "Name", "Abbr", "Matches", "Points", "Won", "Drawn" },
            a => a.Item1, a => a.Item2, a => a.Item3,
            a => a.Item4, a => a.Item5, a => a.Item6,
            a=> a.Item7
            ));
        
        
        //desplay by alphabetical order ask user for input
        /*Console.WriteLine("Sort by alphabetical order? (y/n)");
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
        }*/
       
        
        
                










    }
}

  