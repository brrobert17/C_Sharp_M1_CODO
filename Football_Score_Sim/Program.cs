using System.ComponentModel;
using Football_Score_Sim;

Team t1 = new Team("F.C. København", "FCK",0,0,0,0,0,0,0,0);
Team t2 = new Team("FC Nordsjælland", "FCN",0,0,0,0,0,0,0,0);
Team t3 = new Team("Lyngby Boldklub", "LBK",0,0,0,0,0,0,0,0);
Team t4 = new Team("Silkeborg IF", "SIF",0,0,0,0,0,0,0,0);

var l1Teams = new List<Team>();
l1Teams.Add(t1);
l1Teams.Add(t2);
l1Teams.Add(t3);
l1Teams.Add(t4);

League l1 = new League("Superliga", l1Teams);

Console.WriteLine(t1.Name);
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
}
Console.WriteLine(t1.Name + t1.Matches);
