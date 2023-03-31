using System.ComponentModel;
using Football_Score_Sim;


League l1 = new League("Superliga");

CSVReader.ReadFile(@"C:\Users\sfatt\OneDrive\Desktop\java class homework\semister4\c#\Firstcsharp\C_Sharp_M1_CODO\Football_Score_Sim\csv\teams\l1-teams.csv", l1.AddTeam);
CSVReader.ReadDirectoryFiles(@"C:\Users\sfatt\OneDrive\Desktop\java class homework\semister4\c#\Firstcsharp\C_Sharp_M1_CODO\Football_Score_Sim\csv\s2022-2023", l1.AddMatch);

TableDK.PrintTable(l1);
TableDK.PrintTable(l1.Teams);



