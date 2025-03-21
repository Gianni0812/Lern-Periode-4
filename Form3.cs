using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

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
                    if (parts.Length == 2 && int.TryParse(parts[1], out int count))
                    {
                        purchasedIncome[parts[0]] = count;
                        passiveIncome += GetIncomePerPurchase(parts[0]) * count;
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
        }

        private int GetIncomePerPurchase(string incomeName)
        {
            return incomeName switch
            {
                "Passiv1" => 1,
                "Passiv2" => 10,
                "Passiv3" => 1200,
                "Passiv4" => 10000,
                "Passiv5" => 100000,
                _ => 0
            };
        }

        private int GetCost(string incomeName)
        {
            return incomeName switch
            {
                "Passiv1" => 100,
                "Passiv2" => 1000,
                "Passiv3" => 25000,
                "Passiv4" => 100000,
                "Passiv5" => 1000000,
                _ => 0
            };
        }

        private void Kaufen(string incomeName)
        {
            int cost = GetCost(incomeName);
            int income = GetIncomePerPurchase(incomeName);

            if (playerMoney >= cost)
            {
                playerMoney -= cost;
                passiveIncome += income;

                if (!purchasedIncome.ContainsKey(incomeName))
                    purchasedIncome[incomeName] = 0;

                purchasedIncome[incomeName]++;

                SaveMoney();
                SavePassiveIncome();

                moneyLabel.Text = "Geld: " + playerMoney;
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void GeneratePassiveIncome(object sender, EventArgs e)
        {
            playerMoney += passiveIncome;
            moneyLabel.Text = "Geld: " + playerMoney;
            SaveMoney();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kaufen("Passiv1");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kaufen("Passiv2");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Kaufen("Passiv3");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Kaufen("Passiv4");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Kaufen("Passiv5");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SaveMoney();
            SavePassiveIncome();
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveMoney();
            SavePassiveIncome();
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
