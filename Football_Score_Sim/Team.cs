namespace Football_Score_Sim;

public class Team
{
    private int position;
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
    private string streak;

    public Team(string name, string abbr, int matches, int points, int won, int drawn, int lost, int goalsFor,
        int goalsAgainst, int goalDifference, string streak)
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
        this.streak = streak;
    }

    public Team(string name, string abbr)
    {
        this.name = name;
        this.abbr = abbr;
        this.matches = 0;
        this.points = 0;
        this.won = 0;
        this.drawn = 0;
        this.lost = 0;
        this.goalsFor = 0;
        this.goalsAgainst = 0;
        this.goalDifference = 0;
        this.streak = "-----";
    }


    public int Position
    {
        get => position;
        set => position = value;
        
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
            CalculatePoints();
        }
    }

    public int Drawn
    {
        get => drawn;
        private set
        {
            drawn = value;
            CalculatePoints();
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
            CalculateGoalDiff();
        }
    }

    public int GoalsAgainst
    {
        get => goalsAgainst;
        private set
        {
            goalsAgainst = value;
            CalculateGoalDiff();
        }
    }

    public int GoalDifference
    {
        get => goalDifference;
        private set => goalDifference = value;
    }

    public string Streak
    {
        get => streak;
        private set => streak = value;
    }

    public void setNames(string fullName, string abbreviation)
    {
        this.Name = fullName;
        this.Abbr = abbr;
    }

    public void AddMatch(ref Team otherTeam, int goalsFor, int goalsAgainst)
    {
        this.Matches += 1;
        otherTeam.Matches += 1;

        this.Streak = this.Streak.Substring(0, this.Streak.Length - 1);
        otherTeam.Streak = otherTeam.Streak.Substring(0, otherTeam.Streak.Length - 1);
        if (goalsFor > goalsAgainst)
        {
            this.Won += 1;
            otherTeam.Lost += 1;
            this.Streak = this.Streak.PadLeft(5, 'W');
            otherTeam.Streak = otherTeam.Streak.PadLeft(5, 'L');
        }
        else if (goalsFor < goalsAgainst)
        {
            this.Lost += 1;
            otherTeam.Won += 1;
            this.Streak = this.Streak.PadLeft(5, 'L');
            otherTeam.Streak = otherTeam.Streak.PadLeft(5, 'W');
        }
        else if (goalsFor == goalsAgainst)
        {
            this.Drawn += 1;
            otherTeam.Drawn += 1;
            this.Streak = this.Streak.PadLeft(5, 'D');
            otherTeam.Streak = otherTeam.Streak.PadLeft(5, 'D');
        }

        AddGoals(goalsFor, goalsAgainst);
        otherTeam.AddGoals(goalsAgainst, goalsFor);
    }


    private void CalculatePoints()
    {
        int pointsForWins = ((int)MatchResult.WIN) * this.won;
        int pointsForDrawn = ((int)MatchResult.DRAW) * this.drawn;

        this.Points = pointsForDrawn + pointsForWins;
    }

    private void CalculateGoalDiff()
    {
        this.GoalDifference = goalsFor - goalsAgainst;
    }

    private void AddGoals(int goalsFor, int goalsAgainst)
    {
        this.GoalsFor += goalsFor;
        this.GoalsAgainst += goalsAgainst;
    }
}