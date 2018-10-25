namespace NguyenQuangTrungAssgt
{
    partial class frmTwoPlayers
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbxDiceOne = new System.Windows.Forms.PictureBox();
            this.pbxDiceTwo = new System.Windows.Forms.PictureBox();
            this.lblPlayerOne = new System.Windows.Forms.Label();
            this.lblPlayerTwo = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.lblPlayerScore1 = new System.Windows.Forms.Label();
            this.lblPlayerScore2 = new System.Windows.Forms.Label();
            this.btnPassDice = new System.Windows.Forms.Button();
            this.lblPlayerOneTurn = new System.Windows.Forms.Label();
            this.lblPlayerTwoTurn = new System.Windows.Forms.Label();
            this.btnChangeGoal = new System.Windows.Forms.Button();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.lblScoreDisplay1 = new System.Windows.Forms.Label();
            this.lblScoreDisplay2 = new System.Windows.Forms.Label();
            this.lblPlayerWin1 = new System.Windows.Forms.Label();
            this.lblWinCount2 = new System.Windows.Forms.Label();
            this.lblWinCount1 = new System.Windows.Forms.Label();
            this.lblWinDisplayTwo = new System.Windows.Forms.Label();
            this.lblRunningScore = new System.Windows.Forms.Label();
            this.lblGoalScore = new System.Windows.Forms.Label();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblRunning = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceOne)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceTwo)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxDiceOne
            // 
            this.pbxDiceOne.Location = new System.Drawing.Point(82, 147);
            this.pbxDiceOne.Name = "pbxDiceOne";
            this.pbxDiceOne.Size = new System.Drawing.Size(300, 300);
            this.pbxDiceOne.TabIndex = 0;
            this.pbxDiceOne.TabStop = false;
            // 
            // pbxDiceTwo
            // 
            this.pbxDiceTwo.Location = new System.Drawing.Point(412, 147);
            this.pbxDiceTwo.Name = "pbxDiceTwo";
            this.pbxDiceTwo.Size = new System.Drawing.Size(300, 300);
            this.pbxDiceTwo.TabIndex = 1;
            this.pbxDiceTwo.TabStop = false;
            // 
            // lblPlayerOne
            // 
            this.lblPlayerOne.Font = new System.Drawing.Font("Cooper Black", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOne.Location = new System.Drawing.Point(75, 572);
            this.lblPlayerOne.Name = "lblPlayerOne";
            this.lblPlayerOne.Size = new System.Drawing.Size(318, 42);
            this.lblPlayerOne.TabIndex = 2;
            this.lblPlayerOne.Text = "PLAYER 1";
            this.lblPlayerOne.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPlayerTwo
            // 
            this.lblPlayerTwo.Font = new System.Drawing.Font("Cooper Black", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwo.Location = new System.Drawing.Point(428, 572);
            this.lblPlayerTwo.Name = "lblPlayerTwo";
            this.lblPlayerTwo.Size = new System.Drawing.Size(302, 42);
            this.lblPlayerTwo.TabIndex = 3;
            this.lblPlayerTwo.Text = "PLAYER 2";
            this.lblPlayerTwo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRollDice
            // 
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(233, 481);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(149, 52);
            this.btnRollDice.TabIndex = 4;
            this.btnRollDice.Text = "ROLL";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // lblPlayerScore1
            // 
            this.lblPlayerScore1.AutoSize = true;
            this.lblPlayerScore1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore1.Location = new System.Drawing.Point(97, 704);
            this.lblPlayerScore1.Name = "lblPlayerScore1";
            this.lblPlayerScore1.Size = new System.Drawing.Size(262, 25);
            this.lblPlayerScore1.TabIndex = 5;
            this.lblPlayerScore1.Text = "CUMMULATIVE SCORE";
            // 
            // lblPlayerScore2
            // 
            this.lblPlayerScore2.AutoSize = true;
            this.lblPlayerScore2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore2.Location = new System.Drawing.Point(441, 704);
            this.lblPlayerScore2.Name = "lblPlayerScore2";
            this.lblPlayerScore2.Size = new System.Drawing.Size(262, 25);
            this.lblPlayerScore2.TabIndex = 6;
            this.lblPlayerScore2.Text = "CUMMULATIVE SCORE";
            // 
            // btnPassDice
            // 
            this.btnPassDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassDice.Location = new System.Drawing.Point(412, 481);
            this.btnPassDice.Name = "btnPassDice";
            this.btnPassDice.Size = new System.Drawing.Size(149, 52);
            this.btnPassDice.TabIndex = 16;
            this.btnPassDice.Text = "PASS";
            this.btnPassDice.UseVisualStyleBackColor = true;
            this.btnPassDice.Click += new System.EventHandler(this.btnPassDice_Click);
            // 
            // lblPlayerOneTurn
            // 
            this.lblPlayerOneTurn.AutoSize = true;
            this.lblPlayerOneTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerOneTurn.ForeColor = System.Drawing.Color.Crimson;
            this.lblPlayerOneTurn.Location = new System.Drawing.Point(126, 642);
            this.lblPlayerOneTurn.Name = "lblPlayerOneTurn";
            this.lblPlayerOneTurn.Size = new System.Drawing.Size(0, 32);
            this.lblPlayerOneTurn.TabIndex = 17;
            // 
            // lblPlayerTwoTurn
            // 
            this.lblPlayerTwoTurn.AutoSize = true;
            this.lblPlayerTwoTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTwoTurn.ForeColor = System.Drawing.Color.Crimson;
            this.lblPlayerTwoTurn.Location = new System.Drawing.Point(482, 642);
            this.lblPlayerTwoTurn.Name = "lblPlayerTwoTurn";
            this.lblPlayerTwoTurn.Size = new System.Drawing.Size(0, 32);
            this.lblPlayerTwoTurn.TabIndex = 18;
            // 
            // btnChangeGoal
            // 
            this.btnChangeGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeGoal.Location = new System.Drawing.Point(233, 913);
            this.btnChangeGoal.Name = "btnChangeGoal";
            this.btnChangeGoal.Size = new System.Drawing.Size(149, 68);
            this.btnChangeGoal.TabIndex = 19;
            this.btnChangeGoal.Text = "CHANGE GOAL";
            this.btnChangeGoal.UseVisualStyleBackColor = true;
            this.btnChangeGoal.Click += new System.EventHandler(this.btnChangeGoal_Click);
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(412, 913);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(149, 68);
            this.btnNewGame.TabIndex = 20;
            this.btnNewGame.Text = "RESET";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // lblScoreDisplay1
            // 
            this.lblScoreDisplay1.AutoSize = true;
            this.lblScoreDisplay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreDisplay1.ForeColor = System.Drawing.Color.Crimson;
            this.lblScoreDisplay1.Location = new System.Drawing.Point(190, 738);
            this.lblScoreDisplay1.Name = "lblScoreDisplay1";
            this.lblScoreDisplay1.Size = new System.Drawing.Size(27, 29);
            this.lblScoreDisplay1.TabIndex = 23;
            this.lblScoreDisplay1.Text = "0";
            // 
            // lblScoreDisplay2
            // 
            this.lblScoreDisplay2.AutoSize = true;
            this.lblScoreDisplay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreDisplay2.ForeColor = System.Drawing.Color.Crimson;
            this.lblScoreDisplay2.Location = new System.Drawing.Point(563, 738);
            this.lblScoreDisplay2.Name = "lblScoreDisplay2";
            this.lblScoreDisplay2.Size = new System.Drawing.Size(27, 29);
            this.lblScoreDisplay2.TabIndex = 24;
            this.lblScoreDisplay2.Text = "0";
            // 
            // lblPlayerWin1
            // 
            this.lblPlayerWin1.AutoSize = true;
            this.lblPlayerWin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWin1.Location = new System.Drawing.Point(170, 817);
            this.lblPlayerWin1.Name = "lblPlayerWin1";
            this.lblPlayerWin1.Size = new System.Drawing.Size(66, 25);
            this.lblPlayerWin1.TabIndex = 25;
            this.lblPlayerWin1.Text = "WON";
            // 
            // lblWinCount2
            // 
            this.lblWinCount2.AutoSize = true;
            this.lblWinCount2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinCount2.Location = new System.Drawing.Point(550, 817);
            this.lblWinCount2.Name = "lblWinCount2";
            this.lblWinCount2.Size = new System.Drawing.Size(66, 25);
            this.lblWinCount2.TabIndex = 26;
            this.lblWinCount2.Text = "WON";
            // 
            // lblWinCount1
            // 
            this.lblWinCount1.AutoSize = true;
            this.lblWinCount1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinCount1.ForeColor = System.Drawing.Color.Crimson;
            this.lblWinCount1.Location = new System.Drawing.Point(190, 853);
            this.lblWinCount1.Name = "lblWinCount1";
            this.lblWinCount1.Size = new System.Drawing.Size(27, 29);
            this.lblWinCount1.TabIndex = 27;
            this.lblWinCount1.Text = "0";
            // 
            // lblWinDisplayTwo
            // 
            this.lblWinDisplayTwo.AutoSize = true;
            this.lblWinDisplayTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinDisplayTwo.ForeColor = System.Drawing.Color.Crimson;
            this.lblWinDisplayTwo.Location = new System.Drawing.Point(563, 853);
            this.lblWinDisplayTwo.Name = "lblWinDisplayTwo";
            this.lblWinDisplayTwo.Size = new System.Drawing.Size(27, 29);
            this.lblWinDisplayTwo.TabIndex = 28;
            this.lblWinDisplayTwo.Text = "0";
            // 
            // lblRunningScore
            // 
            this.lblRunningScore.AutoSize = true;
            this.lblRunningScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningScore.ForeColor = System.Drawing.Color.Crimson;
            this.lblRunningScore.Location = new System.Drawing.Point(409, 76);
            this.lblRunningScore.Name = "lblRunningScore";
            this.lblRunningScore.Size = new System.Drawing.Size(27, 29);
            this.lblRunningScore.TabIndex = 34;
            this.lblRunningScore.Text = "0";
            // 
            // lblGoalScore
            // 
            this.lblGoalScore.AutoSize = true;
            this.lblGoalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalScore.ForeColor = System.Drawing.Color.Crimson;
            this.lblGoalScore.Location = new System.Drawing.Point(409, 34);
            this.lblGoalScore.Name = "lblGoalScore";
            this.lblGoalScore.Size = new System.Drawing.Size(41, 29);
            this.lblGoalScore.TabIndex = 33;
            this.lblGoalScore.Text = "50";
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(301, 38);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(81, 25);
            this.lblGoal.TabIndex = 32;
            this.lblGoal.Text = "GOAL:";
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.Location = new System.Drawing.Point(156, 79);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(208, 25);
            this.lblRunning.TabIndex = 31;
            this.lblRunning.Text = "RUNNING SCORE:";
            // 
            // frmTwoPlayers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 1011);
            this.Controls.Add(this.lblRunningScore);
            this.Controls.Add(this.lblGoalScore);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.lblWinDisplayTwo);
            this.Controls.Add(this.lblWinCount1);
            this.Controls.Add(this.lblWinCount2);
            this.Controls.Add(this.lblPlayerWin1);
            this.Controls.Add(this.lblScoreDisplay2);
            this.Controls.Add(this.lblScoreDisplay1);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnChangeGoal);
            this.Controls.Add(this.lblPlayerTwoTurn);
            this.Controls.Add(this.lblPlayerOneTurn);
            this.Controls.Add(this.btnPassDice);
            this.Controls.Add(this.lblPlayerScore2);
            this.Controls.Add(this.lblPlayerScore1);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.lblPlayerTwo);
            this.Controls.Add(this.lblPlayerOne);
            this.Controls.Add(this.pbxDiceTwo);
            this.Controls.Add(this.pbxDiceOne);
            this.Name = "frmTwoPlayers";
            this.Text = "GROAN";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceTwo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxDiceOne;
        private System.Windows.Forms.PictureBox pbxDiceTwo;
        private System.Windows.Forms.Label lblPlayerOne;
        private System.Windows.Forms.Label lblPlayerTwo;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.Label lblPlayerScore1;
        private System.Windows.Forms.Label lblPlayerScore2;
        private System.Windows.Forms.Button btnPassDice;
        private System.Windows.Forms.Label lblPlayerOneTurn;
        private System.Windows.Forms.Label lblPlayerTwoTurn;
        private System.Windows.Forms.Button btnChangeGoal;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Label lblScoreDisplay1;
        private System.Windows.Forms.Label lblScoreDisplay2;
        private System.Windows.Forms.Label lblPlayerWin1;
        private System.Windows.Forms.Label lblWinCount2;
        private System.Windows.Forms.Label lblWinCount1;
        private System.Windows.Forms.Label lblWinDisplayTwo;
        private System.Windows.Forms.Label lblRunningScore;
        private System.Windows.Forms.Label lblGoalScore;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblRunning;
    }
}

