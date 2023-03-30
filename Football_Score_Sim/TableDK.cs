
using System.Collections;
using System.Drawing;

namespace Football_Score_Sim;

public static class TableDK
{
    
    public static void PrintTable(League league)
    {
        List<Team> l1Teams = league.Teams;
        List<List<string>> tableLG = new List<List<string>>();
        
        // read teams from table
        foreach (var team in l1Teams)
        {
            List<string> row = new List<string>();
            row.Add(team.Position.ToString());
            row.Add(team.Name);
            row.Add(team.Abbr);
            row.Add(team.Matches.ToString());
            row.Add(team.Points.ToString());
            row.Add(team.Won.ToString());
            row.Add(team.Drawn.ToString());
            row.Add(team.Lost.ToString());
            row.Add(team.GoalsFor.ToString());
            row.Add(team.GoalsAgainst.ToString());
            row.Add(team.GoalDifference.ToString());
            row.Add(team.Streak);
            tableLG.Add(row);
        }
        Console.ForegroundColor = ConsoleColor.White;
        Console.BackgroundColor = ConsoleColor.Black;
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        /*green color*/
// Use a lambda expression to map position to color string





        Console.WriteLine(tableLG.ToStringTable(
            new[]
            {
                "Position", "Name", "Abbr", "Matches", "Points", "Won", "Drawn", "Lost", "GF", "GA", "GD", "Streak"
            },
            row => row[0].Equals("1") ? ConsoleColor.Green : ConsoleColor.White,
            row => row[1], row => row[2],
            row => row[3], row => row[4], row => row[5],
            row => row[6], row => row[7], row => row[8],
            row => row[9], row => row[10], row => row[11]
        ));

        Console.ResetColor();

            
            
            
        
             //display table alphabeticaly by team names ask user
        
        Console.WriteLine("Do you want to sort the table by team name? (y/n)");
        string answer = Console.ReadLine();
        if (answer == "y")
        {
            Console.WriteLine(tableLG.OrderBy(a => a[1]).ToStringTable(
                new[] { "Position", "Name", "Abbr", "Matches", "Points", "Won", "Drawn", "Lost", "GF", "GA", "GD", "Streak" },

                a => a[0], a => a[1], a => a[2],
                a => a[3], a => a[4], a => a[5],
                a => a[6], a => a[7], a => a[8],
                a => a[9], a => a[10], a => a[11]));

        }
        else
        {
            Console.WriteLine("Thank you for using the program");
        }
    }
}






       
        
        
                










  