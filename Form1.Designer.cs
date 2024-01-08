namespace M6P3Football
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            AllInfo = new RadioButton();
            GoalsDifference = new RadioButton();
            ComboIdMatch = new ComboBox();
            RadioInfoAboutMatch = new RadioButton();
            comboDateMatch = new ComboBox();
            RadioInfoDateMatch = new RadioButton();
            comboCommandName = new ComboBox();
            radioMatchesByCommand = new RadioButton();
            comboGoalsPlayerByDate = new ComboBox();
            radioPlayersGoals = new RadioButton();
            numericCommand1 = new NumericUpDown();
            numericCommand2 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            numericCommand1Goals = new NumericUpDown();
            numericCommand2Goals = new NumericUpDown();
            label3 = new Label();
            label4 = new Label();
            textBoxAddDateMatch = new TextBox();
            label5 = new Label();
            buttonAddMatch = new Button();
            RadioAllMathes = new RadioButton();
            label6 = new Label();
            numericUpIdMatch = new NumericUpDown();
            label7 = new Label();
            label8 = new Label();
            numericUpIdCommand1 = new NumericUpDown();
            numericUpIdCommand2 = new NumericUpDown();
            label9 = new Label();
            label10 = new Label();
            numericUpGoalsCommand1 = new NumericUpDown();
            numericUpGoalsCommand2 = new NumericUpDown();
            UpdateDateMatch = new TextBox();
            buttonUpdate = new Button();
            comboBoxDeleteByCommand1Name = new ComboBox();
            comboBoxDeleteByDateMatch = new ComboBox();
            label11 = new Label();
            label12 = new Label();
            buttonDelete = new Button();
            label13 = new Label();
            comboBoxDeleteByCommand2Name = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCommand1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCommand2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCommand1Goals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericCommand2Goals).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpIdMatch).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpIdCommand1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpIdCommand2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpGoalsCommand1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpGoalsCommand2).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Bottom;
            dataGridView1.Location = new Point(0, 206);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(860, 244);
            dataGridView1.TabIndex = 0;
            // 
            // AllInfo
            // 
            AllInfo.AutoSize = true;
            AllInfo.Location = new Point(12, 12);
            AllInfo.Name = "AllInfo";
            AllInfo.Size = new Size(75, 19);
            AllInfo.TabIndex = 1;
            AllInfo.TabStop = true;
            AllInfo.Text = "Загальна";
            AllInfo.UseVisualStyleBackColor = true;
            AllInfo.CheckedChanged += AllInfo_CheckedChanged;
            // 
            // GoalsDifference
            // 
            GoalsDifference.AutoSize = true;
            GoalsDifference.Location = new Point(12, 37);
            GoalsDifference.Name = "GoalsDifference";
            GoalsDifference.Size = new Size(98, 19);
            GoalsDifference.TabIndex = 2;
            GoalsDifference.TabStop = true;
            GoalsDifference.Text = "Різниця голів";
            GoalsDifference.UseVisualStyleBackColor = true;
            GoalsDifference.CheckedChanged += GoalsDifference_CheckedChanged;
            // 
            // ComboIdMatch
            // 
            ComboIdMatch.FormattingEnabled = true;
            ComboIdMatch.Items.AddRange(new object[] { "1", "2", "3", "4", "5" });
            ComboIdMatch.Location = new Point(12, 62);
            ComboIdMatch.Name = "ComboIdMatch";
            ComboIdMatch.Size = new Size(38, 23);
            ComboIdMatch.TabIndex = 3;
            ComboIdMatch.SelectedIndexChanged += RadioInfoAboutMatch_CheckedChanged;
            // 
            // RadioInfoAboutMatch
            // 
            RadioInfoAboutMatch.AutoSize = true;
            RadioInfoAboutMatch.Location = new Point(56, 66);
            RadioInfoAboutMatch.Name = "RadioInfoAboutMatch";
            RadioInfoAboutMatch.Size = new Size(143, 19);
            RadioInfoAboutMatch.TabIndex = 4;
            RadioInfoAboutMatch.TabStop = true;
            RadioInfoAboutMatch.Text = "Інформація про матч";
            RadioInfoAboutMatch.UseVisualStyleBackColor = true;
            RadioInfoAboutMatch.CheckedChanged += RadioInfoAboutMatch_CheckedChanged;
            // 
            // comboDateMatch
            // 
            comboDateMatch.FormattingEnabled = true;
            comboDateMatch.Items.AddRange(new object[] { "2023-12-10", "2023-12-03", "2023-11-27", "2023-10-28", "2023-10-22" });
            comboDateMatch.Location = new Point(12, 102);
            comboDateMatch.Name = "comboDateMatch";
            comboDateMatch.Size = new Size(121, 23);
            comboDateMatch.TabIndex = 5;
            comboDateMatch.SelectedIndexChanged += RadioInfoDateMatch_CheckedChanged;
            // 
            // RadioInfoDateMatch
            // 
            RadioInfoDateMatch.AutoSize = true;
            RadioInfoDateMatch.Location = new Point(139, 106);
            RadioInfoDateMatch.Name = "RadioInfoDateMatch";
            RadioInfoDateMatch.Size = new Size(152, 19);
            RadioInfoDateMatch.TabIndex = 6;
            RadioInfoDateMatch.TabStop = true;
            RadioInfoDateMatch.Text = "Матчі у конкретну дату";
            RadioInfoDateMatch.UseVisualStyleBackColor = true;
            RadioInfoDateMatch.CheckedChanged += RadioInfoDateMatch_CheckedChanged;
            // 
            // comboCommandName
            // 
            comboCommandName.FormattingEnabled = true;
            comboCommandName.Items.AddRange(new object[] { "Real Madrid", "Gerona", "Barcelona", "Atletico M", "Atletic B" });
            comboCommandName.Location = new Point(12, 131);
            comboCommandName.Name = "comboCommandName";
            comboCommandName.Size = new Size(121, 23);
            comboCommandName.TabIndex = 7;
            comboCommandName.SelectedIndexChanged += radioMatchesByCommand_CheckedChanged;
            // 
            // radioMatchesByCommand
            // 
            radioMatchesByCommand.AutoSize = true;
            radioMatchesByCommand.Location = new Point(139, 135);
            radioMatchesByCommand.Name = "radioMatchesByCommand";
            radioMatchesByCommand.Size = new Size(172, 19);
            radioMatchesByCommand.TabIndex = 8;
            radioMatchesByCommand.TabStop = true;
            radioMatchesByCommand.Text = "Матчі конкретної команди";
            radioMatchesByCommand.UseVisualStyleBackColor = true;
            radioMatchesByCommand.CheckedChanged += radioMatchesByCommand_CheckedChanged;
            // 
            // comboGoalsPlayerByDate
            // 
            comboGoalsPlayerByDate.FormattingEnabled = true;
            comboGoalsPlayerByDate.Items.AddRange(new object[] { "2023-12-10", "2023-12-03", "2023-11-27", "2023-10-28", "2023-10-22" });
            comboGoalsPlayerByDate.Location = new Point(12, 160);
            comboGoalsPlayerByDate.Name = "comboGoalsPlayerByDate";
            comboGoalsPlayerByDate.Size = new Size(121, 23);
            comboGoalsPlayerByDate.TabIndex = 9;
            comboGoalsPlayerByDate.SelectedIndexChanged += radioPlayersGoals_CheckedChanged;
            // 
            // radioPlayersGoals
            // 
            radioPlayersGoals.AutoSize = true;
            radioPlayersGoals.Location = new Point(139, 164);
            radioPlayersGoals.Name = "radioPlayersGoals";
            radioPlayersGoals.Size = new Size(180, 19);
            radioPlayersGoals.TabIndex = 10;
            radioPlayersGoals.TabStop = true;
            radioPlayersGoals.Text = "Гравці які забили у цей день";
            radioPlayersGoals.UseVisualStyleBackColor = true;
            radioPlayersGoals.CheckedChanged += radioPlayersGoals_CheckedChanged;
            // 
            // numericCommand1
            // 
            numericCommand1.Location = new Point(440, 33);
            numericCommand1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCommand1.Name = "numericCommand1";
            numericCommand1.Size = new Size(40, 23);
            numericCommand1.TabIndex = 11;
            numericCommand1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericCommand2
            // 
            numericCommand2.Location = new Point(498, 34);
            numericCommand2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericCommand2.Name = "numericCommand2";
            numericCommand2.Size = new Size(36, 23);
            numericCommand2.TabIndex = 12;
            numericCommand2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(440, 14);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 13;
            label1.Text = "Id 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(498, 16);
            label2.Name = "label2";
            label2.Size = new Size(29, 15);
            label2.TabIndex = 13;
            label2.Text = "Id 2:";
            // 
            // numericCommand1Goals
            // 
            numericCommand1Goals.Location = new Point(440, 78);
            numericCommand1Goals.Name = "numericCommand1Goals";
            numericCommand1Goals.Size = new Size(37, 23);
            numericCommand1Goals.TabIndex = 14;
            // 
            // numericCommand2Goals
            // 
            numericCommand2Goals.Location = new Point(498, 78);
            numericCommand2Goals.Name = "numericCommand2Goals";
            numericCommand2Goals.Size = new Size(35, 23);
            numericCommand2Goals.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 60);
            label3.Name = "label3";
            label3.Size = new Size(48, 15);
            label3.TabIndex = 16;
            label3.Text = "Goals 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(495, 61);
            label4.Name = "label4";
            label4.Size = new Size(48, 15);
            label4.TabIndex = 16;
            label4.Text = "Goals 2:";
            // 
            // textBoxAddDateMatch
            // 
            textBoxAddDateMatch.Location = new Point(440, 120);
            textBoxAddDateMatch.Name = "textBoxAddDateMatch";
            textBoxAddDateMatch.Size = new Size(93, 23);
            textBoxAddDateMatch.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 105);
            label5.Name = "label5";
            label5.Size = new Size(71, 15);
            label5.TabIndex = 18;
            label5.Text = "Date match:";
            // 
            // buttonAddMatch
            // 
            buttonAddMatch.Location = new Point(440, 149);
            buttonAddMatch.Name = "buttonAddMatch";
            buttonAddMatch.Size = new Size(94, 23);
            buttonAddMatch.TabIndex = 19;
            buttonAddMatch.Text = "Add";
            buttonAddMatch.UseVisualStyleBackColor = true;
            buttonAddMatch.Click += buttonAddMatch_Click;
            // 
            // RadioAllMathes
            // 
            RadioAllMathes.AutoSize = true;
            RadioAllMathes.Location = new Point(93, 14);
            RadioAllMathes.Name = "RadioAllMathes";
            RadioAllMathes.Size = new Size(74, 19);
            RadioAllMathes.TabIndex = 20;
            RadioAllMathes.TabStop = true;
            RadioAllMathes.Text = "Всі матчі";
            RadioAllMathes.UseVisualStyleBackColor = true;
            RadioAllMathes.CheckedChanged += RadioAllMathes_CheckedChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(611, 0);
            label6.Name = "label6";
            label6.Size = new Size(56, 15);
            label6.TabIndex = 21;
            label6.Text = "Id матчу:";
            // 
            // numericUpIdMatch
            // 
            numericUpIdMatch.Location = new Point(614, 18);
            numericUpIdMatch.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpIdMatch.Name = "numericUpIdMatch";
            numericUpIdMatch.Size = new Size(53, 23);
            numericUpIdMatch.TabIndex = 22;
            numericUpIdMatch.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(609, 45);
            label7.Name = "label7";
            label7.Size = new Size(29, 15);
            label7.TabIndex = 23;
            label7.Text = "Id 1:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(644, 45);
            label8.Name = "label8";
            label8.Size = new Size(29, 15);
            label8.TabIndex = 23;
            label8.Text = "Id 2:";
            // 
            // numericUpIdCommand1
            // 
            numericUpIdCommand1.Location = new Point(597, 63);
            numericUpIdCommand1.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpIdCommand1.Name = "numericUpIdCommand1";
            numericUpIdCommand1.Size = new Size(41, 23);
            numericUpIdCommand1.TabIndex = 24;
            numericUpIdCommand1.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // numericUpIdCommand2
            // 
            numericUpIdCommand2.Location = new Point(644, 63);
            numericUpIdCommand2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numericUpIdCommand2.Name = "numericUpIdCommand2";
            numericUpIdCommand2.Size = new Size(36, 23);
            numericUpIdCommand2.TabIndex = 25;
            numericUpIdCommand2.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(590, 89);
            label9.Name = "label9";
            label9.Size = new Size(48, 15);
            label9.TabIndex = 16;
            label9.Text = "Goals 1:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(644, 89);
            label10.Name = "label10";
            label10.Size = new Size(48, 15);
            label10.TabIndex = 16;
            label10.Text = "Goals 2:";
            // 
            // numericUpGoalsCommand1
            // 
            numericUpGoalsCommand1.Location = new Point(595, 105);
            numericUpGoalsCommand1.Name = "numericUpGoalsCommand1";
            numericUpGoalsCommand1.Size = new Size(41, 23);
            numericUpGoalsCommand1.TabIndex = 26;
            // 
            // numericUpGoalsCommand2
            // 
            numericUpGoalsCommand2.Location = new Point(645, 104);
            numericUpGoalsCommand2.Name = "numericUpGoalsCommand2";
            numericUpGoalsCommand2.Size = new Size(37, 23);
            numericUpGoalsCommand2.TabIndex = 27;
            // 
            // UpdateDateMatch
            // 
            UpdateDateMatch.Location = new Point(595, 133);
            UpdateDateMatch.Name = "UpdateDateMatch";
            UpdateDateMatch.Size = new Size(87, 23);
            UpdateDateMatch.TabIndex = 28;
            // 
            // buttonUpdate
            // 
            buttonUpdate.Location = new Point(595, 160);
            buttonUpdate.Name = "buttonUpdate";
            buttonUpdate.Size = new Size(87, 23);
            buttonUpdate.TabIndex = 29;
            buttonUpdate.Text = "Update";
            buttonUpdate.UseVisualStyleBackColor = true;
            buttonUpdate.Click += buttonUpdate_Click;
            // 
            // comboBoxDeleteByCommand1Name
            // 
            comboBoxDeleteByCommand1Name.FormattingEnabled = true;
            comboBoxDeleteByCommand1Name.Items.AddRange(new object[] { "Real Madrid", "Gerona", "Barcelona", "Atletico M", "Atletic B" });
            comboBoxDeleteByCommand1Name.Location = new Point(707, 37);
            comboBoxDeleteByCommand1Name.Name = "comboBoxDeleteByCommand1Name";
            comboBoxDeleteByCommand1Name.Size = new Size(121, 23);
            comboBoxDeleteByCommand1Name.TabIndex = 30;
            // 
            // comboBoxDeleteByDateMatch
            // 
            comboBoxDeleteByDateMatch.FormattingEnabled = true;
            comboBoxDeleteByDateMatch.Items.AddRange(new object[] { "12-10-2023", "12-03-2023", "11-27-2023", "10-28-2023", "10-22-2023" });
            comboBoxDeleteByDateMatch.Location = new Point(707, 122);
            comboBoxDeleteByDateMatch.Name = "comboBoxDeleteByDateMatch";
            comboBoxDeleteByDateMatch.Size = new Size(121, 23);
            comboBoxDeleteByDateMatch.TabIndex = 31;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(707, 14);
            label11.Name = "label11";
            label11.Size = new Size(99, 15);
            label11.TabIndex = 32;
            label11.Text = "Назва команди1:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(707, 102);
            label12.Name = "label12";
            label12.Size = new Size(36, 15);
            label12.TabIndex = 33;
            label12.Text = "Дати:";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(707, 166);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(121, 23);
            buttonDelete.TabIndex = 34;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += buttonDelete_Click;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(707, 61);
            label13.Name = "label13";
            label13.Size = new Size(99, 15);
            label13.TabIndex = 32;
            label13.Text = "Назва команди2:";
            // 
            // comboBoxDeleteByCommand2Name
            // 
            comboBoxDeleteByCommand2Name.FormattingEnabled = true;
            comboBoxDeleteByCommand2Name.Items.AddRange(new object[] { "Real Madrid", "Gerona", "Barcelona", "Atletico M", "Atletic B" });
            comboBoxDeleteByCommand2Name.Location = new Point(707, 79);
            comboBoxDeleteByCommand2Name.Name = "comboBoxDeleteByCommand2Name";
            comboBoxDeleteByCommand2Name.Size = new Size(121, 23);
            comboBoxDeleteByCommand2Name.TabIndex = 35;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(860, 450);
            Controls.Add(comboBoxDeleteByCommand2Name);
            Controls.Add(buttonDelete);
            Controls.Add(label12);
            Controls.Add(label13);
            Controls.Add(label11);
            Controls.Add(comboBoxDeleteByDateMatch);
            Controls.Add(comboBoxDeleteByCommand1Name);
            Controls.Add(buttonUpdate);
            Controls.Add(UpdateDateMatch);
            Controls.Add(numericUpGoalsCommand2);
            Controls.Add(numericUpGoalsCommand1);
            Controls.Add(numericUpIdCommand2);
            Controls.Add(numericUpIdCommand1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(numericUpIdMatch);
            Controls.Add(label6);
            Controls.Add(RadioAllMathes);
            Controls.Add(buttonAddMatch);
            Controls.Add(label5);
            Controls.Add(textBoxAddDateMatch);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(numericCommand2Goals);
            Controls.Add(numericCommand1Goals);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericCommand2);
            Controls.Add(numericCommand1);
            Controls.Add(radioPlayersGoals);
            Controls.Add(comboGoalsPlayerByDate);
            Controls.Add(radioMatchesByCommand);
            Controls.Add(comboCommandName);
            Controls.Add(RadioInfoDateMatch);
            Controls.Add(comboDateMatch);
            Controls.Add(RadioInfoAboutMatch);
            Controls.Add(ComboIdMatch);
            Controls.Add(GoalsDifference);
            Controls.Add(AllInfo);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCommand1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCommand2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCommand1Goals).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericCommand2Goals).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpIdMatch).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpIdCommand1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpIdCommand2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpGoalsCommand1).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpGoalsCommand2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private RadioButton AllInfo;
        private RadioButton GoalsDifference;
        private ComboBox ComboIdMatch;
        private RadioButton RadioInfoAboutMatch;
        private ComboBox comboDateMatch;
        private RadioButton RadioInfoDateMatch;
        private ComboBox comboCommandName;
        private RadioButton radioMatchesByCommand;
        private ComboBox comboGoalsPlayerByDate;
        private RadioButton radioPlayersGoals;
        private NumericUpDown numericCommand1;
        private NumericUpDown numericCommand2;
        private Label label1;
        private Label label2;
        private NumericUpDown numericCommand1Goals;
        private NumericUpDown numericCommand2Goals;
        private Label label3;
        private Label label4;
        private TextBox textBoxAddDateMatch;
        private Label label5;
        private Button buttonAddMatch;
        private RadioButton RadioAllMathes;
        private Label label6;
        private NumericUpDown numericUpIdMatch;
        private Label label7;
        private Label label8;
        private NumericUpDown numericUpIdCommand1;
        private NumericUpDown numericUpIdCommand2;
        private Label label9;
        private Label label10;
        private NumericUpDown numericUpGoalsCommand1;
        private NumericUpDown numericUpGoalsCommand2;
        private TextBox UpdateDateMatch;
        private Button buttonUpdate;
        private ComboBox comboBoxDeleteByCommand1Name;
        private ComboBox comboBoxDeleteByDateMatch;
        private Label label11;
        private Label label12;
        private Button buttonDelete;
        private Label label13;
        private ComboBox comboBoxDeleteByCommand2Name;
    }
}
