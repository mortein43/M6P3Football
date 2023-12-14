namespace M6P3Football;

public partial class Form1 : Form
{
    private DataBase db = new DataBase();
    public Form1()
    {
        InitializeComponent();
        this.ComboIdMatch.SelectedIndex = 0;
        this.comboDateMatch.SelectedIndex = 0;
        this.comboCommandName.SelectedIndex = 0;
        this.comboGoalsPlayerByDate.SelectedIndex = 0;
        this.comboBoxDeleteByCommand1Name.SelectedIndex = 0;
        this.comboBoxDeleteByCommand2Name.SelectedIndex = 0;
        this.comboBoxDeleteByDateMatch.SelectedIndex = 0;


        this.AllInfo.Checked = true;

    }

    private void AllInfo_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.db.PrintAllInfo(this.dataGridView1);

    }

    private void GoalsDifference_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.db.PrintGoalsDifference(this.dataGridView1);
    }

    private void RadioInfoAboutMatch_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.db.PrintInfoAboutChekedMatch(this.dataGridView1, int.Parse(this.ComboIdMatch.Text));
    }

    private void RadioInfoDateMatch_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.db.PrintInfoAboutChekedMatchByDate(this.dataGridView1, this.comboDateMatch.Text);
    }

    private void radioMatchesByCommand_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.db.PrintInfoAboutChekedMatchByName(this.dataGridView1, this.comboCommandName.Text);
    }

    private void radioPlayersGoals_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.db.PrintInfoAboutGoalsPlayerByDate(this.dataGridView1, this.comboGoalsPlayerByDate.Text);
    }

    private void buttonAddMatch_Click(object sender, EventArgs e)
    {
        this.db.AddMatchInfo((int)this.numericCommand1.Value, (int)this.numericCommand2.Value, (int)this.numericCommand1Goals.Value, (int)this.numericCommand2Goals.Value, this.textBoxAddDateMatch.Text);
        _ = this.db.PrintAllMatches(this.dataGridView1);
    }

    private void RadioAllMathes_CheckedChanged(object sender, EventArgs e)
    {
        _ = this.db.PrintAllMatches(this.dataGridView1);
    }

    private void buttonUpdate_Click(object sender, EventArgs e)
    {
        this.db.UpdateMatchInfo((int)this.numericUpIdMatch.Value, (int)this.numericUpIdCommand1.Value, (int)this.numericUpIdCommand2.Value, (int)this.numericUpGoalsCommand1.Value, (int)this.numericUpGoalsCommand2.Value, this.UpdateDateMatch.Text);
        _ = this.db.PrintAllMatches(this.dataGridView1);
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        this.db.DeleteMatch(this.comboBoxDeleteByCommand1Name.Text, this.comboBoxDeleteByCommand2Name.Text, this.comboBoxDeleteByDateMatch.Text);
        _ = this.db.PrintAllMatches(this.dataGridView1);
    }

}
