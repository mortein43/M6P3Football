﻿namespace M6P3Football;

internal class GoalsScored
{
    public int Id { get; set; }
    public int? PlayerId { get; set; }
    public Player? Player { get; set; }
    public int? MatchId { get; set; }
    public Match? Match { get; set; }
    public int Time { get; set; }

}
