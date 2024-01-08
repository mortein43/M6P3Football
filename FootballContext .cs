using Microsoft.EntityFrameworkCore;

namespace M6P3Football;

internal class FootballContext : DbContext
{
    public DbSet<Command> Commands => this.Set<Command>();
    public DbSet<Player> Players => this.Set<Player>();
    public DbSet<GoalsScored> GoalsScored => this.Set<GoalsScored>();
    public DbSet<Match> Matches => this.Set<Match>();

    public FootballContext()
    {
        this.Database.EnsureDeleted();
        this.Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Player>()
            .HasOne(p => p.Command)
            .WithMany(t => t.Players)
            .HasForeignKey(p => p.CommandId);

        modelBuilder.Entity<Match>()
            .HasMany(m => m.Commands)
            .WithMany(t => t.Matches);

        modelBuilder.Entity<GoalsScored>()
            .HasOne(g => g.Player)
            .WithMany(p => p.GoalsScored)
            .HasForeignKey(p => p.PlayerId);

        modelBuilder.Entity<GoalsScored>()
            .HasOne(g => g.Match)
            .WithMany(m => m.GoalsScored)
            .HasForeignKey(p => p.MatchId);
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=SpainChampionship.db");
    }
}
