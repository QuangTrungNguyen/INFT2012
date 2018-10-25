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
    public partial class frmMain : Form
    {
        // instance of frmGoal
        frmGoal frmGoal;

        // REFERENCE
        // Photo used in pbxImage is unnamed.png from
        // https://play.google.com/store/apps/details?id=com.teazel.dice3d  

        public frmMain()
        {
            InitializeComponent();
        }

        private void btnTwoPlayers_Click(object sender, EventArgs e)
        {
            // 2 Player Mode
            frmGoal = new frmGoal(2);
            // open frmGoal
            frmGoal.ShowDialog();          
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            // 1 Player Mode
            frmGoal = new frmGoal(1);
            // hide player 2 on frmGoal
            frmGoal.HidePlayerTwoName();
            // open frmGoal
            frmGoal.ShowDialog(); 
        }

  
    }
}
