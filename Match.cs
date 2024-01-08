using System.ComponentModel.DataAnnotations.Schema;

namespace M6P3Football;

[Table("Matches")]
internal class Match
{
    public int Id { get; set; }
    public List<Command> Commands { get; set; } = new List<Command>();
    public int GoalsScored1 { get; set; }
    public int GoalsScored2 { get; set; }
    public DateOnly Date { get; set; }
    [NotMapped]
    public List<GoalsScored> GoalsScored { get; set; } = new();
}
