using System.ComponentModel;
using Football_Score_Sim;

// var season = "";
// while (season.Equals("") || season.Equals(null))
// {
//     Console.WriteLine("Which season would you like to run? (yyyy-yyyy)");
//     season = Console.ReadLine();
// }
// if (season.Equals(null) || season.Equals(""))
// {
//     Console.WriteLine("Which season would you like to run? (yyyy-yyyy)");
//     Console.WriteLine("please use the correct format!");
// }

League l1 = new League();

CSVReader.ReadLeagueFile("csv/setups/setup1.csv", l1.LeagueSetup);
CSVReader.ReadFile("csv/teams/l1-teams.csv", l1.AddTeam);

CSVReader.ReadDirectoryRounds("csv/s2022-2023", l1.AddMatch, () => TableDK.PrintTable(l1));

l1.CalculateFractions();

CSVReader.ReadDirectoryRounds("csv/s2022-2023/fraction-rounds", l1.AddMatch,
    () =>
    {
        TableDK.PrintTable(l1.UpperFraction);
        TableDK.PrintTable(l1.LowerFraction);
    }
);


Console.WriteLine("The final results \n");
TableDK.PrintTable(l1);



