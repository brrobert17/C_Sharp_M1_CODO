namespace Football_Score_Sim;

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
}