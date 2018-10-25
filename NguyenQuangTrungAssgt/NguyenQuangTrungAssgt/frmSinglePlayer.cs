using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NguyenQuangTrungAssgt
{
    public partial class frmSinglePlayer : Form
    {
        // variables for drawing dices
        Graphics graPaperOne;
        Graphics graPaperTwo;
        Pen penBlack = new Pen(Color.Black);
        SolidBrush brushWhite = new SolidBrush(Color.White);
        SolidBrush brushBlack = new SolidBrush(Color.Black);
        Random diceFace = new Random();

        // Player name
        string sPlayerName;
        // Goal Score
        int iGoalScore = 0;
        // Running Score
        int iRunningScore = 0;
        // Cummulative Scores
        int iPlayerScore = 0;
        int iProgramScore = 0;
        // Win Counts
        int iProgramWon = 0;
        int iPlayerWon = 0;
        int iTurn = 0;
        // 1: player lost dices, 2: program lost dices
        int iLostDices = 0;
        int iSnakeEyes = 0;
    
        // Constructor
        public frmSinglePlayer()
        {
            InitializeComponent();
            graPaperOne = pbxDiceOne.CreateGraphics();
            graPaperTwo = pbxDiceTwo.CreateGraphics();
            // disable RollDice, PassDice buttons before setting turn
            btnRollDice.Enabled = false;
            btnPassDice.Enabled = false;
        }

        // Public method to set goal and player name
        // to be called from frmGoal
        public void SetGoalAndName(int iGoal, string sName)
        {
            iGoalScore = iGoal;
            lblGoalScore.Text = Convert.ToString(iGoalScore);
            sPlayerName = sName;
            lblPlayer.Text = sPlayerName;
        }

        // Method to randomly set first turn
        public void SetTurn()
        {
            // 1 = player, 2 = program
            iTurn = diceFace.Next(1,3);
            DisplayTurn(iTurn);
        }

        // Method to change playing turn
        private void ChangeTurn()
        {
            // swap turn
            if (iTurn == 1) 
            {
                iTurn = 2;
            }
            // swap turn
            else if (iTurn == 2)
            {
                iTurn = 1;
            }
            // Clear dices display for other player
            graPaperOne.FillRectangle(brushWhite, 0, 0, 271, 271);
            graPaperTwo.FillRectangle(brushWhite, 0, 0, 271, 271);
            DisplayTurn(iTurn);
        }

        // Method to display player turn on form
        private void DisplayTurn(int iTurn)
        {
            if (iTurn == 1) // player's turn
            {
                lblPlayerTurn.Text = "YOUR TURN";
                lblComputerTurn.Text = "";
                // re-enable all buttons for player
                EnableButtons(true);
            }
            else if (iTurn == 2) // program's turn
            {
                lblComputerTurn.Text = "PROGRAM'S TURN"; 
                lblPlayerTurn.Text = "";
                // disable all buttons from player
                EnableButtons(false);
                // Check if either has reached goal
                if (iPlayerScore + iRunningScore < iGoalScore && iProgramScore + iRunningScore < iGoalScore)
                {
                    // call method for program to play
                    ProgramPlay();
                }           
            }            
        }

        // Method to draw dices on picturebox
        private void DisplayDiceFace(int iDiceOneNumber, int iDiceTwoNumber)
        {
            // Clear graPaper
            graPaperOne.FillRectangle(brushWhite, 0, 0, 162, 162);
            graPaperTwo.FillRectangle(brushWhite, 0, 0, 162, 162);
            // Draw outline
            graPaperOne.DrawRectangle(penBlack, 0, 0, 162, 162);
            graPaperTwo.DrawRectangle(penBlack, 0, 0, 162, 162);

            // Draw dice circles
            // center (1,3,5)
            if (iDiceOneNumber == 1 || iDiceOneNumber == 3 || iDiceOneNumber == 5) // dice 1
            {
                graPaperOne.FillEllipse(brushBlack, 71, 71, 24, 24);
            }

            if (iDiceTwoNumber == 1 || iDiceTwoNumber == 3 || iDiceTwoNumber == 5) // dice 2
            {
                graPaperTwo.FillEllipse(brushBlack, 71, 71, 24, 24);
            }

            // top left , bottom right (4,5,6)
            if (iDiceOneNumber == 4 || iDiceOneNumber == 5 || iDiceOneNumber == 6) // dice 1
            {
                graPaperOne.FillEllipse(brushBlack, 20, 20, 24, 24);  // top left
                graPaperOne.FillEllipse(brushBlack, 122, 122, 24, 24);// bottom right
            }
            if (iDiceTwoNumber == 4 || iDiceTwoNumber == 5 || iDiceTwoNumber == 6) // dice 2
            {
                graPaperTwo.FillEllipse(brushBlack, 20, 20, 24, 24);  // top left
                graPaperTwo.FillEllipse(brushBlack, 122, 122, 24, 24);// bottom right
            }

            // top right , bottom left (3,4,5,6)
            if (iDiceOneNumber == 3 || iDiceOneNumber == 4 || iDiceOneNumber == 5 || iDiceOneNumber == 6) // dice 1
            {
                graPaperOne.FillEllipse(brushBlack, 122, 20, 24, 24); //top right
                graPaperOne.FillEllipse(brushBlack, 20, 122, 24, 24); //bottom left
            }
            if (iDiceTwoNumber == 3 || iDiceTwoNumber == 4 || iDiceTwoNumber == 5 || iDiceTwoNumber == 6) // dice 2
            {
                graPaperTwo.FillEllipse(brushBlack, 122, 20, 24, 24); //top right
                graPaperTwo.FillEllipse(brushBlack, 20, 122, 24, 24); //bottom left
            }

            // middle left, middle right (2,6)
            if (iDiceOneNumber == 2 || iDiceOneNumber == 6) // dice 1
            {
                graPaperOne.FillEllipse(brushBlack, 20, 71, 24, 24); //middle left
                graPaperOne.FillEllipse(brushBlack, 122, 71, 24, 24);//middle right
            }
            if (iDiceTwoNumber == 2 || iDiceTwoNumber == 6) // dice 2
            {
                graPaperTwo.FillEllipse(brushBlack, 20, 71, 24, 24); //middle left
                graPaperTwo.FillEllipse(brushBlack, 122, 71, 24, 24);//middle right
            }
        }

        // Method to roll 2 dices
        private void RollDice()
        {
            int iDiceOneNumber = 0;
            int iDiceTwoNumber = 0;
            // roll dices for 10 times
            for (int i = 0; i < 10; i++)
            {
                iDiceOneNumber = diceFace.Next(1, 7);
                iDiceTwoNumber = diceFace.Next(1, 7);
                DisplayDiceFace(iDiceOneNumber, iDiceTwoNumber);
                // use a timer to show effect
                DiceTimer(200);
            }
            // calculate and display running score
            iRunningScore += iDiceOneNumber + iDiceTwoNumber;
            UpdateScoreDisplay();
            // check dice values
            CheckDiceNumbers(iDiceOneNumber, iDiceTwoNumber);            
        }

        // Method to pass dices
        private void PassDice()
        {
            // add running score to total score
            if (iTurn == 1)
            {
                iPlayerScore += iRunningScore;
            }
            else if (iTurn == 2)
            {
                iProgramScore += iRunningScore;
            }
            // swap turn and reset running score
            iRunningScore = 0;
            UpdateScoreDisplay();
            ChangeTurn();
        }

        // Method to check dice numbers rolled
        private void CheckDiceNumbers(int iDiceOneNumber, int iDiceTwoNumber)
        {
            // Double 1 is rolled (snake'eyes)
            if (iDiceOneNumber == 1 && iDiceTwoNumber == 1)
            {
                if (iTurn == 1) // player's turn
                {
                    iPlayerScore = 0; // reset total score
                    lblPlayerScoreDisplay.Text = Convert.ToString(iPlayerScore);
                    MessageBox.Show("Snake Eyes! You lose everything!");
                    iSnakeEyes = 1;  // 1 = player 
                }
                else if (iTurn == 2) // program's turn
                {
                    iProgramScore = 0; // reset total score
                    lblProgramScoreDisplay.Text = Convert.ToString(iProgramScore);
                    MessageBox.Show("Snake Eyes! Program loses everything!");
                    iSnakeEyes = 2; // 2 = program 
                }
                // reset running score & change turn
                iRunningScore = 0;
                UpdateScoreDisplay();
                ChangeTurn();
            }

            // Single 1 is rolled (loses dices)
            else if (iDiceOneNumber == 1 && iDiceTwoNumber != 1 || iDiceTwoNumber == 1 && iDiceOneNumber != 1)
            {
                if (iTurn == 1) // player's turn
                {
                    MessageBox.Show("You lose dices!");
                    iLostDices = 1;
                }
                else if (iTurn == 2) // program's turn
                {
                    MessageBox.Show("Program loses dices!");
                    iLostDices = 2;
                }
                // reset running score, change turn
                iRunningScore = 0;
                UpdateScoreDisplay();
                ChangeTurn();
            }

            // Reaching goal score
            else if (iTurn == 1 && iPlayerScore + iRunningScore >= iGoalScore) // player
            {
                iPlayerScore += iRunningScore; // update total score
                MessageBox.Show("You won! Click OK to start a new game");
                iPlayerWon++; // update win count
                SetNewGame();
            }
            else if (iTurn == 2 && iProgramScore + iRunningScore >= iGoalScore) // program
            {
                iProgramScore += iRunningScore; // update total score
                MessageBox.Show("You lost! Click OK to start a new game");
                iProgramWon++; // update win count
                SetNewGame();
            }
        }

        // Method for program playing strategy
        private void ProgramPlay()
        {
            // when program plays, disable these buttons from players
            // roll dices 1st time
            ProgramRollDice();
            // check if program didn't lose dices & not yet won
            if(iLostDices != 2 && iSnakeEyes != 2 && iRunningScore != 0)
            {
                // if program's score < 80% of goal score
                if (iProgramScore + iRunningScore < iGoalScore * 0.8)
                {
                    // if player lost dices 
                    // OR first roll < 8 
                    // OR just lost everything
                    // OR program's score < 50%  goal, player's score > 80%  goal
                    if (iLostDices == 1 || iSnakeEyes == 1 || iRunningScore < 8 || iRunningScore > iProgramScore
                    || iProgramScore + iRunningScore < iGoalScore * 0.5 && iPlayerScore >= iGoalScore * 0.8)
                    {
                        // roll dices 2nd time
                        ProgramRollDice();
                        // re-check if program didn't lose dices & not yet won
                        if (iLostDices != 2 && iSnakeEyes != 2 && iRunningScore != 0)
                        {
                            // only if goal > 60 and program score's < 50% goal, player's score > 80% goal
                            if (iGoalScore > 60 && iProgramScore + iRunningScore < iGoalScore * 0.5
                                && iPlayerScore >= iGoalScore * 0.8)
                            {
                                // roll dices 3rd time
                                ProgramRollDice();
                                // re-check if program didn't lose dices & not yet won
                                if (iLostDices != 2 && iSnakeEyes != 2 && iRunningScore != 0)
                                {
                                    // after 3 rolls max, pass dice
                                    PassDice();
                                }
                            }
                            else // after 2 rolls
                            {   
                                PassDice();
                            }                           
                        }
                    }
                    else // score < 80% but not met above conditions
                    {
                        PassDice();
                    }                     
                }
                else // score > 80% goal
                {
                    PassDice();
                }
            }          
            // reset for next round
            iLostDices = 0;
            iSnakeEyes = 0;
        }

        // Method for program to roll dice
        private void ProgramRollDice()
        {
            // use a timer to show effect
            DiceTimer(1000);
            RollDice(); // roll dices 
            lblRunningScore.Text = Convert.ToString(iRunningScore);
            // use a timer to show effect
            DiceTimer(1000);
        }

        // Method to use timer for rolling dice
        private void DiceTimer(int iMillisecs)
        {
            Application.DoEvents();
            System.Threading.Thread.Sleep(iMillisecs);
        }

        // Method to set a new game with reset score/turn
        private void SetNewGame()
        {
            // clear graPaper of dices display
            graPaperOne.FillRectangle(brushWhite, 0, 0, 271, 271);
            graPaperTwo.FillRectangle(brushWhite, 0, 0, 271, 271);
            ResetScores();
            SetTurn();
        }

        // Method to reset all scores to 0
        private void ResetScores()
        {
            // reset all scores
            iRunningScore = 0;
            iPlayerScore = 0;
            iProgramScore = 0;
            UpdateScoreDisplay();
        }

        // Method to update all score displays in the form
        private void UpdateScoreDisplay()
        {
            lblPlayerWinCount.Text = Convert.ToString(iPlayerWon);
            lblProgramWinCount.Text = Convert.ToString(iProgramWon);
            lblRunningScore.Text = Convert.ToString(iRunningScore);
            lblPlayerScoreDisplay.Text = Convert.ToString(iPlayerScore);
            lblProgramScoreDisplay.Text = Convert.ToString(iProgramScore);
        }

        // BUTTONS CLICK EVENT HANDLERS

        // Player clicks ROLL DICE button
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            // when dices are rolling, disable NEW GAME, CHANGE GOAL, PASS DICE buttons
            EnableButtons(false);
            RollDice();
            // after dices rolled, re-enable NEW GAME, CHANGE GOAL, PASS DICE buttons
            EnableButtons(true);
        }

        // Method to enable or disable all buttons
        private void EnableButtons(bool bButtonStatus)
        {
            // enable all buttons
            if (bButtonStatus)
            {
                btnRollDice.Enabled = true;
                btnPassDice.Enabled = true;
                btnNewGame.Enabled = true;
                btnChangeGoal.Enabled = true;
            }
            // disable all buttons
            else if (!bButtonStatus)
            {
                btnRollDice.Enabled = false;
                btnPassDice.Enabled = false;
                btnNewGame.Enabled = false;
                btnChangeGoal.Enabled = false;
            }
        }

        // Player clicks PASS DICE button
        private void btnPassDice_Click(object sender, EventArgs e)
        {
            PassDice();
        }

        // Player clicks SET TURN/ RESET button
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            if (btnNewGame.Text == "SET TURN") 
            {
                SetTurn();                  // after first turn is set
                btnNewGame.Text = "RESET";  // change button text to RESET
            }
            else if (btnNewGame.Text == "RESET")
            {
                SetNewGame();
            }
        }

        // Player clicks CHANGE GOAL button
        private void btnChangeGoal_Click(object sender, EventArgs e)
        {
            ResetScores();
            // goes back to frmGoal
            this.Close();
        }
    }
}
