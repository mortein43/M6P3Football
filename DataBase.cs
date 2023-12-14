using Microsoft.Data.Sqlite;
using System.Data;
using System.Data.Common;

namespace M6P3Football;

internal class DataBase
{
    private readonly string sqliteFile = Path.Combine("data source=SpainChampionship.db");
    private const string PROVIDER_INVARIANT_NAME = "Microsoft.Data.Sqlite";
    private DbProviderFactory dbProviderFactory;
    private DbConnection connection;
    private readonly string connectionString = "Data Source=SpainChampionship.db;";

    public DataBase()
    {
        DbProviderFactories.RegisterFactory(PROVIDER_INVARIANT_NAME, /*  */ SqliteFactory.Instance);
        dbProviderFactory = DbProviderFactories.GetFactory(PROVIDER_INVARIANT_NAME);
        connection = dbProviderFactory.CreateConnection();
        connection.ConnectionString = sqliteFile;
    }

    public async Task PrintAllInfo(DataGridView dataGridView1)
    {
        dataGridView1.DataSource = string.Empty;

        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Id, Name, City, Win, Lose, Draw, GoalsScored, GoalsConceded FROM Commands";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task PrintAllMatches(DataGridView dataGridView1)
    {
        dataGridView1.DataSource = string.Empty;

        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Matches.Id, Team1.Name AS Command1, Team2.Name AS Command2, GoalsScored1, GoalsScored2, DateMatch " +
                          "FROM Matches " +
                          "JOIN Commands AS Team1 ON Team1.Id = Matches.Command1 " +
                          "JOIN Commands AS Team2 ON Team2.Id = Matches.Command2";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }


    public async Task PrintGoalsDifference(DataGridView dataGridView1)
    {
        dataGridView1.DataSource = string.Empty;

        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Id, Name, GoalsScored, GoalsConceded, GoalsScored-GoalsConceded AS 'Goals Difference' FROM Commands";

        using DbDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task PrintInfoAboutChekedMatch(DataGridView dataGridView1, int matchId)
    {
        dataGridView1.DataSource = string.Empty;

        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Matches.Id, Team1.Name AS Command1, Team2.Name AS Command2, GoalsScored1, GoalsScored2, DateMatch " +
                          "FROM Matches " +
                          "JOIN Commands AS Team1 ON Team1.Id = Matches.Command1 " +
                          "JOIN Commands AS Team2 ON Team2.Id = Matches.Command2 " +
                          "WHERE Matches.Id = @matchId";
        var parametr1 = command.CreateParameter();
        parametr1.ParameterName = "@matchId";
        parametr1.Value = matchId;
        command.Parameters.Add(parametr1);

        using DbDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task PrintInfoAboutChekedMatchByDate(DataGridView dataGridView1, string matchDate)
    {
        dataGridView1.DataSource = string.Empty;

        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Matches.Id, Team1.Name AS Command1, Team2.Name AS Command2, GoalsScored1, GoalsScored2, DateMatch " +
                          "FROM Matches " +
                          "JOIN Commands AS Team1 ON Team1.Id = Matches.Command1 " +
                          "JOIN Commands AS Team2 ON Team2.Id = Matches.Command2 " +
                          "WHERE Matches.DateMatch = @matchDate";
        var parametr1 = command.CreateParameter();
        parametr1.ParameterName = "@matchDate";
        parametr1.Value = matchDate;
        command.Parameters.Add(parametr1);

        using DbDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task PrintInfoAboutChekedMatchByName(DataGridView dataGridView1, string CommandName)
    {
        dataGridView1.DataSource = string.Empty;

        await connection.OpenAsync();
        DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Matches.Id, Team1.Name AS Command1, Team2.Name AS Command2, GoalsScored1, GoalsScored2, DateMatch " +
                          "FROM Matches " +
                          "JOIN Commands AS Team1 ON Team1.Id = Matches.Command1 " +
                          "JOIN Commands AS Team2 ON Team2.Id = Matches.Command2 " +
                          "WHERE Team1.Name = @CommandName OR Team2.Name = @CommandName";
        var parametr1 = command.CreateParameter();
        parametr1.ParameterName = "@CommandName";
        parametr1.Value = CommandName;
        command.Parameters.Add(parametr1);

        using DbDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public async Task PrintInfoAboutGoalsPlayerByDate(DataGridView dataGridView1, string matchDate)
    {
        dataGridView1.DataSource = null;

        await connection.OpenAsync();

        using DbCommand command = connection.CreateCommand();
        command.CommandText = "SELECT Players.Id, Players.LastName, Players.Number, Players.Position " +
                              "FROM Players " +
                              "JOIN GoalsScored ON GoalsScored.PlayerId = Players.Id " +
                              "JOIN Matches ON Matches.Id = GoalsScored.MatchId " +
                              "WHERE Matches.DateMatch = @MatchDate";

        var parametr1 = command.CreateParameter();
        parametr1.ParameterName = "@MatchDate";
        parametr1.Value = matchDate;
        command.Parameters.Add(parametr1);

        using DbDataReader reader = await command.ExecuteReaderAsync();
        DataTable dataTable = new DataTable();
        dataTable.Load(reader);

        dataGridView1.DataSource = dataTable;
    }

    public void AddMatchInfo(int team1Id, int team2Id, int goalsScored1, int goalsScored2, string dateMatch)
    {
        //Ось так вийшло
        using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection(this.connectionString))
        {
            string insertType = @"
            INSERT OR IGNORE INTO Matches (Command1, Command2, GoalsScored1, GoalsScored2, DateMatch) VALUES 
            (@Team1Id, @Team2Id, @GoalsScored1, @GoalsScored2, @DateMatch)";

            using (System.Data.SQLite.SQLiteCommand insertCommand = new System.Data.SQLite.SQLiteCommand(insertType, connection))
            {
                insertCommand.Parameters.AddWithValue("@Team1Id", team1Id);
                insertCommand.Parameters.AddWithValue("@Team2Id", team2Id);
                insertCommand.Parameters.AddWithValue("@GoalsScored1", goalsScored1);
                insertCommand.Parameters.AddWithValue("@GoalsScored2", goalsScored2);
                insertCommand.Parameters.AddWithValue("@DateMatch", dateMatch);

                connection.Open();
                insertCommand.ExecuteNonQuery();
            }
        }

        //Ось так не виходило, чому на данний момент незнаю треба буде розібратися
        /*
        connection.Open();
        DbCommand addCommand = connection.CreateCommand();
        addCommand.CommandText = "INSERT INTO Matches (Command1, Command2, GoalsScored1, GoalsScored2, DateMatch) VALUES (@Team1Id, @Team2Id, @GoalsScored1, @GoalsScored2, @DateMatch)";
        var param1 = addCommand.CreateParameter();
        param1.ParameterName = "@Team1Id";
        param1.Value = team1Id;
        addCommand.Parameters.Add(param1);

        var param2 = addCommand.CreateParameter();
        param2.ParameterName = "@Team2Id";
        param2.Value = team2Id;
        addCommand.Parameters.Add(param2);

        var param3 = addCommand.CreateParameter();
        param3.ParameterName = "@GoalsScored1";
        param3.Value = goalsScored1;
        addCommand.Parameters.Add(param3);

        var param4 = addCommand.CreateParameter();
        param4.ParameterName = "@GoalsScored2";
        param4.Value = goalsScored2;
        addCommand.Parameters.Add(param4);

        var param5 = addCommand.CreateParameter();
        param5.ParameterName = "@DateMatch";
        param5.Value = dateMatch;
        addCommand.Parameters.Add(param5);

        addCommand.ExecuteNonQuery();*/


    }

    public void UpdateMatchInfo(int matchId, int team1Id, int team2Id, int goalsScored1, int goalsScored2, string dateMatch)
    {
        using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection(this.connectionString))
        {
            string updateType = @"UPDATE Matches SET Command1 = @Team1Id, Command2 = @Team2Id, GoalsScored1 = @GoalsScored1, GoalsScored2 = @GoalsScored2, DateMatch = @DateMatch WHERE Id = @MatchId";

            using (System.Data.SQLite.SQLiteCommand updateCommand = new System.Data.SQLite.SQLiteCommand(updateType, connection))
            {
                updateCommand.Parameters.AddWithValue("@MatchId", matchId);
                updateCommand.Parameters.AddWithValue("@Team1Id", team1Id);
                updateCommand.Parameters.AddWithValue("@Team2Id", team2Id);
                updateCommand.Parameters.AddWithValue("@GoalsScored1", goalsScored1);
                updateCommand.Parameters.AddWithValue("@GoalsScored2", goalsScored2);
                updateCommand.Parameters.AddWithValue("@DateMatch", dateMatch);

                connection.Open();
                updateCommand.ExecuteNonQuery();
            }
        }
    }

    public void DeleteMatch(string command1Name, string command2Name, string dateMatch)
    {
        using (System.Data.SQLite.SQLiteConnection connection = new System.Data.SQLite.SQLiteConnection(this.connectionString))
        {
            string selectMatchQuery = @"
            SELECT Id
            FROM Matches
            WHERE (Command1 IN (SELECT Id FROM Commands WHERE Name = @Command1Name)
                OR Command2 IN (SELECT Id FROM Commands WHERE Name = @Command2Name))
                AND DateMatch = @DateMatch";

            using (System.Data.SQLite.SQLiteCommand selectCommand = new System.Data.SQLite.SQLiteCommand(selectMatchQuery, connection))
            {
                selectCommand.Parameters.AddWithValue("@Command1Name", command1Name);
                selectCommand.Parameters.AddWithValue("@Command2Name", command2Name);
                selectCommand.Parameters.AddWithValue("@DateMatch", dateMatch);

                connection.Open();
                object result = selectCommand.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                {
                    DialogResult dialogResult = MessageBox.Show("Видалити матч?", "Підтвердження видалення", MessageBoxButtons.YesNo);

                    if (dialogResult == DialogResult.Yes)
                    {
                        int matchId = Convert.ToInt32(result);
                        string deleteMatchQuery = "DELETE FROM Matches WHERE Id = @MatchId";

                        using (System.Data.SQLite.SQLiteCommand deleteCommand = new System.Data.SQLite.SQLiteCommand(deleteMatchQuery, connection))
                        {
                            deleteCommand.Parameters.AddWithValue("@MatchId", matchId);
                            deleteCommand.ExecuteNonQuery();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Матч не знайдений.");
                }
            }
        }
    }
}
