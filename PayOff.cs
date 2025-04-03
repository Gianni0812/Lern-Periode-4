using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Lern_Oeriode_4
{
    public partial class PayOff : Form
    {
        private int playerMoney;
        private int playerBalance;

        public PayOff()
        {
            InitializeComponent();

            Cash.ForeColor = Color.LightGreen;
            Jetons.ForeColor = Color.LightBlue;
            Back.BackColor = Color.Red;

            playerMoney = LoadMoney();
            playerBalance = LoadBalance();

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            Cash.Text = "" + playerMoney;
            Jetons.Text = "" + playerBalance;
            Max.Text = $"Max: ({playerBalance})";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int jetons = 10;
            int geld = 15;

            if (playerBalance >= jetons)
            {
                playerBalance -= jetons;
                playerMoney += geld;
                UpdateLabels();
                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int jetons = 60;
            int geld = 75;

            if (playerBalance >= jetons)
            {
                playerBalance -= jetons;
                playerMoney += geld;
                UpdateLabels();
                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int jetons = 120;
            int geld = 150;

            if (playerBalance >= jetons)
            {
                playerBalance -= jetons;
                playerMoney += geld;
                UpdateLabels();
                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int jetons = 1200;
            int geld = 1500;

            if (playerBalance >= jetons)
            {
                playerBalance -= jetons;
                playerMoney += geld;
                UpdateLabels();
                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int jetons = 10000;
            int geld = 15000;

            if (playerBalance >= jetons)
            {
                playerBalance -= jetons;
                playerMoney += geld;
                UpdateLabels();
                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (playerBalance > 0)
            {
                int geld = playerBalance;
                playerMoney += geld;
                playerBalance = 0;
                UpdateLabels();
                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Keine Jetons zum Verkaufen!");
            }
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }

        private int LoadMoney()
        {
            string filePath = "money.txt";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "40000");
                return 40000;
            }

            string content = File.ReadAllText(filePath);
            if (int.TryParse(content, out int money))
            {
                return money;
            }

            File.WriteAllText(filePath, "40000");
            return 40000;
        }

        private int LoadBalance()
        {
            string filePath = "balance.txt";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "10000");
                return 10000;
            }

            string content = File.ReadAllText(filePath);
            if (int.TryParse(content, out int balance))
            {
                return balance;
            }

            File.WriteAllText(filePath, "10000");
            return 10000;
        }

        private void SaveMoney(int money)
        {
            File.WriteAllText("money.txt", money.ToString());
        }

        private void SaveBalance(int balance)
        {
            File.WriteAllText("balance.txt", balance.ToString());
        }

        private void Back_Click_1(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }
    }
}
