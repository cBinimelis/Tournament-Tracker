namespace TrackerUI
{
    partial class CreatePrizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatePrizeForm));
            label1 = new Label();
            tb_positionNumber = new TextBox();
            lbl_tournamentName = new Label();
            label2 = new Label();
            tb_positionName = new TextBox();
            label3 = new Label();
            tb_prizeAmount = new TextBox();
            label4 = new Label();
            tb_prizePercentage = new TextBox();
            label_or = new Label();
            btn_createPrize = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 20);
            label1.Name = "label1";
            label1.Size = new Size(236, 47);
            label1.TabIndex = 14;
            label1.Text = "Crear Premio";
            // 
            // tb_positionNumber
            // 
            tb_positionNumber.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_positionNumber.Location = new Point(326, 125);
            tb_positionNumber.Name = "tb_positionNumber";
            tb_positionNumber.Size = new Size(366, 35);
            tb_positionNumber.TabIndex = 16;
            // 
            // lbl_tournamentName
            // 
            lbl_tournamentName.AutoSize = true;
            lbl_tournamentName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            lbl_tournamentName.Location = new Point(87, 130);
            lbl_tournamentName.Name = "lbl_tournamentName";
            lbl_tournamentName.Size = new Size(223, 30);
            lbl_tournamentName.TabIndex = 17;
            lbl_tournamentName.Text = "Numero de la posición";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(87, 188);
            label2.Name = "label2";
            label2.Size = new Size(223, 30);
            label2.TabIndex = 17;
            label2.Text = "Nombre de la posición";
            // 
            // tb_positionName
            // 
            tb_positionName.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_positionName.Location = new Point(326, 183);
            tb_positionName.Name = "tb_positionName";
            tb_positionName.Size = new Size(366, 35);
            tb_positionName.TabIndex = 16;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(87, 246);
            label3.Name = "label3";
            label3.Size = new Size(201, 30);
            label3.TabIndex = 17;
            label3.Text = "Cantidad del premio";
            // 
            // tb_prizeAmount
            // 
            tb_prizeAmount.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_prizeAmount.Location = new Point(326, 241);
            tb_prizeAmount.Name = "tb_prizeAmount";
            tb_prizeAmount.Size = new Size(366, 35);
            tb_prizeAmount.TabIndex = 16;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(87, 317);
            label4.Name = "label4";
            label4.Size = new Size(215, 30);
            label4.TabIndex = 17;
            label4.Text = "Porcentaje del premio";
            // 
            // tb_prizePercentage
            // 
            tb_prizePercentage.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            tb_prizePercentage.Location = new Point(326, 312);
            tb_prizePercentage.Name = "tb_prizePercentage";
            tb_prizePercentage.Size = new Size(366, 35);
            tb_prizePercentage.TabIndex = 16;
            // 
            // label_or
            // 
            label_or.AutoSize = true;
            label_or.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label_or.Location = new Point(479, 279);
            label_or.Name = "label_or";
            label_or.Size = new Size(45, 30);
            label_or.TabIndex = 17;
            label_or.Text = "-O-";
            // 
            // btn_createPrize
            // 
            btn_createPrize.BackColor = Color.IndianRed;
            btn_createPrize.FlatAppearance.BorderColor = Color.Firebrick;
            btn_createPrize.FlatAppearance.MouseDownBackColor = Color.Brown;
            btn_createPrize.FlatAppearance.MouseOverBackColor = Color.LightCoral;
            btn_createPrize.FlatStyle = FlatStyle.Flat;
            btn_createPrize.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btn_createPrize.ForeColor = Color.White;
            btn_createPrize.Location = new Point(205, 391);
            btn_createPrize.Margin = new Padding(0);
            btn_createPrize.Name = "btn_createPrize";
            btn_createPrize.Size = new Size(366, 55);
            btn_createPrize.TabIndex = 20;
            btn_createPrize.Text = "Crear Premio";
            btn_createPrize.UseVisualStyleBackColor = false;
            // 
            // CreatePrizeForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(774, 501);
            Controls.Add(btn_createPrize);
            Controls.Add(tb_prizePercentage);
            Controls.Add(tb_prizeAmount);
            Controls.Add(tb_positionName);
            Controls.Add(tb_positionNumber);
            Controls.Add(label_or);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lbl_tournamentName);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            ForeColor = Color.IndianRed;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(5, 6, 5, 6);
            Name = "CreatePrizeForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreatePrizeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox tb_positionNumber;
        private Label lbl_tournamentName;
        private Label label2;
        private TextBox tb_positionName;
        private Label label3;
        private TextBox tb_prizeAmount;
        private Label label4;
        private TextBox tb_prizePercentage;
        private Label label_or;
        private Button btn_createPrize;
    }
}