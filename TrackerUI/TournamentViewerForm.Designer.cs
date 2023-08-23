namespace TrackerUI
{
    partial class TournamentViewerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            btn_score = new Button();
            label1 = new Label();
            lbl_tournamentName = new Label();
            label3 = new Label();
            cb_unplayedOnly = new CheckBox();
            dd_round = new ComboBox();
            lb_matchups = new ListBox();
            lbl_teanOne = new Label();
            label5 = new Label();
            tb_teamOneScore = new TextBox();
            lbl_teamTwo = new Label();
            label7 = new Label();
            tb_teamTwoScore = new TextBox();
            label8 = new Label();
            SuspendLayout();
            // 
            // btn_score
            // 
            btn_score.FlatAppearance.BorderColor = Color.Silver;
            btn_score.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btn_score.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btn_score.FlatStyle = FlatStyle.Flat;
            btn_score.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            btn_score.ForeColor = Color.IndianRed;
            btn_score.Location = new Point(436, 431);
            btn_score.Margin = new Padding(8, 9, 8, 9);
            btn_score.Name = "btn_score";
            btn_score.Size = new Size(320, 51);
            btn_score.TabIndex = 0;
            btn_score.Text = "Score";
            btn_score.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(143, 47);
            label1.TabIndex = 1;
            label1.Text = "Torneo:";
            // 
            // lbl_tournamentName
            // 
            lbl_tournamentName.AutoSize = true;
            lbl_tournamentName.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_tournamentName.Location = new Point(144, 20);
            lbl_tournamentName.Name = "lbl_tournamentName";
            lbl_tournamentName.Size = new Size(152, 47);
            lbl_tournamentName.TabIndex = 1;
            lbl_tournamentName.Text = "<none>";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(25, 89);
            label3.Name = "label3";
            label3.Size = new Size(93, 37);
            label3.TabIndex = 2;
            label3.Text = "Ronda";
            // 
            // cb_unplayedOnly
            // 
            cb_unplayedOnly.AutoSize = true;
            cb_unplayedOnly.FlatStyle = FlatStyle.Flat;
            cb_unplayedOnly.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            cb_unplayedOnly.Location = new Point(539, 85);
            cb_unplayedOnly.Name = "cb_unplayedOnly";
            cb_unplayedOnly.Size = new Size(222, 41);
            cb_unplayedOnly.TabIndex = 3;
            cb_unplayedOnly.Text = "Solo Pendientes";
            cb_unplayedOnly.UseVisualStyleBackColor = true;
            // 
            // dd_round
            // 
            dd_round.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dd_round.FormattingEnabled = true;
            dd_round.Location = new Point(124, 88);
            dd_round.Name = "dd_round";
            dd_round.Size = new Size(391, 38);
            dd_round.TabIndex = 4;
            // 
            // lb_matchups
            // 
            lb_matchups.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lb_matchups.FormattingEnabled = true;
            lb_matchups.ItemHeight = 30;
            lb_matchups.Location = new Point(12, 148);
            lb_matchups.Name = "lb_matchups";
            lb_matchups.Size = new Size(413, 334);
            lb_matchups.TabIndex = 5;
            // 
            // lbl_teanOne
            // 
            lbl_teanOne.AutoSize = true;
            lbl_teanOne.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_teanOne.Location = new Point(431, 174);
            lbl_teanOne.Name = "lbl_teanOne";
            lbl_teanOne.Size = new Size(190, 37);
            lbl_teanOne.TabIndex = 2;
            lbl_teanOne.Text = "<equipo uno>";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(431, 213);
            label5.Name = "label5";
            label5.Size = new Size(98, 37);
            label5.TabIndex = 2;
            label5.Text = "Puntos";
            // 
            // tb_teamOneScore
            // 
            tb_teamOneScore.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tb_teamOneScore.Location = new Point(535, 213);
            tb_teamOneScore.Name = "tb_teamOneScore";
            tb_teamOneScore.Size = new Size(221, 36);
            tb_teamOneScore.TabIndex = 6;
            // 
            // lbl_teamTwo
            // 
            lbl_teamTwo.AutoSize = true;
            lbl_teamTwo.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_teamTwo.Location = new Point(431, 325);
            lbl_teamTwo.Name = "lbl_teamTwo";
            lbl_teamTwo.Size = new Size(190, 37);
            lbl_teamTwo.TabIndex = 2;
            lbl_teamTwo.Text = "<equipo uno>";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(431, 364);
            label7.Name = "label7";
            label7.Size = new Size(98, 37);
            label7.TabIndex = 2;
            label7.Text = "Puntos";
            // 
            // tb_teamTwoScore
            // 
            tb_teamTwoScore.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            tb_teamTwoScore.Location = new Point(535, 364);
            tb_teamTwoScore.Name = "tb_teamTwoScore";
            tb_teamTwoScore.Size = new Size(221, 36);
            tb_teamTwoScore.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Black", 30F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(553, 262);
            label8.Name = "label8";
            label8.Size = new Size(106, 54);
            label8.TabIndex = 1;
            label8.Text = "-VS-";
            // 
            // TournamentViewerForm
            // 
            AutoScaleDimensions = new SizeF(19F, 47F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(773, 500);
            Controls.Add(tb_teamTwoScore);
            Controls.Add(tb_teamOneScore);
            Controls.Add(lb_matchups);
            Controls.Add(dd_round);
            Controls.Add(cb_unplayedOnly);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(lbl_teamTwo);
            Controls.Add(lbl_teanOne);
            Controls.Add(label3);
            Controls.Add(label8);
            Controls.Add(lbl_tournamentName);
            Controls.Add(label1);
            Controls.Add(btn_score);
            Font = new Font("Segoe UI", 26F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.IndianRed;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(8, 9, 8, 9);
            Name = "TournamentViewerForm";
            Text = "Tournament Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_score;
        private Label label1;
        private Label lbl_tournamentName;
        private Label label3;
        private CheckBox cb_unplayedOnly;
        private ComboBox dd_round;
        private ListBox lb_matchups;
        private Label lbl_teanOne;
        private Label label5;
        private TextBox tb_teamOneScore;
        private Label lbl_teamTwo;
        private Label label7;
        private TextBox tb_teamTwoScore;
        private Label label8;
    }
}