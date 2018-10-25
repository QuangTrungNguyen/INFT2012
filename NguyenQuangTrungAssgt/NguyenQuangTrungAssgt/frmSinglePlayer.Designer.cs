namespace NguyenQuangTrungAssgt
{
    partial class frmSinglePlayer
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
            this.lblRunningScore = new System.Windows.Forms.Label();
            this.lblGoalScore = new System.Windows.Forms.Label();
            this.btnPassDice = new System.Windows.Forms.Button();
            this.lblGoal = new System.Windows.Forms.Label();
            this.lblRunning = new System.Windows.Forms.Label();
            this.btnRollDice = new System.Windows.Forms.Button();
            this.pbxDiceTwo = new System.Windows.Forms.PictureBox();
            this.pbxDiceOne = new System.Windows.Forms.PictureBox();
            this.lblProgramWinCount = new System.Windows.Forms.Label();
            this.lblPlayerWinCount = new System.Windows.Forms.Label();
            this.lblProgramWon = new System.Windows.Forms.Label();
            this.lblPlayerWon = new System.Windows.Forms.Label();
            this.lblProgramScoreDisplay = new System.Windows.Forms.Label();
            this.lblPlayerScoreDisplay = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnChangeGoal = new System.Windows.Forms.Button();
            this.lblComputerTurn = new System.Windows.Forms.Label();
            this.lblPlayerTurn = new System.Windows.Forms.Label();
            this.lblProgramScore = new System.Windows.Forms.Label();
            this.lblPlayerScore = new System.Windows.Forms.Label();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblPlayer = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceOne)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRunningScore
            // 
            this.lblRunningScore.AutoSize = true;
            this.lblRunningScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunningScore.ForeColor = System.Drawing.Color.Crimson;
            this.lblRunningScore.Location = new System.Drawing.Point(412, 66);
            this.lblRunningScore.Name = "lblRunningScore";
            this.lblRunningScore.Size = new System.Drawing.Size(27, 29);
            this.lblRunningScore.TabIndex = 30;
            this.lblRunningScore.Text = "0";
            // 
            // lblGoalScore
            // 
            this.lblGoalScore.AutoSize = true;
            this.lblGoalScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoalScore.ForeColor = System.Drawing.Color.Crimson;
            this.lblGoalScore.Location = new System.Drawing.Point(412, 25);
            this.lblGoalScore.Name = "lblGoalScore";
            this.lblGoalScore.Size = new System.Drawing.Size(41, 29);
            this.lblGoalScore.TabIndex = 29;
            this.lblGoalScore.Text = "50";
            // 
            // btnPassDice
            // 
            this.btnPassDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassDice.Location = new System.Drawing.Point(407, 475);
            this.btnPassDice.Name = "btnPassDice";
            this.btnPassDice.Size = new System.Drawing.Size(149, 52);
            this.btnPassDice.TabIndex = 28;
            this.btnPassDice.Text = "PASS";
            this.btnPassDice.UseVisualStyleBackColor = true;
            this.btnPassDice.Click += new System.EventHandler(this.btnPassDice_Click);
            // 
            // lblGoal
            // 
            this.lblGoal.AutoSize = true;
            this.lblGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGoal.Location = new System.Drawing.Point(319, 29);
            this.lblGoal.Name = "lblGoal";
            this.lblGoal.Size = new System.Drawing.Size(81, 25);
            this.lblGoal.TabIndex = 27;
            this.lblGoal.Text = "GOAL:";
            // 
            // lblRunning
            // 
            this.lblRunning.AutoSize = true;
            this.lblRunning.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRunning.Location = new System.Drawing.Point(169, 70);
            this.lblRunning.Name = "lblRunning";
            this.lblRunning.Size = new System.Drawing.Size(208, 25);
            this.lblRunning.TabIndex = 26;
            this.lblRunning.Text = "RUNNING SCORE:";
            // 
            // btnRollDice
            // 
            this.btnRollDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRollDice.Location = new System.Drawing.Point(228, 475);
            this.btnRollDice.Name = "btnRollDice";
            this.btnRollDice.Size = new System.Drawing.Size(149, 52);
            this.btnRollDice.TabIndex = 25;
            this.btnRollDice.Text = "ROLL";
            this.btnRollDice.UseVisualStyleBackColor = true;
            this.btnRollDice.Click += new System.EventHandler(this.btnRollDice_Click);
            // 
            // pbxDiceTwo
            // 
            this.pbxDiceTwo.Location = new System.Drawing.Point(407, 137);
            this.pbxDiceTwo.Name = "pbxDiceTwo";
            this.pbxDiceTwo.Size = new System.Drawing.Size(300, 300);
            this.pbxDiceTwo.TabIndex = 24;
            this.pbxDiceTwo.TabStop = false;
            // 
            // pbxDiceOne
            // 
            this.pbxDiceOne.Location = new System.Drawing.Point(77, 137);
            this.pbxDiceOne.Name = "pbxDiceOne";
            this.pbxDiceOne.Size = new System.Drawing.Size(300, 300);
            this.pbxDiceOne.TabIndex = 23;
            this.pbxDiceOne.TabStop = false;
            // 
            // lblProgramWinCount
            // 
            this.lblProgramWinCount.AutoSize = true;
            this.lblProgramWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramWinCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblProgramWinCount.Location = new System.Drawing.Point(577, 839);
            this.lblProgramWinCount.Name = "lblProgramWinCount";
            this.lblProgramWinCount.Size = new System.Drawing.Size(27, 29);
            this.lblProgramWinCount.TabIndex = 44;
            this.lblProgramWinCount.Text = "0";
            // 
            // lblPlayerWinCount
            // 
            this.lblPlayerWinCount.AutoSize = true;
            this.lblPlayerWinCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWinCount.ForeColor = System.Drawing.Color.Crimson;
            this.lblPlayerWinCount.Location = new System.Drawing.Point(185, 839);
            this.lblPlayerWinCount.Name = "lblPlayerWinCount";
            this.lblPlayerWinCount.Size = new System.Drawing.Size(27, 29);
            this.lblPlayerWinCount.TabIndex = 43;
            this.lblPlayerWinCount.Text = "0";
            // 
            // lblProgramWon
            // 
            this.lblProgramWon.AutoSize = true;
            this.lblProgramWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramWon.Location = new System.Drawing.Point(564, 803);
            this.lblProgramWon.Name = "lblProgramWon";
            this.lblProgramWon.Size = new System.Drawing.Size(65, 25);
            this.lblProgramWon.TabIndex = 42;
            this.lblProgramWon.Text = "WON";
            // 
            // lblPlayerWon
            // 
            this.lblPlayerWon.AutoSize = true;
            this.lblPlayerWon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerWon.Location = new System.Drawing.Point(165, 803);
            this.lblPlayerWon.Name = "lblPlayerWon";
            this.lblPlayerWon.Size = new System.Drawing.Size(65, 25);
            this.lblPlayerWon.TabIndex = 41;
            this.lblPlayerWon.Text = "WON";
            // 
            // lblProgramScoreDisplay
            // 
            this.lblProgramScoreDisplay.AutoSize = true;
            this.lblProgramScoreDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramScoreDisplay.ForeColor = System.Drawing.Color.Crimson;
            this.lblProgramScoreDisplay.Location = new System.Drawing.Point(577, 724);
            this.lblProgramScoreDisplay.Name = "lblProgramScoreDisplay";
            this.lblProgramScoreDisplay.Size = new System.Drawing.Size(27, 29);
            this.lblProgramScoreDisplay.TabIndex = 40;
            this.lblProgramScoreDisplay.Text = "0";
            // 
            // lblPlayerScoreDisplay
            // 
            this.lblPlayerScoreDisplay.AutoSize = true;
            this.lblPlayerScoreDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScoreDisplay.ForeColor = System.Drawing.Color.Crimson;
            this.lblPlayerScoreDisplay.Location = new System.Drawing.Point(185, 724);
            this.lblPlayerScoreDisplay.Name = "lblPlayerScoreDisplay";
            this.lblPlayerScoreDisplay.Size = new System.Drawing.Size(27, 29);
            this.lblPlayerScoreDisplay.TabIndex = 39;
            this.lblPlayerScoreDisplay.Text = "0";
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(407, 900);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(149, 68);
            this.btnNewGame.TabIndex = 38;
            this.btnNewGame.Text = "SET TURN";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnChangeGoal
            // 
            this.btnChangeGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeGoal.Location = new System.Drawing.Point(228, 900);
            this.btnChangeGoal.Name = "btnChangeGoal";
            this.btnChangeGoal.Size = new System.Drawing.Size(149, 68);
            this.btnChangeGoal.TabIndex = 37;
            this.btnChangeGoal.Text = "CHANGE GOAL";
            this.btnChangeGoal.UseVisualStyleBackColor = true;
            this.btnChangeGoal.Click += new System.EventHandler(this.btnChangeGoal_Click);
            // 
            // lblComputerTurn
            // 
            this.lblComputerTurn.AutoSize = true;
            this.lblComputerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerTurn.ForeColor = System.Drawing.Color.Crimson;
            this.lblComputerTurn.Location = new System.Drawing.Point(437, 627);
            this.lblComputerTurn.Name = "lblComputerTurn";
            this.lblComputerTurn.Size = new System.Drawing.Size(0, 32);
            this.lblComputerTurn.TabIndex = 36;
            // 
            // lblPlayerTurn
            // 
            this.lblPlayerTurn.AutoSize = true;
            this.lblPlayerTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerTurn.ForeColor = System.Drawing.Color.Crimson;
            this.lblPlayerTurn.Location = new System.Drawing.Point(95, 627);
            this.lblPlayerTurn.Name = "lblPlayerTurn";
            this.lblPlayerTurn.Size = new System.Drawing.Size(0, 32);
            this.lblPlayerTurn.TabIndex = 35;
            // 
            // lblProgramScore
            // 
            this.lblProgramScore.AutoSize = true;
            this.lblProgramScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgramScore.Location = new System.Drawing.Point(455, 690);
            this.lblProgramScore.Name = "lblProgramScore";
            this.lblProgramScore.Size = new System.Drawing.Size(252, 25);
            this.lblProgramScore.TabIndex = 34;
            this.lblProgramScore.Text = "CUMMULATIVE SCORE";
            // 
            // lblPlayerScore
            // 
            this.lblPlayerScore.AutoSize = true;
            this.lblPlayerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerScore.Location = new System.Drawing.Point(72, 690);
            this.lblPlayerScore.Name = "lblPlayerScore";
            this.lblPlayerScore.Size = new System.Drawing.Size(252, 25);
            this.lblPlayerScore.TabIndex = 33;
            this.lblPlayerScore.Text = "CUMMULATIVE SCORE";
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Cooper Black", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(453, 572);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(243, 42);
            this.lblProgram.TabIndex = 32;
            this.lblProgram.Text = "COMPUTER";
            // 
            // lblPlayer
            // 
            this.lblPlayer.Font = new System.Drawing.Font("Cooper Black", 15.85714F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer.Location = new System.Drawing.Point(66, 572);
            this.lblPlayer.Name = "lblPlayer";
            this.lblPlayer.Size = new System.Drawing.Size(267, 42);
            this.lblPlayer.TabIndex = 31;
            this.lblPlayer.Text = "YOU";
            this.lblPlayer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmSinglePlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 1011);
            this.Controls.Add(this.lblProgramWinCount);
            this.Controls.Add(this.lblPlayerWinCount);
            this.Controls.Add(this.lblProgramWon);
            this.Controls.Add(this.lblPlayerWon);
            this.Controls.Add(this.lblProgramScoreDisplay);
            this.Controls.Add(this.lblPlayerScoreDisplay);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.btnChangeGoal);
            this.Controls.Add(this.lblComputerTurn);
            this.Controls.Add(this.lblPlayerTurn);
            this.Controls.Add(this.lblProgramScore);
            this.Controls.Add(this.lblPlayerScore);
            this.Controls.Add(this.lblProgram);
            this.Controls.Add(this.lblPlayer);
            this.Controls.Add(this.lblRunningScore);
            this.Controls.Add(this.lblGoalScore);
            this.Controls.Add(this.btnPassDice);
            this.Controls.Add(this.lblGoal);
            this.Controls.Add(this.lblRunning);
            this.Controls.Add(this.btnRollDice);
            this.Controls.Add(this.pbxDiceTwo);
            this.Controls.Add(this.pbxDiceOne);
            this.Name = "frmSinglePlayer";
            this.Text = "GROAN";
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDiceOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblRunningScore;
        private System.Windows.Forms.Label lblGoalScore;
        private System.Windows.Forms.Button btnPassDice;
        private System.Windows.Forms.Label lblGoal;
        private System.Windows.Forms.Label lblRunning;
        private System.Windows.Forms.Button btnRollDice;
        private System.Windows.Forms.PictureBox pbxDiceTwo;
        private System.Windows.Forms.PictureBox pbxDiceOne;
        private System.Windows.Forms.Label lblProgramWinCount;
        private System.Windows.Forms.Label lblPlayerWinCount;
        private System.Windows.Forms.Label lblProgramWon;
        private System.Windows.Forms.Label lblPlayerWon;
        private System.Windows.Forms.Label lblProgramScoreDisplay;
        private System.Windows.Forms.Label lblPlayerScoreDisplay;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnChangeGoal;
        private System.Windows.Forms.Label lblComputerTurn;
        private System.Windows.Forms.Label lblPlayerTurn;
        private System.Windows.Forms.Label lblProgramScore;
        private System.Windows.Forms.Label lblPlayerScore;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblPlayer;
    }
}