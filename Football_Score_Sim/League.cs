namespace Football_Score_Sim;

public class League
{
    private string name;
    private int numToChampion;
    private int numToEurope;
    private int numToUpperLeague;
    private int numToLowerLeague;
    private int numOfTeams;
    private List<int> posToChampion = new List<int>();
    private List<int> posToEurope = new List<int>();
    private List<int> posToUpperLeague = new List<int>();
    private List<int> posToLowerLeague = new List<int>();
    private List<Team> teams = new List<Team>();
    private List<Team> upperFraction = new List<Team>();
    private List<Team> lowerFraction = new List<Team>();

    public League(string name, List<Team> teams)
    {
        this.name = name;
        this.teams = teams;
    }
    
    public League(string name)
    {
        this.name = name;
    }
    
    public League(){}
    
    public void LeagueSetup(string name, int numToChampion, int numToEurope, int numToUpperLeague, int numToLowerLeague, int numOfTeams)
    {
        this.name = name;
        this.NumOfTeams = numOfTeams;
        this.NumToChampion = numToChampion;
        this.NumToEurope = numToEurope;
        this.NumToUpperLeague = numToUpperLeague;
        this.NumToLowerLeague = numToLowerLeague;
    }

    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public List<Team> Teams
    {
        get => teams;
        set
        {
            if (value.Count > NumOfTeams) { throw new Exception("Provided incorrect number of teams"); }
            teams = value;
        }
    }
    
    public int NumToChampion
    {
        get => numToChampion;
        set
        {
            
            numToChampion = value;
            CalculateSpecialPos();
        }
    }
    
    public int NumToEurope
    {
        get => numToEurope;
        set
        {
            numToEurope = value;
            CalculateSpecialPos();
        }
    }
    
    public int NumToUpperLeague
    {
        get => numToUpperLeague;
        set
        {
            numToUpperLeague = value;
            CalculateSpecialPos();
        } 
    }
    
    public int NumToLowerLeague
    {
        get => numToLowerLeague;
        set
        {
            numToLowerLeague = value;
            CalculateSpecialPos();
        } 
    }
    
    public int NumOfTeams
    {
        get => numOfTeams;
        set => numOfTeams = value;
    }

    public List<Team> UpperFraction
    {
        get => upperFraction;
        set => upperFraction = value;
    }
    
    public List<Team> LowerFraction
    {
        get => lowerFraction;
        set => lowerFraction = value;
    }
    
    public List<int> PosToChampion
    {
        get => posToChampion;
        set => posToChampion = value;
    }
    
    public List<int> PosToEurope
    {
        get => posToEurope;
        set => posToEurope = value;
    }
    
    public List<int> PosToUpperLeague
    {
        get => posToUpperLeague;
        set => posToUpperLeague = value;
    }
    
    public List<int> PosToLowerLeague
    {
        get => posToLowerLeague;
        set => posToLowerLeague = value;
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
        if (upperFraction.Count != 0)
        {
            CalculateTeamsPos(ref upperFraction, 1);
            CalculateTeamsPos(ref lowerFraction, 7);
            CalculateTeamsFromFractions();
        }
        else
        {
            CalculateTeamsPos();
        }
    }

    public Team FindTeam(string abbr)
    {
        var findResult = this.Teams.FindAll(item => item.Abbr == abbr);
        if (findResult.Count > 1)
        {
            Console.WriteLine("There are duplicate team abbreviations in a league");
            return null;
        }
        else if (findResult.Count < 1)
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
        Team t1 = newTeams[0];
        foreach (var team in newTeams)
        {
            if (!t1.Abbr.Equals(team.Abbr)
                && t1.Points.Equals(team.Points)
                && t1.GoalDifference.Equals(team.GoalDifference)
                && t1.GoalsFor.Equals(team.GoalsFor)
                && t1.GoalsAgainst.Equals(team.GoalsAgainst))
            {
                team.Position = position - 1;
            }
            else
            {
                team.Position = position++;
            }

            t1 = team;
        }

        this.Teams = newTeams;
    }
    
    public void CalculateTeamsPos(ref List<Team> fraction, int topPosition)
    {
        var newTeams = fraction;

        newTeams = newTeams.OrderByDescending(x => x.Points)
            .ThenByDescending(x => x.GoalDifference)
            .ThenByDescending(x => x.GoalsFor)
            .ThenBy(x => x.GoalsAgainst)
            .ThenBy(x => x.Name)
            .ToList();

        int position = topPosition;
        Team t1 = newTeams[0];
        foreach (var team in newTeams)
        {
            if (!t1.Abbr.Equals(team.Abbr)
                && t1.Points.Equals(team.Points)
                && t1.GoalDifference.Equals(team.GoalDifference)
                && t1.GoalsFor.Equals(team.GoalsFor)
                && t1.GoalsAgainst.Equals(team.GoalsAgainst))
            {
                team.Position = position - 1;
            }
            else
            {
                team.Position = position++;
            }

            t1 = team;
        }

        fraction = newTeams;
    }

    public void CalculateTeamsFromFractions()
    {
        if (this.upperFraction.Count != 0 && this.LowerFraction.Count != 0)
        {
            List<Team> newFTeams = new List<Team>();
            newFTeams.AddRange(this.upperFraction);
            newFTeams.AddRange(this.LowerFraction);
            this.Teams = newFTeams;
        }
    }

    public void AddTeam(string name, string abbr)
    {

        this.Teams.Add(new Team(name, abbr));
        CalculateTeamsPos();
    }

    public void CalculateFractions()
    {
        this.UpperFraction = this.Teams.FindAll(team => team.Position <= 6);
        this.LowerFraction = this.Teams.FindAll(team => team.Position > 6);
        
    }

    public void CalculateSpecialPos()
    {
        for (int i = 1; i <= NumOfTeams; i++)
        {
            if (i <= NumToUpperLeague)
            {
                this.posToUpperLeague.Add(i);
            }
            
            if (i <= NumToChampion)
            {
                this.posToChampion.Add(i);
                
            } else if (i > NumToChampion && i <= (NumToChampion + NumToEurope))
            {
                this.posToEurope.Add(i);
            }

            if (i > (NumOfTeams - NumToLowerLeague))
            {
                this.posToLowerLeague.Add(i);
            }
        }
    }
}