using System.ComponentModel;
using Football_Score_Sim;


League l1 = new League("Superliga");

CSVReader.ReadFile("csv/teams/l1-teams.csv", l1.AddTeam);
CSVReader.ReadDirectoryFiles("csv/s2022-2023", l1.AddMatch);

TableDK.PrintTable(l1);



