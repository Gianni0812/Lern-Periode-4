using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace Lern_Oeriode_4
{
    public partial class uy : Form
    {
        private int playerMoney;
        private int playerBalance;

        public uy()
        {
            InitializeComponent();


            Cash.ForeColor = Color.LightGreen;
            Jetons.ForeColor = Color.LightBlue;
            Back.BackColor = Color.Red;


            playerMoney = LoadMoney();
            playerBalance = LoadBalance();


            Cash.Text = "" + playerMoney;
            Jetons.Text = "" + playerBalance;
            Max.Text = $"Max: ({playerMoney})";
        }



        private void button1_Click(object sender, EventArgs e) { }

        private void button2_Click(object sender, EventArgs e)
        {
            int preis = 15;
            int jetons = 10;

            if (playerMoney >= preis)
            {
                playerMoney -= preis;
                playerBalance += jetons;

                Cash.Text = "" + playerMoney;
                Jetons.Text = "" + playerBalance;

                SaveMoney(playerMoney);
                SaveBalance(playerBalance);
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void button3_Click(object sender, EventArgs e) { }

        private void button4_Click(object sender, EventArgs e) { }

        private void button5_Click(object sender, EventArgs e) { }



        private void SaveMoney(int money)
        {
            File.WriteAllText("money.txt", money.ToString());
        }

        private void SaveBalance(int balance)
        {
            File.WriteAllText("balance.txt", balance.ToString());
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



        private void Back_Click(object sender, EventArgs e)
        {
            Form2 newForm = new Form2();
            newForm.Show();
            this.Hide();
        }



        private void label1_Click(object sender, EventArgs e) { }
        private void Cash_Click(object sender, EventArgs e) { }
        private void ATM_Click(object sender, EventArgs e) { }
        private void label1_Click_1(object sender, EventArgs e) { }

        private void button3_Click_1(object sender, EventArgs e)
        {
            int preis = 75;
            int jetons = 60;

            if (playerMoney >= preis)
            {
                playerMoney -= preis;
                playerBalance += jetons;

                Cash.Text = "" + playerMoney;
                Jetons.Text = "" + playerBalance;

                SaveMoney(playerMoney);
                SaveBalance(playerBalance);
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            int preis = 150;
            int jetons = 120;

            if (playerMoney >= preis)
            {
                playerMoney -= preis;
                playerBalance += jetons;

                Cash.Text = "" + playerMoney;
                Jetons.Text = "" + playerBalance;

                SaveMoney(playerMoney);
                SaveBalance(playerBalance);
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            int preis = 1500;
            int jetons = 1200;

            if (playerMoney >= preis)
            {
                playerMoney -= preis;
                playerBalance += jetons;

                Cash.Text = "" + playerMoney;
                Jetons.Text = "" + playerBalance;

                SaveMoney(playerMoney);
                SaveBalance(playerBalance);
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int preis = 15000;
            int jetons = 10000;

            if (playerMoney >= preis)
            {
                playerMoney -= preis;
                playerBalance += jetons;

                Cash.Text = "" + playerMoney;
                Jetons.Text = "" + playerBalance;

                SaveMoney(playerMoney);
                SaveBalance(playerBalance);
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void Max_Click(object sender, EventArgs e)
        {
            if (playerMoney > 0)
            {
                int jetons = playerMoney;
                playerBalance += jetons;
                playerMoney = 0;

                Cash.Text = "" + playerMoney;
                Jetons.Text = "" + playerBalance;

                SaveMoney(playerMoney);
                SaveBalance(playerBalance);
            }
            else
            {
                MessageBox.Show("Kein Geld auf dem Konto!");
            }
        }

        private void label3_Click(object sender, EventArgs e){}
    }
}


