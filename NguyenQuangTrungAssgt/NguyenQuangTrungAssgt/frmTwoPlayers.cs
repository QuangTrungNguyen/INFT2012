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
    public partial class frmTwoPlayers : Form
    {
        // Class variables
        // variables for drawing dices
        Graphics graPaperOne;
        Graphics graPaperTwo;
        Pen penBlack = new Pen(Color.Black);
        SolidBrush brushWhite = new SolidBrush(Color.White);
        SolidBrush brushBlack = new SolidBrush(Color.Black);
        Random diceFace = new Random();

        // players names
        string sPlayerName1;
        string sPlayerName2;
        // Goal Score
        int iGoalScore = 0;
        // Running Score
        int iRunningScore = 0; 
        // Cummulative Scores
        int iTotalScore1 = 0;
        int iTotalScore2 = 0;            
        // Win Counts
        int iWinCount1 = 0;
        int iWinCount2 = 0;
        // Player turn (1=Player1, 2=Player2)
        int iTurn = 0;

        // Constructor
        public frmTwoPlayers()
        {            
            InitializeComponent();
            graPaperOne = pbxDiceOne.CreateGraphics();
            graPaperTwo = pbxDiceTwo.CreateGraphics();
            // set first turn
            SetTurn();
        }

        // Public method to set goal and player names, 
        // to be called from frmGoal
        public void SetGoalAndName(int iGoal, string sName1, string sName2)
        {
            iGoalScore = iGoal;
            lblGoalScore.Text = Convert.ToString(iGoalScore);
            sPlayerName1 = sName1;
            sPlayerName2 = sName2;
            lblPlayerOne.Text = sPlayerName1;
            lblPlayerTwo.Text = sPlayerName2;
        }

        // Method to randomly set first turn
        private void SetTurn()
        {
            // turn = 1 or 2
            iTurn = diceFace.Next(1, 3);
            DisplayTurn(iTurn);
        }

        // Method to change player turn
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
            if (iTurn == 1) // player 1's turn
            {
                lblPlayerOneTurn.Text = "YOUR TURN";
                lblPlayerTwoTurn.Text = "";
            }
            else if (iTurn == 2) // player 1's turn
            {
                lblPlayerTwoTurn.Text = "YOUR TURN";
                lblPlayerOneTurn.Text = "";
            }
        } 

        // Method to draw dices on picturebox
        private void DisplayDiceFace(int iDiceOneNumber, int iDiceTwoNumber)
        {
            // Clear graPaper
            graPaperOne.FillRectangle(brushWhite, 0, 0, 162, 162);
            graPaperTwo.FillRectangle(brushWhite, 0, 0, 162, 162);
            // Draw dices outline
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
     
        // Method to check dice numbers rolled
        private void CheckDiceNumbers(int iDiceOneNumber, int iDiceTwoNumber)
        {
            // double 1 is rolled (snake'eyes)
            if (iDiceOneNumber == 1 && iDiceTwoNumber == 1)
            {
                if (iTurn == 1) // player 1
                {
                    iTotalScore1 = 0; // reset total score
                    MessageBox.Show("Snake Eyes! " + sPlayerName1 + " lost everything!");
                }
                else if (iTurn == 2) // player 2
                {
                    iTotalScore2 = 0; // reset total score
                    MessageBox.Show("Snake Eyes! " + sPlayerName2 + " lost everything!");
                }
                // reset running score & change turn
                iRunningScore = 0; 
                UpdateScoreDisplay();
                ChangeTurn();
            }

            // single 1 is rolled (lose dices)
            if (iDiceOneNumber == 1 && iDiceTwoNumber != 1 || iDiceTwoNumber == 1 && iDiceOneNumber != 1)
            {
                if (iTurn == 1)
                {
                    MessageBox.Show(sPlayerName1 + " lost dices!");
                }
                else if (iTurn == 2)
                {
                    MessageBox.Show(sPlayerName2 + " lost dices!");
                }
                // reset running score & change turn
                iRunningScore = 0;
                UpdateScoreDisplay();
                ChangeTurn();
            }

            // reaching goal score
            if (iTurn == 1 && iTotalScore1 + iRunningScore >= iGoalScore)
            {
                iTotalScore1 += iRunningScore; // update total score
                MessageBox.Show(sPlayerName1 + " WINS!");
                iWinCount1++; // update win count
                SetNewGame();
            }
            else if (iTurn == 2 && iTotalScore2 + iRunningScore >= iGoalScore)
            {
                iTotalScore2 += iRunningScore; // update total score
                MessageBox.Show(sPlayerName2 + " WINS!");
                iWinCount2++; // update win count
                SetNewGame();
            }
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

        // Method to update all score displays in the form
        private void UpdateScoreDisplay()
        {
            lblRunningScore.Text = Convert.ToString(iRunningScore);
            lblScoreDisplay1.Text = Convert.ToString(iTotalScore1);
            lblScoreDisplay2.Text = Convert.ToString(iTotalScore2);
            lblWinCount1.Text = Convert.ToString(iWinCount1);
            lblWinDisplayTwo.Text = Convert.ToString(iWinCount2);
        }

        // Method to reset all scores to 0
        private void ResetScores()
        {
            iRunningScore = 0;
            iTotalScore1 = 0;
            iTotalScore2 = 0;
            UpdateScoreDisplay();
        }  

        // BUTTONS CLICK EVENT HANDLERS

        // Player clicks ROLL DICE button
        private void btnRollDice_Click(object sender, EventArgs e)
        {
            // when dices are rolling, disable NEW GAME, CHANGE GOAL, PASS DICE buttons
            btnPassDice.Enabled = false;
            btnNewGame.Enabled = false;
            btnChangeGoal.Enabled = false;

            int iDiceOneNumber = 0; // dice 1 face 
            int iDiceTwoNumber = 0; // dice 2 face 
            // roll dices for 10 times
            for (int i = 0; i < 10; i++)
            {
                iDiceOneNumber = diceFace.Next(1, 7);
                iDiceTwoNumber = diceFace.Next(1, 7);
                DisplayDiceFace(iDiceOneNumber, iDiceTwoNumber);
                // Timer to create effect of dice rolling
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }
            iRunningScore += iDiceOneNumber + iDiceTwoNumber;
            // update running score display
            UpdateScoreDisplay();
            // check dice values
            CheckDiceNumbers(iDiceOneNumber, iDiceTwoNumber);
            // update all score displays after checking
            UpdateScoreDisplay();

            // after rolled, re-enable these buttons
            btnPassDice.Enabled = true;
            btnNewGame.Enabled = true;
            btnChangeGoal.Enabled = true;
        }

        // Player clicks CHANGE GOAL button
        private void btnChangeGoal_Click(object sender, EventArgs e)
        {
            ResetScores();
            SetTurn();
            // goes back to frmGoal
            this.Close();
        }

        // Player clicks PASS DICE button
        private void btnPassDice_Click(object sender, EventArgs e)
        {
            // add running score to total score
            if (iTurn == 1)
            {
                iTotalScore1 += iRunningScore;
            }            
            else if (iTurn == 2)
            {
                iTotalScore2 += iRunningScore;
            }      
            // swap turn and reset running score
            ChangeTurn();
            iRunningScore = 0;
            UpdateScoreDisplay();
        }

        // Player clicks RESET button
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            SetNewGame();
        }  
    }
}
