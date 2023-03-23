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
    
    public Team(string name, string abbr)
    {
        this.name = name;
        this.abbr = abbr;
    }


    public string Name
    {
        get => name;
        set => name = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Abbr
    {
        get => abbr;
        set => abbr = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int Matches
    {
        get => matches;
        private set => matches = value;
    }

    public int Points
    {
        get => points;
        private set => points = value;
    }

    public int Won
    {
        get => won;
        private set
        {
            won = value;
            calculatePoints();
        }
    }

    public int Drawn
    {
        get => drawn;
        private set
        {
            drawn = value;
            calculatePoints();  
        } 
    }

    public int Lost
    {
        get => lost;
        private set => lost = value;
    }

    public int GoalsFor
    {
        get => goalsFor;
        private set
        {
            goalsFor = value;
            calculateGoalDiff();
        }
    }

    public int GoalsAgainst
    {
        get => goalsAgainst;
        private set
        {
            goalsAgainst = value;
            calculateGoalDiff();
        }
    }

    public int GoalDifference
    {
        get => goalDifference;
        private set => goalDifference = value;
    }

    public void setNames(string fullName, string abbreviation)
    {
        this.Name = fullName;
        this.Abbr = abbr;
    }

    public void addMatch(MatchResult result, int goalsFor, int goalsAgainst, ref Team otherTeam)
    {
        
        this.Matches += 1;
        otherTeam.Matches += 1;
        
        switch (result)
        {
            case MatchResult.WIN:
                this.Won += 1;
                otherTeam.Lost += 1;
                break;
            case MatchResult.DRAW:
                this.Drawn += 1;
                otherTeam.Drawn += 1;
                break;
            case MatchResult.LOSS:
                this.Lost += 1;
                otherTeam.Won += 1;
                break;
        }
        
        addGoals(goalsFor, goalsAgainst);
        otherTeam.addGoals(goalsAgainst, goalsFor);       
        
    }

    private void calculatePoints()
    {
        int pointsForWins = ((int)MatchResult.WIN) * this.won;
        int pointsForDrawn = ((int)MatchResult.DRAW) * this.drawn;

        this.Points = pointsForDrawn + pointsForWins;
    }

    private void calculateGoalDiff()
    {
        this.GoalDifference = Math.Abs(goalsAgainst - goalsFor);
    }

    private void addGoals(int goalsFor, int goalsAgainst)
    {
        this.GoalsFor += goalsFor;          
        this.GoalsAgainst += goalsAgainst;  
    }
}