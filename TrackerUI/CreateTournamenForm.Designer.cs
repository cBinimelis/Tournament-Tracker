namespace TrackerUI
{
    partial class CreateTournamenForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamenForm));
            label1 = new Label();
            tb_tournamentName = new TextBox();
            lbl_tournamentName = new Label();
            label2 = new Label();
            tb_entryFee = new TextBox();
            dd_selectTeam = new ComboBox();
            label3 = new Label();
            linkLabel1 = new LinkLabel();
            btn_addTeam = new Button();
            btn_addPrize = new Button();
            label4 = new Label();
            lb_tournamentPlayers = new ListBox();
            btn_deletePlayer = new Button();
            label5 = new Label();
            btn_deletePrize = new Button();
            lb_prize = new ListBox();
            btn_createTournament = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(232, 47);
            label1.TabIndex = 10;
            label1.Text = "Crear Torneo";
            // 
            // tb_tournamentName
            // 
            tb_tournamentName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_tournamentName.Location = new Point(12, 118);
            tb_tournamentName.Name = "tb_tournamentName";
            tb_tournamentName.Size = new Size(366, 35);
            tb_tournamentName.TabIndex = 11;
            // 
            // lbl_tournamentName
            // 
            lbl_tournamentName.AutoSize = true;
            lbl_tournamentName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tournamentName.Location = new Point(12, 85);
            lbl_tournamentName.Name = "lbl_tournamentName";
            lbl_tournamentName.Size = new Size(192, 30);
            lbl_tournamentName.TabIndex = 12;
            lbl_tournamentName.Text = "Nombre del Torneo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(12, 162);
            label2.Name = "label2";
            label2.Size = new Size(167, 30);
            label2.TabIndex = 12;
            label2.Text = "Tarifa de Ingreso";
            // 
            // tb_entryFee
            // 
            tb_entryFee.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_entryFee.Location = new Point(185, 159);
            tb_entryFee.Name = "tb_entryFee";
            tb_entryFee.Size = new Size(193, 35);
            tb_entryFee.TabIndex = 11;
            // 
            // dd_selectTeam
            // 
            dd_selectTeam.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dd_selectTeam.FormattingEnabled = true;
            dd_selectTeam.Location = new Point(16, 243);
            dd_selectTeam.Name = "dd_selectTeam";
            dd_selectTeam.Size = new Size(366, 38);
            dd_selectTeam.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(16, 209);
            label3.Name = "label3";
            label3.Size = new Size(134, 30);
            label3.TabIndex = 14;
            label3.Text = "Elegir Equipo";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            linkLabel1.ForeColor = Color.IndianRed;
            linkLabel1.LinkColor = Color.IndianRed;
            linkLabel1.Location = new Point(300, 209);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(78, 30);
            linkLabel1.TabIndex = 15;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "CREAR";
            // 
            // btn_addTeam
            // 
            btn_addTeam.BackColor = Color.IndianRed;
            btn_addTeam.FlatAppearance.BorderColor = Color.Firebrick;
            btn_addTeam.FlatAppearance.MouseDownBackColor = Color.Brown;
            btn_addTeam.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_addTeam.FlatStyle = FlatStyle.Flat;
            btn_addTeam.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addTeam.ForeColor = Color.White;
            btn_addTeam.Location = new Point(17, 293);
            btn_addTeam.Margin = new Padding(8, 9, 8, 9);
            btn_addTeam.Name = "btn_addTeam";
            btn_addTeam.Size = new Size(366, 51);
            btn_addTeam.TabIndex = 16;
            btn_addTeam.Text = "Añadir Equipo";
            btn_addTeam.UseVisualStyleBackColor = false;
            // 
            // btn_addPrize
            // 
            btn_addPrize.BackColor = Color.IndianRed;
            btn_addPrize.FlatAppearance.BorderColor = Color.Firebrick;
            btn_addPrize.FlatAppearance.MouseDownBackColor = Color.Brown;
            btn_addPrize.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_addPrize.FlatStyle = FlatStyle.Flat;
            btn_addPrize.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addPrize.ForeColor = Color.White;
            btn_addPrize.Location = new Point(17, 362);
            btn_addPrize.Margin = new Padding(8, 9, 8, 9);
            btn_addPrize.Name = "btn_addPrize";
            btn_addPrize.Size = new Size(366, 51);
            btn_addPrize.TabIndex = 16;
            btn_addPrize.Text = "Crear Premio";
            btn_addPrize.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(400, 9);
            label4.Name = "label4";
            label4.Size = new Size(200, 30);
            label4.TabIndex = 12;
            label4.Text = "Equipos / Jugadores";
            // 
            // lb_tournamentPlayers
            // 
            lb_tournamentPlayers.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tournamentPlayers.FormattingEnabled = true;
            lb_tournamentPlayers.ItemHeight = 30;
            lb_tournamentPlayers.Location = new Point(400, 42);
            lb_tournamentPlayers.Name = "lb_tournamentPlayers";
            lb_tournamentPlayers.Size = new Size(365, 154);
            lb_tournamentPlayers.TabIndex = 17;
            // 
            // btn_deletePlayer
            // 
            btn_deletePlayer.FlatAppearance.BorderColor = Color.Silver;
            btn_deletePlayer.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btn_deletePlayer.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btn_deletePlayer.FlatStyle = FlatStyle.Flat;
            btn_deletePlayer.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deletePlayer.ForeColor = Color.IndianRed;
            btn_deletePlayer.Location = new Point(400, 199);
            btn_deletePlayer.Margin = new Padding(0);
            btn_deletePlayer.Name = "btn_deletePlayer";
            btn_deletePlayer.Size = new Size(365, 40);
            btn_deletePlayer.TabIndex = 16;
            btn_deletePlayer.Text = "Eliminar Seleccionado";
            btn_deletePlayer.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(400, 262);
            label5.Name = "label5";
            label5.Size = new Size(67, 30);
            label5.TabIndex = 12;
            label5.Text = "Prizes";
            // 
            // btn_deletePrize
            // 
            btn_deletePrize.FlatAppearance.BorderColor = Color.Silver;
            btn_deletePrize.FlatAppearance.MouseDownBackColor = Color.DarkGray;
            btn_deletePrize.FlatAppearance.MouseOverBackColor = Color.WhiteSmoke;
            btn_deletePrize.FlatStyle = FlatStyle.Flat;
            btn_deletePrize.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            btn_deletePrize.ForeColor = Color.IndianRed;
            btn_deletePrize.Location = new Point(400, 452);
            btn_deletePrize.Margin = new Padding(0);
            btn_deletePrize.Name = "btn_deletePrize";
            btn_deletePrize.Size = new Size(365, 40);
            btn_deletePrize.TabIndex = 16;
            btn_deletePrize.Text = "Eliminar Seleccionado";
            btn_deletePrize.UseVisualStyleBackColor = false;
            // 
            // lb_prize
            // 
            lb_prize.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lb_prize.FormattingEnabled = true;
            lb_prize.ItemHeight = 30;
            lb_prize.Location = new Point(400, 295);
            lb_prize.Name = "lb_prize";
            lb_prize.Size = new Size(365, 154);
            lb_prize.TabIndex = 17;
            // 
            // btn_createTournament
            // 
            btn_createTournament.BackColor = Color.IndianRed;
            btn_createTournament.FlatAppearance.BorderColor = Color.Firebrick;
            btn_createTournament.FlatAppearance.MouseDownBackColor = Color.Brown;
            btn_createTournament.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_createTournament.FlatStyle = FlatStyle.Flat;
            btn_createTournament.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_createTournament.ForeColor = Color.White;
            btn_createTournament.Location = new Point(17, 431);
            btn_createTournament.Margin = new Padding(8, 9, 8, 9);
            btn_createTournament.Name = "btn_createTournament";
            btn_createTournament.Size = new Size(366, 51);
            btn_createTournament.TabIndex = 16;
            btn_createTournament.Text = "Crear Torneo";
            btn_createTournament.UseVisualStyleBackColor = false;
            // 
            // CreateTournamenForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 501);
            Controls.Add(lb_prize);
            Controls.Add(lb_tournamentPlayers);
            Controls.Add(btn_createTournament);
            Controls.Add(btn_addPrize);
            Controls.Add(btn_deletePrize);
            Controls.Add(btn_deletePlayer);
            Controls.Add(btn_addTeam);
            Controls.Add(linkLabel1);
            Controls.Add(dd_selectTeam);
            Controls.Add(label3);
            Controls.Add(tb_entryFee);
            Controls.Add(tb_tournamentName);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lbl_tournamentName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.IndianRed;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "CreateTournamenForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Tournament";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_tournamentName;
        private Label lbl_tournamentName;
        private Label label2;
        private TextBox tb_entryFee;
        private ComboBox dd_selectTeam;
        private Label label3;
        private LinkLabel linkLabel1;
        private Button btn_addTeam;
        private Button btn_addPrize;
        private Label label4;
        private ListBox lb_tournamentPlayers;
        private Button btn_deletePlayer;
        private Label label5;
        private Button btn_deletePrize;
        private ListBox lb_prize;
        private Button btn_createTournament;
    }
}