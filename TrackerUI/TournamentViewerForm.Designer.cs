namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.TournamentLbl = new System.Windows.Forms.Label();
            this.tournamentNameLbl = new System.Windows.Forms.Label();
            this.roundLbl = new System.Windows.Forms.Label();
            this.teamname1 = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.unplayedcheckBox = new System.Windows.Forms.CheckBox();
            this.matchUplistbox = new System.Windows.Forms.ListBox();
            this.team1ScoreLbl = new System.Windows.Forms.Label();
            this.team1Scoretxt = new System.Windows.Forms.TextBox();
            this.team2Scoretxt = new System.Windows.Forms.TextBox();
            this.team2ScoreLbl = new System.Windows.Forms.Label();
            this.team2Lbl = new System.Windows.Forms.Label();
            this.VsLbl = new System.Windows.Forms.Label();
            this.Scorebutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TournamentLbl
            // 
            this.TournamentLbl.AutoSize = true;
            this.TournamentLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.TournamentLbl.Location = new System.Drawing.Point(22, 22);
            this.TournamentLbl.Name = "TournamentLbl";
            this.TournamentLbl.Size = new System.Drawing.Size(120, 28);
            this.TournamentLbl.TabIndex = 0;
            this.TournamentLbl.Text = "Tournament:";
            // 
            // tournamentNameLbl
            // 
            this.tournamentNameLbl.AutoSize = true;
            this.tournamentNameLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.tournamentNameLbl.Location = new System.Drawing.Point(148, 22);
            this.tournamentNameLbl.Name = "tournamentNameLbl";
            this.tournamentNameLbl.Size = new System.Drawing.Size(88, 28);
            this.tournamentNameLbl.TabIndex = 1;
            this.tournamentNameLbl.Text = "<None>";
            // 
            // roundLbl
            // 
            this.roundLbl.AutoSize = true;
            this.roundLbl.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.roundLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.roundLbl.Location = new System.Drawing.Point(22, 77);
            this.roundLbl.Name = "roundLbl";
            this.roundLbl.Size = new System.Drawing.Size(64, 25);
            this.roundLbl.TabIndex = 2;
            this.roundLbl.Text = "Round";
            this.roundLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // teamname1
            // 
            this.teamname1.AutoSize = true;
            this.teamname1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamname1.ForeColor = System.Drawing.Color.DarkCyan;
            this.teamname1.Location = new System.Drawing.Point(270, 175);
            this.teamname1.Name = "teamname1";
            this.teamname1.Size = new System.Drawing.Size(71, 20);
            this.teamname1.TabIndex = 3;
            this.teamname1.Text = "<team1>";
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(147, 69);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(166, 36);
            this.roundDropdown.TabIndex = 4;
            // 
            // unplayedcheckBox
            // 
            this.unplayedcheckBox.AutoSize = true;
            this.unplayedcheckBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.unplayedcheckBox.ForeColor = System.Drawing.Color.SteelBlue;
            this.unplayedcheckBox.Location = new System.Drawing.Point(153, 127);
            this.unplayedcheckBox.Name = "unplayedcheckBox";
            this.unplayedcheckBox.Size = new System.Drawing.Size(125, 24);
            this.unplayedcheckBox.TabIndex = 5;
            this.unplayedcheckBox.Text = "Unplayed Only";
            this.unplayedcheckBox.UseVisualStyleBackColor = true;
            // 
            // matchUplistbox
            // 
            this.matchUplistbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchUplistbox.FormattingEnabled = true;
            this.matchUplistbox.ItemHeight = 28;
            this.matchUplistbox.Location = new System.Drawing.Point(19, 175);
            this.matchUplistbox.Name = "matchUplistbox";
            this.matchUplistbox.Size = new System.Drawing.Size(235, 198);
            this.matchUplistbox.TabIndex = 6;
            // 
            // team1ScoreLbl
            // 
            this.team1ScoreLbl.AutoSize = true;
            this.team1ScoreLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1ScoreLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.team1ScoreLbl.Location = new System.Drawing.Point(277, 220);
            this.team1ScoreLbl.Name = "team1ScoreLbl";
            this.team1ScoreLbl.Size = new System.Drawing.Size(46, 20);
            this.team1ScoreLbl.TabIndex = 7;
            this.team1ScoreLbl.Text = "Score";
            // 
            // team1Scoretxt
            // 
            this.team1Scoretxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Scoretxt.Location = new System.Drawing.Point(354, 211);
            this.team1Scoretxt.Name = "team1Scoretxt";
            this.team1Scoretxt.Size = new System.Drawing.Size(103, 27);
            this.team1Scoretxt.TabIndex = 8;
            // 
            // team2Scoretxt
            // 
            this.team2Scoretxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Scoretxt.Location = new System.Drawing.Point(354, 341);
            this.team2Scoretxt.Name = "team2Scoretxt";
            this.team2Scoretxt.Size = new System.Drawing.Size(103, 27);
            this.team2Scoretxt.TabIndex = 11;
            // 
            // team2ScoreLbl
            // 
            this.team2ScoreLbl.AutoSize = true;
            this.team2ScoreLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2ScoreLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.team2ScoreLbl.Location = new System.Drawing.Point(277, 350);
            this.team2ScoreLbl.Name = "team2ScoreLbl";
            this.team2ScoreLbl.Size = new System.Drawing.Size(46, 20);
            this.team2ScoreLbl.TabIndex = 10;
            this.team2ScoreLbl.Text = "Score";
            // 
            // team2Lbl
            // 
            this.team2Lbl.AutoSize = true;
            this.team2Lbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Lbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.team2Lbl.Location = new System.Drawing.Point(270, 296);
            this.team2Lbl.Name = "team2Lbl";
            this.team2Lbl.Size = new System.Drawing.Size(71, 20);
            this.team2Lbl.TabIndex = 9;
            this.team2Lbl.Text = "<team2>";
            // 
            // VsLbl
            // 
            this.VsLbl.AutoSize = true;
            this.VsLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.VsLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.VsLbl.Location = new System.Drawing.Point(368, 265);
            this.VsLbl.Name = "VsLbl";
            this.VsLbl.Size = new System.Drawing.Size(40, 20);
            this.VsLbl.TabIndex = 12;
            this.VsLbl.Text = "-Vs -";
            // 
            // Scorebutton
            // 
            this.Scorebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Scorebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Scorebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.Scorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scorebutton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scorebutton.ForeColor = System.Drawing.Color.DarkCyan;
            this.Scorebutton.Location = new System.Drawing.Point(463, 265);
            this.Scorebutton.Name = "Scorebutton";
            this.Scorebutton.Size = new System.Drawing.Size(103, 34);
            this.Scorebutton.TabIndex = 13;
            this.Scorebutton.Text = "Score";
            this.Scorebutton.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(583, 395);
            this.Controls.Add(this.Scorebutton);
            this.Controls.Add(this.VsLbl);
            this.Controls.Add(this.team2Scoretxt);
            this.Controls.Add(this.team2ScoreLbl);
            this.Controls.Add(this.team2Lbl);
            this.Controls.Add(this.team1Scoretxt);
            this.Controls.Add(this.team1ScoreLbl);
            this.Controls.Add(this.matchUplistbox);
            this.Controls.Add(this.unplayedcheckBox);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.teamname1);
            this.Controls.Add(this.roundLbl);
            this.Controls.Add(this.tournamentNameLbl);
            this.Controls.Add(this.TournamentLbl);
            this.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "TournamentViewerForm";
            this.Text = "TournamentViewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TournamentLbl;
        private System.Windows.Forms.Label tournamentNameLbl;
        private System.Windows.Forms.Label roundLbl;
        private System.Windows.Forms.Label teamname1;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.CheckBox unplayedcheckBox;
        private System.Windows.Forms.ListBox matchUplistbox;
        private System.Windows.Forms.Label team1ScoreLbl;
        private System.Windows.Forms.TextBox team1Scoretxt;
        private System.Windows.Forms.TextBox team2Scoretxt;
        private System.Windows.Forms.Label team2ScoreLbl;
        private System.Windows.Forms.Label team2Lbl;
        private System.Windows.Forms.Label VsLbl;
        private System.Windows.Forms.Button Scorebutton;
    }
}

