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
    public partial class frmGoal : Form
    {
        // instance of each play mode form
        frmTwoPlayers frmMultiPlayer;
        frmSinglePlayer frmSinglePlayer;

        // variable indicates game mode 
        int iGameMode;

        // constructor sets game mode
        public frmGoal(int iMode)
        {
            InitializeComponent();
            iGameMode = iMode;
        }

        public void HidePlayerTwoName()
        {
            lblSetName1.Text = "Enter your name:";
            lblSetName2.Visible = false;
            txbSetName2.Visible = false;
        }

        private void btnSetGoal_Click(object sender, EventArgs e)
        {
            int iGoal;
            string sNameOne;
            string sNameTwo;
            // user input of goal score and names
            try
            {
                iGoal = Convert.ToInt32(txbSetGoal.Text);
                sNameOne = txbSetName1.Text;
                sNameTwo = txbSetName2.Text;
                // 2 player mode
                if(iGoal < 1)
                {
                    MessageBox.Show("Goal must be larger than 0");
                }
                else if(iGameMode == 2)
                {
                    frmMultiPlayer = new frmTwoPlayers();
                    frmMultiPlayer.SetGoalAndName(iGoal, sNameOne, sNameTwo); // set goal
                    frmMultiPlayer.ShowDialog(); // open form
                }
                // 1 player mode
                else if(iGameMode == 1)
                {
                    frmSinglePlayer = new frmSinglePlayer();       
                    frmSinglePlayer.SetGoalAndName(iGoal, sNameOne); // set goal
                    frmSinglePlayer.ShowDialog(); // open form
                }
            }
            catch (FormatException)
            {   // error: wrong goal score format
                MessageBox.Show("Invalid format. Please enter again!");
            }
                      
        }

        private void btnChangeMode_Click(object sender, EventArgs e)
        {
            // change mode: go back to frmMain
            this.Close();
        }
    }
}
