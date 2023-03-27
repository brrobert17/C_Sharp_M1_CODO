using System.ComponentModel;
using Football_Score_Sim;

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

using(var reader = new StreamReader(@"C:\Users\sfatt\OneDrive\Desktop\java class homework\semister4\c#\Firstcsharp\C_Sharp_M1_CODO\Football_Score_Sim\scores\s2022-2023\r1.csv"))
{
    while (!reader.EndOfStream)
    {
        var line = reader.ReadLine();
        var values = line.Split(',');
        l1.AddMatch(values[0], values[1], Convert.ToByte(values[2]), Convert.ToByte(values[3]));
    }
}

/*var lines = "-------";*/

//l1.AddMatch("FCK", "FCN", 11, 8);

 //Console.WriteLine(l1.Teams[2].Name);
// Console.WriteLine(l1.Teams[2].Points);
// Console.WriteLine(l1.Teams[2].GoalsFor);
// Console.WriteLine(l1.Teams[2].GoalsAgainst);
// Console.WriteLine(l1.Teams[2].GoalDifference);
// Console.WriteLine(l1.Teams[2].Matches);
// Console.WriteLine(lines);
// Console.WriteLine(l1.Teams[3].Name);
// Console.WriteLine(l1.Teams[3].Points);
// Console.WriteLine(l1.Teams[3].GoalsFor);
// Console.WriteLine(l1.Teams[3].GoalsAgainst);
// Console.WriteLine(l1.Teams[3].GoalDifference);
// Console.WriteLine(l1.Teams[3].Matches);
 TableDK.PrintTable(l1);

// l1.AddMatch("FCK", "FCN", 10, 10);
//
// Console.WriteLine(l1.Teams[2].Name);
// Console.WriteLine(l1.Teams[2].Points);
// Console.WriteLine(l1.Teams[2].GoalsFor);
// Console.WriteLine(l1.Teams[2].GoalsAgainst);
// Console.WriteLine(l1.Teams[2].GoalDifference);
// Console.WriteLine(l1.Teams[2].Matches);
// Console.WriteLine(lines);
// Console.WriteLine(l1.Teams[3].Name);
// Console.WriteLine(l1.Teams[3].Points);
// Console.WriteLine(l1.Teams[3].GoalsFor);
// Console.WriteLine(l1.Teams[3].GoalsAgainst);
// Console.WriteLine(l1.Teams[3].GoalDifference);
// Console.WriteLine(l1.Teams[3].Matches);