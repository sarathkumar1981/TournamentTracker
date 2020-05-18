namespace TrackerUI
{
    partial class TournamentDashboard
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
            this.LoadTournamentBtn = new System.Windows.Forms.Button();
            this.roundDropdown = new System.Windows.Forms.ComboBox();
            this.loadTournamentLbl = new System.Windows.Forms.Label();
            this.TournamentLbl = new System.Windows.Forms.Label();
            this.createTournamentBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoadTournamentBtn
            // 
            this.LoadTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.LoadTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.LoadTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.LoadTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoadTournamentBtn.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.LoadTournamentBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.LoadTournamentBtn.Location = new System.Drawing.Point(133, 138);
            this.LoadTournamentBtn.Margin = new System.Windows.Forms.Padding(5);
            this.LoadTournamentBtn.Name = "LoadTournamentBtn";
            this.LoadTournamentBtn.Size = new System.Drawing.Size(150, 30);
            this.LoadTournamentBtn.TabIndex = 26;
            this.LoadTournamentBtn.Text = "Load Tournament";
            this.LoadTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // roundDropdown
            // 
            this.roundDropdown.FormattingEnabled = true;
            this.roundDropdown.Location = new System.Drawing.Point(100, 100);
            this.roundDropdown.Margin = new System.Windows.Forms.Padding(5);
            this.roundDropdown.Name = "roundDropdown";
            this.roundDropdown.Size = new System.Drawing.Size(217, 28);
            this.roundDropdown.TabIndex = 25;
            // 
            // loadTournamentLbl
            // 
            this.loadTournamentLbl.AutoSize = true;
            this.loadTournamentLbl.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.loadTournamentLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.loadTournamentLbl.Location = new System.Drawing.Point(118, 75);
            this.loadTournamentLbl.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.loadTournamentLbl.Name = "loadTournamentLbl";
            this.loadTournamentLbl.Size = new System.Drawing.Size(180, 20);
            this.loadTournamentLbl.TabIndex = 24;
            this.loadTournamentLbl.Text = "Load Existing Tournament";
            this.loadTournamentLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // TournamentLbl
            // 
            this.TournamentLbl.AutoSize = true;
            this.TournamentLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TournamentLbl.ForeColor = System.Drawing.Color.DarkCyan;
            this.TournamentLbl.Location = new System.Drawing.Point(99, 30);
            this.TournamentLbl.Margin = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.TournamentLbl.Name = "TournamentLbl";
            this.TournamentLbl.Size = new System.Drawing.Size(219, 25);
            this.TournamentLbl.TabIndex = 23;
            this.TournamentLbl.Text = "Tournament Dashboard";
            // 
            // createTournamentBtn
            // 
            this.createTournamentBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTournamentBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Khaki;
            this.createTournamentBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Khaki;
            this.createTournamentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTournamentBtn.Font = new System.Drawing.Font("Segoe UI", 9.25F, System.Drawing.FontStyle.Bold);
            this.createTournamentBtn.ForeColor = System.Drawing.Color.DarkCyan;
            this.createTournamentBtn.Location = new System.Drawing.Point(133, 188);
            this.createTournamentBtn.Margin = new System.Windows.Forms.Padding(5);
            this.createTournamentBtn.Name = "createTournamentBtn";
            this.createTournamentBtn.Size = new System.Drawing.Size(150, 30);
            this.createTournamentBtn.TabIndex = 27;
            this.createTournamentBtn.Text = "Create Tournament";
            this.createTournamentBtn.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(420, 246);
            this.Controls.Add(this.createTournamentBtn);
            this.Controls.Add(this.LoadTournamentBtn);
            this.Controls.Add(this.roundDropdown);
            this.Controls.Add(this.loadTournamentLbl);
            this.Controls.Add(this.TournamentLbl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "TournamentDashboard";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoadTournamentBtn;
        private System.Windows.Forms.ComboBox roundDropdown;
        private System.Windows.Forms.Label loadTournamentLbl;
        private System.Windows.Forms.Label TournamentLbl;
        private System.Windows.Forms.Button createTournamentBtn;
    }
}