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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTeamForm));
            tb_teamName = new TextBox();
            lbl_tournamentName = new Label();
            label1 = new Label();
            btn_addMember = new Button();
            dd_selectMember = new ComboBox();
            label3 = new Label();
            groupBox1 = new GroupBox();
            tb_telefonoJugador = new TextBox();
            btn_createMember = new Button();
            tb_apellidoJugador = new TextBox();
            tb_correoJugador = new TextBox();
            label6 = new Label();
            tb_nombreJugador = new TextBox();
            label4 = new Label();
            label2 = new Label();
            label5 = new Label();
            lb_tournamentPlayers = new ListBox();
            btn_removeSelected = new Button();
            btn_crearEquipo = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // tb_teamName
            // 
            tb_teamName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_teamName.Location = new Point(12, 102);
            tb_teamName.Name = "tb_teamName";
            tb_teamName.Size = new Size(366, 35);
            tb_teamName.TabIndex = 1;
            // 
            // lbl_tournamentName
            // 
            lbl_tournamentName.AutoSize = true;
            lbl_tournamentName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tournamentName.Location = new Point(12, 69);
            lbl_tournamentName.Name = "lbl_tournamentName";
            lbl_tournamentName.Size = new Size(193, 30);
            lbl_tournamentName.TabIndex = 15;
            lbl_tournamentName.Text = "Nombre del Equipo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(233, 47);
            label1.TabIndex = 13;
            label1.Text = "Crear Equipo";
            // 
            // btn_addMember
            // 
            btn_addMember.BackColor = Color.IndianRed;
            btn_addMember.FlatAppearance.BorderColor = Color.Firebrick;
            btn_addMember.FlatAppearance.MouseDownBackColor = Color.Brown;
            btn_addMember.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_addMember.FlatStyle = FlatStyle.Flat;
            btn_addMember.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_addMember.ForeColor = Color.White;
            btn_addMember.Location = new Point(12, 215);
            btn_addMember.Margin = new Padding(1);
            btn_addMember.Name = "btn_addMember";
            btn_addMember.Size = new Size(366, 41);
            btn_addMember.TabIndex = 3;
            btn_addMember.Text = "Añadir Jugador";
            btn_addMember.UseVisualStyleBackColor = false;
            btn_addMember.Click += btn_addMember_Click;
            // 
            // dd_selectMember
            // 
            dd_selectMember.DropDownStyle = ComboBoxStyle.DropDownList;
            dd_selectMember.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            dd_selectMember.FormattingEnabled = true;
            dd_selectMember.Location = new Point(12, 173);
            dd_selectMember.Name = "dd_selectMember";
            dd_selectMember.Size = new Size(366, 38);
            dd_selectMember.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(12, 140);
            label3.Name = "label3";
            label3.Size = new Size(144, 30);
            label3.TabIndex = 18;
            label3.Text = "Elegir Jugador";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tb_telefonoJugador);
            groupBox1.Controls.Add(btn_createMember);
            groupBox1.Controls.Add(tb_apellidoJugador);
            groupBox1.Controls.Add(tb_correoJugador);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(tb_nombreJugador);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label5);
            groupBox1.ForeColor = Color.IndianRed;
            groupBox1.Location = new Point(12, 269);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 222);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Crear Jugador";
            // 
            // tb_telefonoJugador
            // 
            tb_telefonoJugador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_telefonoJugador.Location = new Point(117, 140);
            tb_telefonoJugador.Name = "tb_telefonoJugador";
            tb_telefonoJugador.Size = new Size(243, 29);
            tb_telefonoJugador.TabIndex = 7;
            // 
            // btn_createMember
            // 
            btn_createMember.BackColor = Color.IndianRed;
            btn_createMember.FlatAppearance.BorderColor = Color.Firebrick;
            btn_createMember.FlatAppearance.MouseDownBackColor = Color.Brown;
            btn_createMember.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_createMember.FlatStyle = FlatStyle.Flat;
            btn_createMember.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_createMember.ForeColor = Color.White;
            btn_createMember.Location = new Point(87, 173);
            btn_createMember.Margin = new Padding(1);
            btn_createMember.Name = "btn_createMember";
            btn_createMember.Size = new Size(193, 41);
            btn_createMember.TabIndex = 8;
            btn_createMember.Text = "Crear";
            btn_createMember.UseVisualStyleBackColor = false;
            btn_createMember.Click += btn_createMember_Click;
            // 
            // tb_apellidoJugador
            // 
            tb_apellidoJugador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_apellidoJugador.Location = new Point(117, 70);
            tb_apellidoJugador.Name = "tb_apellidoJugador";
            tb_apellidoJugador.Size = new Size(243, 29);
            tb_apellidoJugador.TabIndex = 5;
            // 
            // tb_correoJugador
            // 
            tb_correoJugador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_correoJugador.Location = new Point(117, 105);
            tb_correoJugador.Name = "tb_correoJugador";
            tb_correoJugador.Size = new Size(243, 29);
            tb_correoJugador.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(6, 136);
            label6.Name = "label6";
            label6.Size = new Size(92, 30);
            label6.TabIndex = 11;
            label6.Text = "Telefono";
            // 
            // tb_nombreJugador
            // 
            tb_nombreJugador.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tb_nombreJugador.Location = new Point(117, 35);
            tb_nombreJugador.Name = "tb_nombreJugador";
            tb_nombreJugador.Size = new Size(243, 29);
            tb_nombreJugador.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(6, 101);
            label4.Name = "label4";
            label4.Size = new Size(75, 30);
            label4.TabIndex = 11;
            label4.Text = "Correo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(6, 66);
            label2.Name = "label2";
            label2.Size = new Size(89, 30);
            label2.TabIndex = 11;
            label2.Text = "Apellido";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(6, 34);
            label5.Name = "label5";
            label5.Size = new Size(89, 30);
            label5.TabIndex = 11;
            label5.Text = "Nombre";
            // 
            // lb_tournamentPlayers
            // 
            lb_tournamentPlayers.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            lb_tournamentPlayers.FormattingEnabled = true;
            lb_tournamentPlayers.ItemHeight = 30;
            lb_tournamentPlayers.Location = new Point(397, 102);
            lb_tournamentPlayers.Name = "lb_tournamentPlayers";
            lb_tournamentPlayers.Size = new Size(365, 274);
            lb_tournamentPlayers.TabIndex = 9;
            // 
            // btn_removeSelected
            // 
            btn_removeSelected.BackColor = Color.IndianRed;
            btn_removeSelected.FlatAppearance.BorderColor = Color.Firebrick;
            btn_removeSelected.FlatAppearance.MouseDownBackColor = Color.Brown;
            btn_removeSelected.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_removeSelected.FlatStyle = FlatStyle.Flat;
            btn_removeSelected.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            btn_removeSelected.ForeColor = Color.White;
            btn_removeSelected.Location = new Point(396, 385);
            btn_removeSelected.Margin = new Padding(1);
            btn_removeSelected.Name = "btn_removeSelected";
            btn_removeSelected.Size = new Size(366, 41);
            btn_removeSelected.TabIndex = 10;
            btn_removeSelected.Text = "Quitar Seleccionado";
            btn_removeSelected.UseVisualStyleBackColor = false;
            btn_removeSelected.Click += btn_removeSelected_Click;
            // 
            // btn_crearEquipo
            // 
            btn_crearEquipo.BackColor = Color.IndianRed;
            btn_crearEquipo.FlatAppearance.BorderColor = Color.Firebrick;
            btn_crearEquipo.FlatAppearance.MouseDownBackColor = Color.Brown;
            btn_crearEquipo.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_crearEquipo.FlatStyle = FlatStyle.Flat;
            btn_crearEquipo.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_crearEquipo.ForeColor = Color.White;
            btn_crearEquipo.Location = new Point(396, 435);
            btn_crearEquipo.Margin = new Padding(0);
            btn_crearEquipo.Name = "btn_crearEquipo";
            btn_crearEquipo.Size = new Size(366, 55);
            btn_crearEquipo.TabIndex = 11;
            btn_crearEquipo.Text = "Crear Equipo";
            btn_crearEquipo.UseVisualStyleBackColor = false;
            // 
            // CreateTeamForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 501);
            Controls.Add(lb_tournamentPlayers);
            Controls.Add(groupBox1);
            Controls.Add(btn_crearEquipo);
            Controls.Add(btn_removeSelected);
            Controls.Add(btn_addMember);
            Controls.Add(dd_selectMember);
            Controls.Add(label3);
            Controls.Add(tb_teamName);
            Controls.Add(lbl_tournamentName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.IndianRed;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            MaximizeBox = false;
            Name = "CreateTeamForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Create Team";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tb_teamName;
        private Label lbl_tournamentName;
        private Label label1;
        private Button btn_addMember;
        private ComboBox dd_selectMember;
        private Label label3;
        private GroupBox groupBox1;
        private TextBox tb_telefonoJugador;
        private TextBox tb_apellidoJugador;
        private TextBox tb_correoJugador;
        private Label label6;
        private TextBox tb_nombreJugador;
        private Label label4;
        private Label label2;
        private Label label5;
        private Button btn_createMember;
        private ListBox lb_tournamentPlayers;
        private Button btn_removeSelected;
        private Button btn_crearEquipo;
    }
}