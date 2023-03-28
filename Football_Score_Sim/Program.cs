using System.ComponentModel;
using Football_Score_Sim;


League l1 = new League("Superliga");
CSVReader.ReadFile("csv/teams/l1-teams.csv", l1.AddTeam);
CSVReader.ReadDirectoryFiles("csv/s2022-2023", l1.AddMatch);

printOutResults();

void printOutResults()
{
    var lines = "-------";
    
    foreach (var team in l1.Teams)
    {
        Console.WriteLine(team.Position);
        Console.WriteLine(team.Name);
        Console.WriteLine(team.Abbr);
        Console.WriteLine(team.Points);
        Console.WriteLine(team.GoalDifference);
        Console.WriteLine(team.GoalsFor);
        Console.WriteLine(team.GoalsAgainst);
        Console.WriteLine(team.Matches);
        Console.WriteLine(team.Streak);
        Console.WriteLine(lines);
    }
}

/*Team t1 = new Team("F.C. København", "FCK");
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
l1Teams.Add(t12);*/

/*

l1.AddMatch("FCK", "FCN", 1, 1);
l1.AddMatch("AAB", "ACH", 1, 1);
l1.AddMatch("BIF", "RFC", 6, 3);
l1.AddMatch("FCM", "LBK", 0,4);
l1.AddMatch("OB", "VFF", 3,1);
l1.AddMatch("SIF", "AGF", 2,5);

l1.AddMatch("FCK", "FCN", 4, 2);
l1.AddMatch("AAB", "ACH", 3, 3);
l1.AddMatch("BIF", "RFC", 5, 2);
l1.AddMatch("FCM", "LBK", 3,1);
l1.AddMatch("OB", "VFF", 3,3);
l1.AddMatch("SIF", "AGF", 0,0);*/




