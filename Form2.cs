using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lern_Oeriode_4
{
    public partial class Form2 : Form
    {
        private int playerBalance;
        private Label balanceLabel;
        private Label moneyLabel;
        private int playerMoney;


        public Form2()
        {
            InitializeComponent();
            playerBalance = LoadBalance();
            playerMoney = LoadMoney();

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            balanceLabel = new Label
            {
                Text = "Jetons: " + playerBalance,
                Location = new Point(formWidth - 820, 70),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(balanceLabel);

            moneyLabel = new Label
            {
                Text = "Geld: " + playerMoney,
                Location = new Point(formWidth - 820, 40),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(moneyLabel);


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }


        private int LoadBalance()
        {
            string filePath = "balance.txt";
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                if (int.TryParse(content, out int balance))
                {
                    return balance;
                }
            }
            return 10000;
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int preis = 15;
            int jetons = 10;

            if (playerMoney >= preis)
            {
                playerMoney -= preis;
                playerBalance += jetons;


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void SaveMoney(int money)
        {
            File.WriteAllText("money.txt", money.ToString());
        }

        private void SaveBalance(int Jetons)
        {
            File.WriteAllText("balance.txt", playerBalance.ToString());
        }





        private void button3_Click(object sender, EventArgs e)
        {
            int preis = 75;
            int jetons = 60;

            if (playerMoney >= preis)
            {
                playerMoney -= preis;
                playerBalance += jetons;


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int preis = 150;
            int jetons = 120;

            if (playerMoney >= preis)
            {
                playerMoney -= preis;
                playerBalance += jetons;


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int preis = 1500;
            int jetons = 1200;

            if (playerMoney >= preis)
            {
                playerMoney -= preis;
                playerBalance += jetons;


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
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


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Geld!");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int Jetons = 10;
            int Geld = 15;

            if (playerMoney >= Jetons)
            {
                playerMoney += Geld;
                playerBalance -= Jetons;


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int Jetons = 60;
            int Geld = 75;

            if (playerMoney >= Jetons)
            {
                playerMoney += Geld;
                playerBalance -= Jetons;


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int Jetons = 120;
            int Geld = 150;

            if (playerMoney >= Jetons)
            {
                playerMoney += Geld;
                playerBalance -= Jetons;


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int Jetons = 1200;
            int Geld = 1500;

            if (playerMoney >= Jetons)
            {
                playerMoney += Geld;
                playerBalance -= Jetons;


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int Jetons = 10000;
            int Geld = 15000;

            if (playerBalance >= Jetons)
            {
                playerMoney += Geld;
                playerBalance -= Jetons;


                moneyLabel.Text = "Geld: " + playerMoney;
                balanceLabel.Text = "Jetons: " + playerBalance;


                SaveBalance(playerBalance);
                SaveMoney(playerMoney);
            }
            else
            {
                MessageBox.Show("Nicht genug Jetons!");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }
    }

}
