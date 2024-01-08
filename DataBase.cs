using Microsoft.EntityFrameworkCore;

namespace M6P3Football
{
    internal class DataBase
    {
        private readonly FootballContext _context;


        public DataBase()
        {
            _context = new FootballContext();

            Player player1 = new Player() { LastName = "Courtois", Number = 1, Position = "Goalkeeper", Country = "Belgium" };
            Player player2 = new Player() { LastName = "Lunin", Number = 13, Position = "Goalkeeper", Country = "Ukraine" };
            Player player3 = new Player() { LastName = "Arrizabalaga", Number = 25, Position = "Goalkeeper", Country = "Spain" };
            Player player4 = new Player() { LastName = "Carvajal", Number = 2, Position = "Defender", Country = "Spain" };
            Player player5 = new Player() { LastName = "E.Militao", Number = 3, Position = "Defender", Country = "Brazil" };
            Player player6 = new Player() { LastName = "Alaba", Number = 4, Position = "Defender", Country = "Austria" };
            Player player7 = new Player() { LastName = "Nacho", Number = 6, Position = "Defender", Country = "Spain" };
            Player player8 = new Player() { LastName = "Bellingham", Number = 5, Position = "Midfielder", Country = "England" };
            Player player9 = new Player() { LastName = "Kroos", Number = 8, Position = "Midfielder", Country = "Germany" };
            Player player10 = new Player() { LastName = "Modric", Number = 10, Position = "Midfielder", Country = "Croatia" };
            Player player11 = new Player() { LastName = "Camavinga", Number = 12, Position = "Midfielder", Country = "France" };
            Player player12 = new Player() { LastName = "Vini Jr.", Number = 7, Position = "Forward", Country = "Brazil" };
            Player player13 = new Player() { LastName = "Rodrygo", Number = 11, Position = "Forward", Country = "Brazil" };
            Player player14 = new Player() { LastName = "Joselu", Number = 14, Position = "Forward", Country = "Spain" };
            Player player15 = new Player() { LastName = "Brahim", Number = 21, Position = "Forward", Country = "Spain" };
            Player player16 = new Player() { LastName = "Carlos", Number = 1, Position = "Goalkeeper", Country = "Spain" };
            Player player17 = new Player() { LastName = "Espinoza", Number = 2, Position = "Defender", Country = "Argentina" };
            Player player18 = new Player() { LastName = "Gutierrez", Number = 3, Position = "Defender", Country = "Colombia" };
            Player player19 = new Player() { LastName = "Martinez", Number = 4, Position = "Defender", Country = "Spain" };
            Player player20 = new Player() { LastName = "Lopez", Number = 5, Position = "Defender", Country = "Spain" };
            Player player21 = new Player() { LastName = "Kebe", Number = 6, Position = "Midfielder", Country = "Mali" };
            Player player22 = new Player() { LastName = "Stuani", Number = 7, Position = "Forward", Country = "Uruguay" };
            Player player23 = new Player() { LastName = "Tsyhankov", Number = 8, Position = "Forward", Country = "Ukraine" };
            Player player24 = new Player() { LastName = "Dovbyk", Number = 9, Position = "Forward", Country = "Ukraine" };
            Player player25 = new Player() { LastName = "Garcia", Number = 10, Position = "Midfielder", Country = "Spain" };
            Player player26 = new Player() { LastName = "A. Garcia", Number = 14, Position = "Midfielder", Country = "Spain" };
            Player player27 = new Player() { LastName = "Ter Stegen", Number = 1, Position = "Goalkeeper", Country = "Germany" };
            Player player28 = new Player() { LastName = "Cancelo", Number = 2, Position = "Defender", Country = "Portugal" };
            Player player29 = new Player() { LastName = "Martinez", Number = 5, Position = "Defender", Country = "Argentina" };
            Player player30 = new Player() { LastName = "Alonso", Number = 17, Position = "Defender", Country = "Spain" };
            Player player31 = new Player() { LastName = "Balde", Number = 3, Position = "Defender", Country = "Guinea-Bissau" };
            Player player32 = new Player() { LastName = "Gundogan", Number = 22, Position = "Midfielder", Country = "Germany" };
            Player player33 = new Player() { LastName = "De Jong", Number = 21, Position = "Midfielder", Country = "Netherlands" };
            Player player34 = new Player() { LastName = "Roberto", Number = 20, Position = "Midfielder", Country = "Spain" };
            Player player35 = new Player() { LastName = "Lewandowski", Number = 9, Position = "Forward", Country = "Poland" };
            Player player36 = new Player() { LastName = "Torres", Number = 7, Position = "Forward", Country = "Spain" };
            Player player37 = new Player() { LastName = "Raphinha", Number = 11, Position = "Forward", Country = "Brazil" };
            Player player38 = new Player() { LastName = "Grbic", Number = 1, Position = "Goalkeeper", Country = "Croatia" };
            Player player39 = new Player() { LastName = "Oblak", Number = 13, Position = "Goalkeeper", Country = "Slovenia" };
            Player player40 = new Player() { LastName = "Gimenez", Number = 2, Position = "Defender", Country = "Uruguay" };
            Player player41 = new Player() { LastName = "Azpilicueta", Number = 3, Position = "Defender", Country = "Spain" };
            Player player42 = new Player() { LastName = "Soyuncu", Number = 4, Position = "Defender", Country = "Turkey" };
            Player player43 = new Player() { LastName = "Savic", Number = 15, Position = "Defender", Country = "Montenegro" };
            Player player44 = new Player() { LastName = "Koke", Number = 6, Position = "Midfielder", Country = "Spain" };
            Player player45 = new Player() { LastName = "Saul", Number = 8, Position = "Midfielder", Country = "Spain" };
            Player player46 = new Player() { LastName = "Lemar", Number = 11, Position = "Midfielder", Country = "France" };
            Player player47 = new Player() { LastName = "Morata", Number = 19, Position = "Forward", Country = "Spain" };
            Player player48 = new Player() { LastName = "Memphis", Number = 9, Position = "Forward", Country = "Netherlands" };
            Player player49 = new Player() { LastName = "Griezmann", Number = 7, Position = "Forward", Country = "France" };
            Player player50 = new Player() { LastName = "Simon", Number = 1, Position = "Goalkeeper", Country = "Spain" };
            Player player51 = new Player() { LastName = "Vivian", Number = 3, Position = "Defender", Country = "Nigeria" };
            Player player52 = new Player() { LastName = "Paredes", Number = 4, Position = "Defender", Country = "Argentina" };
            Player player53 = new Player() { LastName = "Yeray", Number = 5, Position = "Defender", Country = "Spain" };
            Player player54 = new Player() { LastName = "I. Lekue", Number = 15, Position = "Defender", Country = "Spain" };
            Player player55 = new Player() { LastName = "Vesga", Number = 6, Position = "Midfielder", Country = "Spain" };
            Player player56 = new Player() { LastName = "O. Sancet", Number = 8, Position = "Midfielder", Country = "Spain" };
            Player player57 = new Player() { LastName = "Dani Garcia", Number = 14, Position = "Midfielder", Country = "Spain" };
            Player player58 = new Player() { LastName = "Berenguer", Number = 7, Position = "Forward", Country = "Spain" };
            Player player59 = new Player() { LastName = "Williams", Number = 8, Position = "Forward", Country = "Spain" };
            Player player60 = new Player() { LastName = "Muniain", Number = 10, Position = "Forward", Country = "Spain" };

            Command realmadrid = new Command
            {
                Name = "Real Madrid",
                City = "Madrid",
                Win = 12,
                Lose = 1,
                Draw = 2,
                GoalsScored = 33,
                GoalsConceded = 9,
                Players = { player1, player2, player3, player4, player5, player6, player7, player8, player9, player10, player11, player12, player13, player14, player15 }
            };
            Command gerona = new Command
            {
                Name = "Gerona",
                City = "Girona",
                Win = 12,
                Lose = 1,
                Draw = 2,
                GoalsScored = 34,
                GoalsConceded = 18,
                Players = { player16, player17, player18, player19, player20, player21, player22, player23, player24, player25, player26 }
            };
            Command barcelona = new Command
            {
                Name = "Barcelona",
                City = "Barcelona",
                Win = 10,
                Lose = 1,
                Draw = 4,
                GoalsScored = 28,
                GoalsConceded = 14,
                Players = { player27, player28, player29, player30, player31, player32, player33, player34, player35, player36, player37 }
            };
            Command atleticoMadrid = new Command
            {
                Name = "Atletico M",
                City = "Madrid",
                Win = 10,
                Lose = 3,
                Draw = 1,
                GoalsScored = 30,
                GoalsConceded = 13,
                Players = { player38, player39, player40, player41, player42, player43, player44, player45, player46, player47, player48, player49 }
            };
            Command atleticoBilbao = new Command
            {
                Name = "Atletic B",
                City = "Bilbao",
                Win = 8,
                Lose = 3,
                Draw = 4,
                GoalsScored = 30,
                GoalsConceded = 18,
                Players = { player50, player51, player52, player53, player54, player55, player56, player57, player58, player59, player60 }
            };

            Match barger = new Match { Commands = { barcelona, gerona }, GoalsScored1 = 2, GoalsScored2 = 4, Date = new DateOnly(2023, 12, 10) };
            Match baratlM = new Match { Commands = { barcelona, atleticoMadrid }, GoalsScored1 = 1, GoalsScored2 = 0, Date = new DateOnly(2023, 12, 03) };
            Match geratlB = new Match { Commands = { gerona, atleticoBilbao }, GoalsScored1 = 1, GoalsScored2 = 1, Date = new DateOnly(2023, 11, 27) };
            Match barrealM = new Match { Commands = { barcelona, realmadrid }, GoalsScored1 = 1, GoalsScored2 = 2, Date = new DateOnly(2023, 10, 28) };
            Match baratlB = new Match { Commands = { barcelona, atleticoBilbao }, GoalsScored1 = 1, GoalsScored2 = 0, Date = new DateOnly(2023, 10, 22) };

            GoalsScored goal1 = new GoalsScored { Player = player24, Match = barger, Time = 12 };
            GoalsScored goal2 = new GoalsScored { Player = player35, Match = barger, Time = 19 };
            GoalsScored goal3 = new GoalsScored { Player = player18, Match = barger, Time = 40 };
            GoalsScored goal4 = new GoalsScored { Player = player21, Match = barger, Time = 80 };
            GoalsScored goal5 = new GoalsScored { Player = player32, Match = barger, Time = 92 };
            GoalsScored goal6 = new GoalsScored { Player = player22, Match = barger, Time = 95 };
            GoalsScored goal7 = new GoalsScored { Player = player35, Match = baratlM, Time = 28 };
            GoalsScored goal8 = new GoalsScored { Player = player23, Match = geratlB, Time = 55 };
            GoalsScored goal9 = new GoalsScored { Player = player59, Match = geratlB, Time = 67 };
            GoalsScored goal10 = new GoalsScored { Player = player32, Match = barrealM, Time = 6 };
            GoalsScored goal11 = new GoalsScored { Player = player8, Match = barrealM, Time = 68 };
            GoalsScored goal12 = new GoalsScored { Player = player8, Match = barrealM, Time = 92 };
            GoalsScored goal13 = new GoalsScored { Player = player35, Match = baratlB, Time = 80 };

            _context.Matches.AddRange(barger, baratlM, geratlB, barrealM, baratlB);
            _context.Players.AddRange(player1, player2, player3, player4, player5, player6, player7, player8, player9, player10, player11, player12, player13, player14, player15,
                player16, player17, player18, player19, player20, player21, player22, player23, player24, player25, player26,
                player27, player28, player29, player30, player31, player32, player33, player34, player35, player36, player37,
                player38, player39, player40, player41, player42, player43, player44, player45, player46, player47, player48, player49,
                player50, player51, player52, player53, player54, player55, player56, player57, player58, player59, player60);
            _context.Commands.AddRange(realmadrid, gerona, barcelona, atleticoMadrid, atleticoBilbao);
            _context.GoalsScored.AddRange(goal1, goal2, goal3, goal4, goal5, goal6, goal7, goal8, goal9, goal10, goal11, goal12, goal13);
            _context.SaveChanges();


        }


        public async Task PrintAllInfo(DataGridView dataGridView1)
        {
            dataGridView1.DataSource = await _context.Commands.ToListAsync();
        }

        public async Task PrintAllMatches(DataGridView dataGridView1)
        {
            var matches = await _context.Matches.Select(m => new
            {
                m.Id,
                m.GoalsScored1,
                m.GoalsScored2,
                m.Date
            }).ToListAsync();
            dataGridView1.DataSource = matches;
        }

        public async Task PrintGoalsDifference(DataGridView dataGridView1)
        {
            var commands = await _context.Commands
                    .Select(c => new
                    {
                        c.Id,
                        c.Name,
                        c.GoalsScored,
                        c.GoalsConceded,
                        GoalsDifference = c.GoalsScored - c.GoalsConceded
                    })
                    .ToListAsync();

            dataGridView1.DataSource = commands;
        }

        public async Task PrintInfoAboutChekedMatch(DataGridView dataGridView1, int matchId)
        {
            var matchInfo = await _context.Matches
                     .Where(m => m.Id == matchId)
                     .Select(m => new
                     {
                         m.Id,
                         m.GoalsScored1,
                         m.GoalsScored2,
                         m.Date
                     })
                     .ToListAsync();

            dataGridView1.DataSource = matchInfo;
        }

        public async Task PrintInfoAboutChekedMatchByDate(DataGridView dataGridView1, string matchDate)
        {
            var matchInfo = await _context.Matches
                    .Where(m => m.Date == DateOnly.Parse(matchDate))
                    .Select(m => new
                    {
                        m.Id,
                        m.GoalsScored1,
                        m.GoalsScored2,
                        m.Date
                    })
                    .ToListAsync();

            dataGridView1.DataSource = matchInfo;
        }

        public async Task PrintInfoAboutChekedMatchByName(DataGridView dataGridView1, string CommandName)
        {
            var matchInfo = await _context.Matches
                    .Where(m => m.Commands[0].Name == CommandName || m.Commands[1].Name == CommandName)
                    .Select(m => new
                    {
                        m.Id,
                        Command1 = m.Commands[0].Name,
                        Command2 = m.Commands[1].Name,
                        m.GoalsScored1,
                        m.GoalsScored2,
                        m.Date
                    })
                    .ToListAsync();

            dataGridView1.DataSource = matchInfo;
        }

        public async Task PrintInfoAboutGoalsPlayerByDate(DataGridView dataGridView1, string matchDate)
        {
            var players = await _context.Players
                    .Join(_context.GoalsScored,
                        player => player.Id,
                        goal => goal.PlayerId,
                        (player, goal) => new { player.Id, player.LastName, player.Number, player.Position, goal.Match.Date })
                    .Where(p => p.Date == DateOnly.Parse(matchDate))
                    .ToListAsync();

            dataGridView1.DataSource = players;
        }

        public void AddMatchInfo(int team1Id, int team2Id, int goalsScored1, int goalsScored2, string dateMatch)
        {
            var command1 = _context.Commands.FirstOrDefault(c => c.Id == team1Id);
            var command2 = _context.Commands.FirstOrDefault(c => c.Id == team2Id);

            if (command1 != null && command2 != null)
            {
                var match = new Match
                {
                    Commands = new List<Command> { command1, command2 },
                    GoalsScored1 = goalsScored1,
                    GoalsScored2 = goalsScored2,
                    Date = DateOnly.Parse(dateMatch)
                };

                _context.Matches.Add(match);
                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Не знайдено команди із вказаним Id.");
            }
        }

        public void UpdateMatchInfo(int matchId, int team1Id, int team2Id, int goalsScored1, int goalsScored2, string dateMatch)
        {
            var match = _context.Matches.Find(matchId);
            var command1 = _context.Commands.FirstOrDefault(c => c.Id == team1Id);
            var command2 = _context.Commands.FirstOrDefault(c => c.Id == team2Id);

            if (match != null)
            {
                match.Commands = new List<Command> { command1, command2 };
                match.GoalsScored1 = goalsScored1;
                match.GoalsScored2 = goalsScored2;
                match.Date = DateOnly.Parse(dateMatch);

                _context.SaveChanges();
            }
            else
            {
                MessageBox.Show("Не знайдено матча із вказаним Id.");
            }
        }

        public void DeleteMatch(string command1Name, string command2Name, string dateMatch)
        {
            var match = _context.Matches
                    .FirstOrDefault(m =>
                        (m.Commands[0].Name == command1Name || m.Commands[1].Name == command1Name) &&
                        (m.Commands[0].Name == command2Name || m.Commands[1].Name == command2Name) &&
                        m.Date == DateOnly.Parse(dateMatch));

            if (match != null)
            {
                var result = MessageBox.Show("Видалити матч?", "Підтвердження видалення", MessageBoxButtons.YesNo);

                if (result == DialogResult.Yes)
                {
                    _context.Matches.Remove(match);
                    _context.SaveChanges();
                }
            }
            else
            {
                MessageBox.Show("Матч не знайдений.");
            }
        }
    }
}
