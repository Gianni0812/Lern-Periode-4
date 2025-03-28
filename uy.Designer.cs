namespace Lern_Oeriode_4
{
    partial class uy
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
            button1 = new Button();
            ATM = new Label();
            label1 = new Label();
            Cash = new Label();
            label2 = new Label();
            Jetons = new Label();
            label3 = new Label();
            button2 = new Button();
            Back = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            Max = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = SystemColors.HotTrack;
            button1.Location = new Point(-2, 0);
            button1.Name = "button1";
            button1.Size = new Size(804, 67);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // ATM
            // 
            ATM.AutoSize = true;
            ATM.BackColor = SystemColors.HotTrack;
            ATM.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ATM.ForeColor = SystemColors.ControlLightLight;
            ATM.Location = new Point(12, 10);
            ATM.Name = "ATM";
            ATM.Size = new Size(78, 38);
            ATM.TabIndex = 1;
            ATM.Text = "ATM";
            ATM.Click += ATM_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(649, 4);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 2;
            label1.Text = "Cash";
            label1.Click += label1_Click_1;
            // 
            // Cash
            // 
            Cash.AutoSize = true;
            Cash.BackColor = SystemColors.HotTrack;
            Cash.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Cash.ForeColor = SystemColors.ButtonHighlight;
            Cash.Location = new Point(635, 29);
            Cash.Name = "Cash";
            Cash.Size = new Size(83, 32);
            Cash.TabIndex = 3;
            Cash.Text = "label2";
            Cash.Click += Cash_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HotTrack;
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(449, 4);
            label2.Name = "label2";
            label2.Size = new Size(62, 25);
            label2.TabIndex = 4;
            label2.Text = "Jetons";
            // 
            // Jetons
            // 
            Jetons.AutoSize = true;
            Jetons.BackColor = SystemColors.HotTrack;
            Jetons.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Jetons.ForeColor = SystemColors.ButtonHighlight;
            Jetons.Location = new Point(439, 29);
            Jetons.Name = "Jetons";
            Jetons.Size = new Size(83, 32);
            Jetons.TabIndex = 5;
            Jetons.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(157, 99);
            label3.Name = "label3";
            label3.Size = new Size(492, 30);
            label3.TabIndex = 6;
            label3.Text = "Wählen Sie aus wie viele Jetons Sie Kaufen wollen";
            label3.Click += label3_Click;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.MenuHighlight;
            button2.Location = new Point(205, 159);
            button2.Name = "button2";
            button2.Size = new Size(152, 52);
            button2.TabIndex = 13;
            button2.Text = "10 Jetons";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Back
            // 
            Back.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Back.ForeColor = SystemColors.ButtonFace;
            Back.Location = new Point(308, 360);
            Back.Name = "Back";
            Back.Size = new Size(157, 50);
            Back.TabIndex = 14;
            Back.Text = "Back";
            Back.UseVisualStyleBackColor = true;
            Back.Click += Back_Click;
            // 
            // button3
            // 
            button3.BackColor = SystemColors.MenuHighlight;
            button3.Location = new Point(205, 217);
            button3.Name = "button3";
            button3.Size = new Size(152, 52);
            button3.TabIndex = 15;
            button3.Text = "60 Jetons";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click_1;
            // 
            // button4
            // 
            button4.BackColor = SystemColors.MenuHighlight;
            button4.Location = new Point(205, 275);
            button4.Name = "button4";
            button4.Size = new Size(152, 52);
            button4.TabIndex = 16;
            button4.Text = "120 Jetons";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.BackColor = SystemColors.MenuHighlight;
            button5.Location = new Point(439, 159);
            button5.Name = "button5";
            button5.Size = new Size(152, 52);
            button5.TabIndex = 17;
            button5.Text = "1200 Jetons";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click_1;
            // 
            // button6
            // 
            button6.BackColor = SystemColors.MenuHighlight;
            button6.Location = new Point(439, 217);
            button6.Name = "button6";
            button6.Size = new Size(152, 52);
            button6.TabIndex = 18;
            button6.Text = "10'000 Jetons";
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            // 
            // Max
            // 
            Max.BackColor = SystemColors.MenuHighlight;
            Max.Location = new Point(439, 275);
            Max.Name = "Max";
            Max.Size = new Size(152, 52);
            Max.TabIndex = 19;
            Max.UseVisualStyleBackColor = false;
            Max.Click += Max_Click;
            // 
            // uy
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 448);
            Controls.Add(Max);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(Back);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(Jetons);
            Controls.Add(label2);
            Controls.Add(Cash);
            Controls.Add(label1);
            Controls.Add(ATM);
            Controls.Add(button1);
            DoubleBuffered = true;
            Name = "uy";
            Text = "uy";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label ATM;
        private Label label1;
        private Label Cash;
        private Label label2;
        private Label Jetons;
        private Label label3;
        private Button button2;
        private Button Back;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button Max;
    }
}