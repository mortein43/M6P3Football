namespace M6P3Football;

internal class Player
{
    public int Id { get; set; }
    public string LastName { get; set; }
    public string Country { get; set; }
    public string Position { get; set; }
    public int Number { get; set; }
    public int? CommandId { get; set; }
    public Command? Command { get; set; }
    public List<GoalsScored> GoalsScored { get; set; }
}
