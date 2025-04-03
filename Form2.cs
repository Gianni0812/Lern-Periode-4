using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Lern_Oeriode_4
{
    public partial class Form2 : Form
    {
        private int playerBalance;
        private int playerMoney;

        private Label balanceLabel;
        private Label moneyLabel;
        private Label jetonsTextLabel;
        private Label cashTextLabel;

        public Form2()
        {
            InitializeComponent();

            
            JetonsKaufen.BackColor = Color.LimeGreen;
            JetonsVerkaufen.BackColor = Color.LimeGreen;
            Back.BackColor = Color.Red;


            playerBalance = LoadBalance();
            playerMoney = LoadMoney();

            Cash.Text = "" + playerMoney;
            Jetons.Text = "" + playerBalance;

            int formWidth = this.ClientSize.Width;

            
            
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

        private void SaveMoney(int money)
        {
            File.WriteAllText("money.txt", money.ToString());
        }

        private void SaveBalance(int balance)
        {
            File.WriteAllText("balance.txt", balance.ToString());
        }

        private void JetonsKaufen_Click(object sender, EventArgs e)
        {
            uy kaufForm = new uy(); 
            kaufForm.Show();
            this.Hide();
        }

        private void JetonsVerkaufen_Click(object sender, EventArgs e)
        {
            PayOff verkaufForm = new PayOff(); 
            verkaufForm.Show();
            this.Hide();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form1 mainForm = new Form1();
            mainForm.Show();
            this.Hide();
        }
    }
}