namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.Scorebutton = new System.Windows.Forms.Button();
            this.team1Scoretxt = new System.Windows.Forms.TextBox();
            this.team1ScoreLbl = new System.Windows.Forms.Label();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.roundLbl = new System.Windows.Forms.Label();
            this.TournamentLbl = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.firstname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.email = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mobile = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.teamMembersListbox = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Scorebutton
            // 
            this.Scorebutton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.Scorebutton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.Scorebutton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.Scorebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scorebutton.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.Scorebutton.ForeColor = System.Drawing.Color.DarkCyan;
            this.Scorebutton.Location = new System.Drawing.Point(72, 158);
            this.Scorebutton.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Scorebutton.Name = "Scorebutton";
            this.Scorebutton.Size = new System.Drawing.Size(121, 30);
            this.Scorebutton.TabIndex = 22;
            this.Scorebutton.Text = "Add Member";
            this.Scorebutton.UseVisualStyleBackColor = true;
            // 
            // team1Scoretxt
            // 
            this.team1Scoretxt.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Scoretxt.Location = new System.Drawing.Point(21, 61);
            this.team1Scoretxt.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.team1Scoretxt.Name = "team1Scoretxt";
            this.team1Scoretxt.Size = new System.Drawing.Size(254, 27);
            this.team1Scoretxt.TabIndex = 21;
            // 
            // team1ScoreLbl
            // 
            this.team1ScoreLbl.AutoSize = true;
            this.team1ScoreLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1ScoreLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.team1ScoreLbl.Location = new System.Drawing.Point(21, 38);
            this.team1ScoreLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.team1ScoreLbl.Name = "team1ScoreLbl";
            this.team1ScoreLbl.Size = new System.Drawing.Size(89, 20);
            this.team1ScoreLbl.TabIndex = 20;
            this.team1ScoreLbl.Text = "Team Name";
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(21, 124);
            this.roundDropdown.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(254, 28);
            this.roundDropdown.TabIndex = 19;
            // 
            // roundLbl
            // 
            this.roundLbl.AutoSize = true;
            this.roundLbl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.roundLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.roundLbl.Location = new System.Drawing.Point(21, 102);
            this.roundLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.roundLbl.Name = "roundLbl";
            this.roundLbl.Size = new System.Drawing.Size(149, 20);
            this.roundLbl.TabIndex = 18;
            this.roundLbl.Text = "Select Team Member";
            this.roundLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TournamentLbl
            // 
            this.TournamentLbl.AutoSize = true;
            this.TournamentLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.TournamentLbl.Location = new System.Drawing.Point(12, 4);
            this.TournamentLbl.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TournamentLbl.Name = "TournamentLbl";
            this.TournamentLbl.Size = new System.Drawing.Size(115, 22);
            this.TournamentLbl.TabIndex = 17;
            this.TournamentLbl.Text = "Create Team";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mobile);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.email);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lastName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.firstname);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.groupBox1.ForeColor = System.Drawing.Color.DarkOrange;
            this.groupBox1.Location = new System.Drawing.Point(21, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(264, 205);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add New Member";
            // 
            // firstname
            // 
            this.firstname.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstname.Location = new System.Drawing.Point(96, 24);
            this.firstname.Margin = new System.Windows.Forms.Padding(5);
            this.firstname.Name = "firstname";
            this.firstname.Size = new System.Drawing.Size(154, 27);
            this.firstname.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label1.ForeColor = System.Drawing.Color.DarkCyan;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 15);
            this.label1.TabIndex = 24;
            this.label1.Text = "First Name";
            // 
            // lastName
            // 
            this.lastName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastName.Location = new System.Drawing.Point(97, 61);
            this.lastName.Margin = new System.Windows.Forms.Padding(5);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(154, 27);
            this.lastName.TabIndex = 27;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(7, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 26;
            this.label2.Text = "Last Name";
            // 
            // email
            // 
            this.email.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.email.Location = new System.Drawing.Point(98, 94);
            this.email.Margin = new System.Windows.Forms.Padding(5);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(154, 27);
            this.email.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label3.ForeColor = System.Drawing.Color.DarkCyan;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 28;
            this.label3.Text = "Email";
            // 
            // mobile
            // 
            this.mobile.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mobile.Location = new System.Drawing.Point(100, 127);
            this.mobile.Margin = new System.Windows.Forms.Padding(5);
            this.mobile.Name = "mobile";
            this.mobile.Size = new System.Drawing.Size(154, 27);
            this.mobile.TabIndex = 31;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label4.ForeColor = System.Drawing.Color.DarkCyan;
            this.label4.Location = new System.Drawing.Point(10, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 15);
            this.label4.TabIndex = 30;
            this.label4.Text = "Mobile";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.DarkCyan;
            this.button1.Location = new System.Drawing.Point(70, 163);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 30);
            this.button1.TabIndex = 24;
            this.button1.Text = "Create Member";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.DarkCyan;
            this.button2.Location = new System.Drawing.Point(517, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 44);
            this.button2.TabIndex = 26;
            this.button2.Text = "Delete Selected";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // teamMembersListbox
            // 
            this.teamMembersListbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.teamMembersListbox.FormattingEnabled = true;
            this.teamMembersListbox.ItemHeight = 18;
            this.teamMembersListbox.Location = new System.Drawing.Point(301, 61);
            this.teamMembersListbox.Name = "teamMembersListbox";
            this.teamMembersListbox.Size = new System.Drawing.Size(208, 326);
            this.teamMembersListbox.TabIndex = 24;
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.DarkCyan;
            this.button3.Location = new System.Drawing.Point(219, 417);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(148, 44);
            this.button3.TabIndex = 27;
            this.button3.Text = "Create Team";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(606, 468);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.teamMembersListbox);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Scorebutton);
            this.Controls.Add(this.team1Scoretxt);
            this.Controls.Add(this.team1ScoreLbl);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.roundLbl);
            this.Controls.Add(this.TournamentLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "CreateTeamForm";
            this.Text = "CreateTeam";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Scorebutton;
        private System.Windows.Forms.TextBox team1Scoretxt;
        private System.Windows.Forms.Label team1ScoreLbl;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.Label roundLbl;
        private System.Windows.Forms.Label TournamentLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox mobile;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox teamMembersListbox;
        private System.Windows.Forms.Button button3;
    }
}