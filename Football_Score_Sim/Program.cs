using System.ComponentModel;
using Football_Score_Sim;

Team t1 = new Team("F.C. København", "FCK");
Team t2 = new Team("FC Nordsjælland", "FCN");
Team t3 = new Team("Lyngby Boldklub", "LBK");
Team t4 = new Team("Silkeborg IF", "SIF");

var l1Teams = new List<Team>();
l1Teams.Add(t1);
l1Teams.Add(t2);
l1Teams.Add(t3);
l1Teams.Add(t4);

League l1 = new League("Superliga", l1Teams);

/*Console.WriteLine(t1.Name);
Console.WriteLine(t2.Name);
using(var reader = new StreamReader("scores.csv"))
{
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var values = line.Split(',');
        foreach (var team in l1.Teams)
        {
            // if (team.Abbr.Equals(values[0]))
            // {
            //     team.Matches = team.Matches + 1;
            // }

        }

        Console.WriteLine(values[0]+ " - " + values[1] + " " + values[2] + ":" + values[3]);
        
    }
}*/
// Console.WriteLine(t1.Name + t1.Matches);

l1.AddMatch("FCK", "FCN", 11, 8);

Console.WriteLine(l1.Teams[2].Name);
Console.WriteLine(l1.Teams[2].Points);
Console.WriteLine(l1.Teams[2].GoalsFor);
Console.WriteLine(l1.Teams[2].GoalsAgainst);
Console.WriteLine(l1.Teams[2].GoalDifference);
Console.WriteLine(l1.Teams[2].Matches);
Console.WriteLine("-------");
Console.WriteLine(l1.Teams[3].Name);
Console.WriteLine(l1.Teams[3].Points);
Console.WriteLine(l1.Teams[3].GoalsFor);
Console.WriteLine(l1.Teams[3].GoalsAgainst);
Console.WriteLine(l1.Teams[3].GoalDifference);
Console.WriteLine(l1.Teams[3].Matches);

l1.AddMatch("FCK", "FCN", 10, 10);

Console.WriteLine(l1.Teams[2].Name);
Console.WriteLine(l1.Teams[2].Points);
Console.WriteLine(l1.Teams[2].GoalsFor);
Console.WriteLine(l1.Teams[2].GoalsAgainst);
Console.WriteLine(l1.Teams[2].GoalDifference);
Console.WriteLine(l1.Teams[2].Matches);
Console.WriteLine("-------");
Console.WriteLine(l1.Teams[3].Name);
Console.WriteLine(l1.Teams[3].Points);
Console.WriteLine(l1.Teams[3].GoalsFor);
Console.WriteLine(l1.Teams[3].GoalsAgainst);
Console.WriteLine(l1.Teams[3].GoalDifference);
Console.WriteLine(l1.Teams[3].Matches);