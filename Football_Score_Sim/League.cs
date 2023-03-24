﻿namespace Football_Score_Sim;

public class League
{
    private string name;
    private List<Team> teams;

    public League(string name, List<Team> teams)
    {
        this.name = name;
        this.teams = teams;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Team> Teams
    {
        get => teams;
        set => teams = value ?? throw new ArgumentNullException(nameof(value));
    }


    public void AddMatch(string t1Abbr, string t2Abbr, int t1Goals, int t2Goals)
    {
        var t1 = FindTeam(t1Abbr);
        var t2 = FindTeam(t2Abbr);
        var newTeams = Teams;

        if (t1 == null || t2 == null)
        {
            throw new ArgumentException("Could not find the specified teams");
        }

        newTeams.Remove(t1);
        newTeams.Remove(t2);
        
        t1.AddMatch(ref t2, t1Goals, t2Goals);
        
        newTeams.Add(t1);
        newTeams.Add(t2);

        this.Teams = newTeams; 
        CalculateTeamsPos();

    }

    public Team FindTeam(string abbr)
    {
        var findResult = this.Teams.FindAll(item => item.Abbr == abbr);
        if (findResult.Count > 1)
        {
            Console.WriteLine("There are duplicate team abbreviations in a league");
            return null;
            
        } else if (findResult.Count < 1)
        {
            return null;
        }
        
        return findResult[0];
        
        
    }

    public void CalculateTeamsPos()
    {
        var newTeams = Teams;

        newTeams = newTeams.OrderByDescending(x => x.Points)
            .ThenByDescending(x => x.GoalDifference)
            .ThenByDescending(x => x.GoalsFor)
            .ThenBy(x => x.GoalsAgainst)
            .ThenBy(x => x.Name)
            .ToList();

        int position = 1;
        foreach (var team in newTeams)
        {
            team.Position = position++;
        }

        this.Teams = newTeams;

    }
    
    
}