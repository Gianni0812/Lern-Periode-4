namespace Lern_Oeriode_4
{
    partial class Form2
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
            Jetons = new Label();
            label2 = new Label();
            Cash = new Label();
            label1 = new Label();
            ATM = new Label();
            button1 = new Button();
            label3 = new Label();
            JetonsKaufen = new Button();
            JetonsVerkaufen = new Button();
            label4 = new Label();
            Back = new Button();
            SuspendLayout();
            // 
            // Jetons
            // 
            Jetons.AutoSize = true;
            Jetons.BackColor = SystemColors.HotTrack;
            Jetons.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Jetons.ForeColor = SystemColors.ButtonHighlight;
            Jetons.Location = new Point(440, 28);
            Jetons.Name = "Jetons";
            Jetons.Size = new Size(83, 32);
            Jetons.TabIndex = 17;
            Jetons.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HotTrack;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(447, 3);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 16;
            label2.Text = "Jetons";
            // 
            // Cash
            // 
            Cash.AutoSize = true;
            Cash.BackColor = SystemColors.HotTrack;
            Cash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cash.ForeColor = SystemColors.ButtonHighlight;
            Cash.Location = new Point(638, 28);
            Cash.Name = "Cash";
            Cash.Size = new Size(83, 32);
            Cash.TabIndex = 15;
            Cash.Text = "label2";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(647, 3);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 14;
            label1.Text = "Cash";
            // 
            // ATM
            // 
            ATM.AutoSize = true;
            ATM.BackColor = SystemColors.HotTrack;
            ATM.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ATM.ForeColor = SystemColors.ControlLightLight;
            ATM.Location = new Point(10, 9);
            ATM.Name = "ATM";
            ATM.Size = new Size(78, 38);
            ATM.TabIndex = 13;
            ATM.Text = "ATM";
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Location = new Point(-4, -1);
            button1.Name = "button1";
            button1.Size = new Size(835, 67);
            button1.TabIndex = 12;
            button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(270, 101);
            label3.Name = "label3";
            label3.Size = new Size(290, 64);
            label3.TabIndex = 18;
            label3.Text = "              Hallo\r\nWas möchten Sie machen";
            // 
            // JetonsKaufen
            // 
            JetonsKaufen.BackColor = SystemColors.ActiveCaption;
            JetonsKaufen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JetonsKaufen.ForeColor = SystemColors.ButtonHighlight;
            JetonsKaufen.Location = new Point(307, 174);
            JetonsKaufen.Name = "JetonsKaufen";
            JetonsKaufen.Size = new Size(202, 76);
            JetonsKaufen.TabIndex = 19;
            JetonsKaufen.Text = "Jetons Kaufen";
            JetonsKaufen.UseVisualStyleBackColor = false;
            JetonsKaufen.Click += JetonsKaufen_Click;
            // 
            // JetonsVerkaufen
            // 
            JetonsVerkaufen.BackColor = SystemColors.ActiveCaption;
            JetonsVerkaufen.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JetonsVerkaufen.ForeColor = SystemColors.ButtonHighlight;
            JetonsVerkaufen.Location = new Point(307, 308);
            JetonsVerkaufen.Name = "JetonsVerkaufen";
            JetonsVerkaufen.Size = new Size(202, 76);
            JetonsVerkaufen.TabIndex = 20;
            JetonsVerkaufen.Text = "Jetons verkaufen";
            JetonsVerkaufen.UseVisualStyleBackColor = false;
            JetonsVerkaufen.Click += JetonsVerkaufen_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonFace;
            label4.Location = new Point(374, 259);
            label4.Name = "label4";
            label4.Size = new Size(63, 32);
            label4.TabIndex = 21;
            label4.Text = "oder\r\n";
            // 
            // Back
            // 
            Back.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.Location = new Point(12, 87);
            Back.Name = "Back";
            Back.Size = new Size(76, 38);
            Back.TabIndex = 22;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(828, 464);
            Controls.Add(Back);
            Controls.Add(label4);
            Controls.Add(JetonsVerkaufen);
            Controls.Add(JetonsKaufen);
            Controls.Add(label3);
            Controls.Add(Jetons);
            Controls.Add(label2);
            Controls.Add(Cash);
            Controls.Add(label1);
            Controls.Add(ATM);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Jetons;
        private Label label2;
        private Label Cash;
        private Label label1;
        private Label ATM;
        private Button button1;
        private Label label3;
        private Button JetonsKaufen;
        private Button JetonsVerkaufen;
        private Label label4;
        private Button Back;
    }
}