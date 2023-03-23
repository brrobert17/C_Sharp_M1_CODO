namespace Football_Score_Sim;

public class Team
{
    private string name;
    private string abbr;
    private int matches;
    private int points;
    private int won;
    private int drawn;
    private int lost;
    private int goalsFor;
    private int goalsAgainst;
    private int goalDifference;

    public Team(string name, string abbr, int matches, int points, int won, int drawn, int lost, int goalsFor, int goalsAgainst, int goalDifference)
    {
        this.name = name;
        this.abbr = abbr;
        this.matches = matches;
        this.points = points;
        this.won = won;
        this.drawn = drawn;
        this.lost = lost;
        this.goalsFor = goalsFor;
        this.goalsAgainst = goalsAgainst;
        this.goalDifference = goalDifference;
    }

    public Team()
    {
    }


    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    private string Abbr
    {
        get => abbr;
        set => abbr = value ?? throw new ArgumentNullException(nameof(value));
    }

    private int Matches
    {
        get => matches;
        set => matches = value;
    }

    private int Points
    {
        get => points;
        set => points = value;
    }

    private int Won
    {
        get => won;
        set => won = value;
    }

    private int Drawn
    {
        get => drawn;
        set => drawn = value;
    }

    private int Lost
    {
        get => lost;
        set => lost = value;
    }

    private int GoalsFor
    {
        get => goalsFor;
        set => goalsFor = value;
    }

    private int GoalsAgainst
    {
        get => goalsAgainst;
        set => goalsAgainst = value;
    }

    private int GoalDifference
    {
        get => goalDifference;
        set => goalDifference = value;
    }
}