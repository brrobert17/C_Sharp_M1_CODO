namespace Football_Score_Sim;
using ConsoleTables;


public static class Table
{
    public static void ShowTable(List<Team> teams)
    {
        Console.WriteLine("League Table");
        // Creat table 
        
        var table = new ConsoleTable("Team", "MP", "W", "D", "L", "GF", "GA", "GD", "Pts");
        // Sort teams by points
        teams.Sort((x, y) => y.Points.CompareTo(x.Points));
        // Add teams to table
        foreach (var team in teams)
        {
            table.AddRow(team.Name, team.Matches, team.Won, team.Drawn, team.Lost, team.GoalsFor, team.GoalsAgainst, team.GoalDifference, team.Points);
        }
        // Show table
        table.Write();

    }

    
    }