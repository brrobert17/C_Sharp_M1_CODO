using System.ComponentModel;
using Football_Score_Sim;

Team t1 = new Team("F.C. København", "FCK",0,0,0,0,0,0,0,0);
Team t2 = new Team("FC Nordsjælland", "FCN",0,0,0,0,0,0,0,0);
Team t3 = new Team("Silkeborg IF", "S.I.F",0,0,0,0,0,0,0,0);
Team t4 = new Team("FC Midtjylland", "FCM",0,0,0,0,0,0,0,0);
Team t5 = new Team("Viborg FF", "VFF",0,0,0,0,0,0,0,0);
Team t6 = new Team("Brøndby IF", "BIF",0,0,0,0,0,0,0,0);
Team t7 = new Team("Randers FC", "RAN",0,0,0,0,0,0,0,0);
Team t8 = new Team("OB", "OB",0,0,0,0,0,0,0,0);
Team t9 = new Team("AC Horsens", "HOR",0,0,0,0,0,0,0,0);
Team t10 = new Team("AGF", "AGF",0,0,0,0,0,0,0,0);
Team t11 = new Team("Lyngby Boldklub", "LBY",0,0,0,0,0,0,0,0);
Team t12 = new Team("AaB", "AAB",0,0,0,0,0,0,0,0);
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
