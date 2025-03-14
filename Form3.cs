using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Drawing;

namespace Lern_Oeriode_4
{
    public partial class Form3 : Form
    {
        private int playerMoney = 0;
        private int passiveIncome = 0;
        private Dictionary<string, int> purchasedIncome = new Dictionary<string, int>();
        private Label moneyLabel;
        private System.Windows.Forms.Timer incomeTimer;

        public Form3()
        {
            InitializeComponent();
            LoadMoney();
            LoadPassiveIncome();

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            incomeTimer = new System.Windows.Forms.Timer();
            incomeTimer.Interval = 1000;
            incomeTimer.Tick += GeneratePassiveIncome;
            incomeTimer.Start();

            moneyLabel = new Label
            {
                Text = "Geld: " + playerMoney,
                Location = new Point(formWidth - 820, 40),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(moneyLabel);
        }

        private void LoadMoney()
        {
            string filePath = "money.txt";
            if (File.Exists(filePath) && int.TryParse(File.ReadAllText(filePath), out int money))
            {
                playerMoney = money;
            }
            else
            {
                playerMoney = 1000;
                SaveMoney();
            }
        }

        private void SaveMoney()
        {
            File.WriteAllText("money.txt", playerMoney.ToString());
        }

        private void LoadPassiveIncome()
        {
            string filePath = "passive_income.txt";
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length == 2 && int.TryParse(parts[1], out int amount))
                    {
                        purchasedIncome[parts[0]] = amount;
                        passiveIncome += amount;

                        if (parts[0] == "Passiv1" && amount > 0) button2.Enabled = false;
                        if (parts[0] == "Passiv2" && amount > 0) button3.Enabled = false;
                        if (parts[0] == "Passiv3" && amount > 0) button4.Enabled = false;
                        if (parts[0] == "Passiv4" && amount > 0) button5.Enabled = false;
                        if (parts[0] == "Passiv5" && amount > 0) button6.Enabled = false;
                    }
                }
            }
        }

        private void SavePassiveIncome()
        {
            string filePath = "passive_income.txt";
            List<string> lines = new List<string>();
            foreach (var income in purchasedIncome)
            {
                lines.Add($"{income.Key}:{income.Value}");
            }
            File.WriteAllLines(filePath, lines);

            MessageBox.Show("Passives Einkommen gespeichert!");
        }

        private void GeneratePassiveIncome(object sender, EventArgs e)
        {
            playerMoney += passiveIncome;
            moneyLabel.Text = "Geld: " + playerMoney;
            SaveMoney();
        }

        private void KaufenPassiveEinkommen(string incomeName, int cost, int incomePerSecond, Button button)
        {
            if (playerMoney >= cost)
            {
                playerMoney -= cost;
                moneyLabel.Text = "Geld: " + playerMoney;

                MessageBox.Show($"Neues Geld nach Kauf: {playerMoney}");

                if (!purchasedIncome.ContainsKey(incomeName))
                {
                    purchasedIncome[incomeName] = incomePerSecond;
                    passiveIncome += incomePerSecond;
                    button.Enabled = false;

                    SaveMoney();
                    SavePassiveIncome();

                    MessageBox.Show($"Gekauft: {incomeName}! Jetzt verdienst du {incomePerSecond} mehr pro Sekunde!");
                }
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 2 wurde gedrückt!");
            KaufenPassiveEinkommen("Passiv1", 100, 1, button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 3 wurde gedrückt!");
            KaufenPassiveEinkommen("Passiv2", 1000, 10, button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 4 wurde gedrückt!");
            KaufenPassiveEinkommen("Passiv3", 25000, 1200, button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 5 wurde gedrückt!");
            KaufenPassiveEinkommen("Passiv4", 100000, 10000, button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button 6 wurde gedrückt!");
            KaufenPassiveEinkommen("Passiv5", 1000000, 100000, button6);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
