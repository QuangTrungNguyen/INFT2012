namespace NguyenQuangTrungAssgt
{
    partial class frmGoal
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
            this.lblSetGoal = new System.Windows.Forms.Label();
            this.txbSetGoal = new System.Windows.Forms.TextBox();
            this.btnSetGoal = new System.Windows.Forms.Button();
            this.btnChangeMode = new System.Windows.Forms.Button();
            this.lblSetName1 = new System.Windows.Forms.Label();
            this.lblSetName2 = new System.Windows.Forms.Label();
            this.txbSetName1 = new System.Windows.Forms.TextBox();
            this.txbSetName2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSetGoal
            // 
            this.lblSetGoal.AutoSize = true;
            this.lblSetGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetGoal.Location = new System.Drawing.Point(32, 51);
            this.lblSetGoal.Name = "lblSetGoal";
            this.lblSetGoal.Size = new System.Drawing.Size(234, 29);
            this.lblSetGoal.TabIndex = 0;
            this.lblSetGoal.Text = "Enter the goal score:";
            // 
            // txbSetGoal
            // 
            this.txbSetGoal.Location = new System.Drawing.Point(321, 51);
            this.txbSetGoal.Name = "txbSetGoal";
            this.txbSetGoal.Size = new System.Drawing.Size(137, 29);
            this.txbSetGoal.TabIndex = 1;
            // 
            // btnSetGoal
            // 
            this.btnSetGoal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetGoal.Location = new System.Drawing.Point(90, 265);
            this.btnSetGoal.Name = "btnSetGoal";
            this.btnSetGoal.Size = new System.Drawing.Size(146, 64);
            this.btnSetGoal.TabIndex = 2;
            this.btnSetGoal.Text = "SET GOAL";
            this.btnSetGoal.UseVisualStyleBackColor = true;
            this.btnSetGoal.Click += new System.EventHandler(this.btnSetGoal_Click);
            // 
            // btnChangeMode
            // 
            this.btnChangeMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.142858F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeMode.Location = new System.Drawing.Point(283, 265);
            this.btnChangeMode.Name = "btnChangeMode";
            this.btnChangeMode.Size = new System.Drawing.Size(146, 64);
            this.btnChangeMode.TabIndex = 4;
            this.btnChangeMode.Text = "CHANGE MODE";
            this.btnChangeMode.UseVisualStyleBackColor = true;
            this.btnChangeMode.Click += new System.EventHandler(this.btnChangeMode_Click);
            // 
            // lblSetName1
            // 
            this.lblSetName1.AutoSize = true;
            this.lblSetName1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetName1.Location = new System.Drawing.Point(32, 112);
            this.lblSetName1.Name = "lblSetName1";
            this.lblSetName1.Size = new System.Drawing.Size(251, 29);
            this.lblSetName1.TabIndex = 5;
            this.lblSetName1.Text = "Enter Player 1\'s name:";
            // 
            // lblSetName2
            // 
            this.lblSetName2.AutoSize = true;
            this.lblSetName2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSetName2.Location = new System.Drawing.Point(32, 178);
            this.lblSetName2.Name = "lblSetName2";
            this.lblSetName2.Size = new System.Drawing.Size(251, 29);
            this.lblSetName2.TabIndex = 6;
            this.lblSetName2.Text = "Enter Player 2\'s name:";
            // 
            // txbSetName1
            // 
            this.txbSetName1.Location = new System.Drawing.Point(321, 112);
            this.txbSetName1.Name = "txbSetName1";
            this.txbSetName1.Size = new System.Drawing.Size(137, 29);
            this.txbSetName1.TabIndex = 7;
            this.txbSetName1.Text = "PLAYER 1";
            // 
            // txbSetName2
            // 
            this.txbSetName2.Location = new System.Drawing.Point(321, 178);
            this.txbSetName2.Name = "txbSetName2";
            this.txbSetName2.Size = new System.Drawing.Size(137, 29);
            this.txbSetName2.TabIndex = 8;
            this.txbSetName2.Text = "PLAYER 2";
            // 
            // frmGoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 376);
            this.Controls.Add(this.txbSetName2);
            this.Controls.Add(this.txbSetName1);
            this.Controls.Add(this.lblSetName2);
            this.Controls.Add(this.lblSetName1);
            this.Controls.Add(this.btnChangeMode);
            this.Controls.Add(this.btnSetGoal);
            this.Controls.Add(this.txbSetGoal);
            this.Controls.Add(this.lblSetGoal);
            this.Name = "frmGoal";
            this.Text = "SET GOAL SCORE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSetGoal;
        private System.Windows.Forms.TextBox txbSetGoal;
        private System.Windows.Forms.Button btnSetGoal;
        private System.Windows.Forms.Button btnChangeMode;
        private System.Windows.Forms.Label lblSetName1;
        private System.Windows.Forms.Label lblSetName2;
        private System.Windows.Forms.TextBox txbSetName1;
        private System.Windows.Forms.TextBox txbSetName2;
    }
}