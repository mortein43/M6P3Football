namespace M6P3Football;

internal class Command
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string City { get; set; }
    public int Win { get; set; }
    public int Lose { get; set; }
    public int Draw { get; set; }
    public int GoalsScored { get; set; }
    public int GoalsConceded { get; set; }

    public List<Player> Players { get; set; } = new();

    public List<Match> Matches { get; set; } = new();
}
