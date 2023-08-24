namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentDashboardForm));
            label1 = new Label();
            dd_loadExistingTournament = new ComboBox();
            label3 = new Label();
            btn_createTournament = new Button();
            btn_loadTournament = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(117, 59);
            label1.Name = "label1";
            label1.Size = new Size(541, 89);
            label1.TabIndex = 15;
            label1.Text = "Panel de Torneo";
            // 
            // dd_loadExistingTournament
            // 
            dd_loadExistingTournament.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            dd_loadExistingTournament.FormattingEnabled = true;
            dd_loadExistingTournament.Location = new Point(158, 232);
            dd_loadExistingTournament.Name = "dd_loadExistingTournament";
            dd_loadExistingTournament.Size = new Size(458, 45);
            dd_loadExistingTournament.TabIndex = 19;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(239, 186);
            label3.Name = "label3";
            label3.Size = new Size(296, 37);
            label3.TabIndex = 20;
            label3.Text = "Cargar Torneo Existente";
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
            btn_createTournament.Location = new Point(158, 371);
            btn_createTournament.Margin = new Padding(0);
            btn_createTournament.Name = "btn_createTournament";
            btn_createTournament.Size = new Size(458, 55);
            btn_createTournament.TabIndex = 21;
            btn_createTournament.Text = "Crear Torneo";
            btn_createTournament.UseVisualStyleBackColor = false;
            // 
            // btn_loadTournament
            // 
            btn_loadTournament.BackColor = Color.IndianRed;
            btn_loadTournament.FlatAppearance.BorderColor = Color.Firebrick;
            btn_loadTournament.FlatAppearance.MouseDownBackColor = Color.Brown;
            btn_loadTournament.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_loadTournament.FlatStyle = FlatStyle.Flat;
            btn_loadTournament.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_loadTournament.ForeColor = Color.White;
            btn_loadTournament.Location = new Point(204, 290);
            btn_loadTournament.Margin = new Padding(1);
            btn_loadTournament.Name = "btn_loadTournament";
            btn_loadTournament.Size = new Size(366, 41);
            btn_loadTournament.TabIndex = 22;
            btn_loadTournament.Text = "Cargar Torneo";
            btn_loadTournament.UseVisualStyleBackColor = false;
            // 
            // TournamentDashboardForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 501);
            Controls.Add(btn_createTournament);
            Controls.Add(btn_loadTournament);
            Controls.Add(dd_loadExistingTournament);
            Controls.Add(label3);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.IndianRed;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "TournamentDashboardForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Tournament Dashboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox dd_loadExistingTournament;
        private Label label3;
        private Button btn_createTournament;
        private Button btn_loadTournament;
    }
}