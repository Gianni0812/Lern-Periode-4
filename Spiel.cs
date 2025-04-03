// Neu strukturierter Spiel-Code mit gestaffeltem Kartenlayout

using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lern_Oeriode_4
{
    public partial class Spiel : Form
    {
        private List<Card> deck;
        private List<Card> playerHand;
        private List<Card> dealerHand;
        private int playerScore;
        private int playerBalance;
        private int playerBet;
        private Label scoreLabel;
        private Label dealerLabel;
        private Label balanceLabel;
        private Button drawButton;
        private Button holdButton;
        private Button doubleButton;
        private TextBox betTextBox;
        private Button startGameButton;
        private Button backButton;

        public Spiel()
        {
            InitializeComponent();

            button1.BackColor = Color.LightBlue;

            deck = CreateDeck();
            playerHand = new List<Card>();
            dealerHand = new List<Card>();
            playerScore = 0;
            playerBalance = LoadBalance();

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            balanceLabel = new Label
            {
                Text = "Jetons: " + playerBalance,
                Location = new Point(formWidth - 820, 60),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(balanceLabel);

            scoreLabel = new Label
            {
                Text = "Punkte: 0",
                Location = new Point(formWidth - 500, 200),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(scoreLabel);

            dealerLabel = new Label
            {
                Text = "Dealer: ? + ?",
                Location = new Point(formWidth / 2 - 100, 80),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(dealerLabel);

            drawButton = new Button
            {
                Text = "Karte ziehen",
                Location = new Point(formWidth / 2 - 200, formHeight - 300),
                Size = new Size(100, 30),
                Enabled = false
            };
            drawButton.Click += DrawCard;
            this.Controls.Add(drawButton);

            doubleButton = new Button
            {
                Text = "Verdoppeln",
                Location = new Point(formWidth / 2 - 75, formHeight - 300),
                Size = new Size(100, 30),
                Enabled = false
            };
            doubleButton.Click += DoubleDown;
            this.Controls.Add(doubleButton);

            holdButton = new Button
            {
                Text = "Halten",
                Location = new Point(formWidth / 2 + 50, formHeight - 300),
                Size = new Size(100, 30),
                Enabled = false
            };
            holdButton.Click += Hold;
            this.Controls.Add(holdButton);

            betTextBox = new TextBox
            {
                Location = new Point(formWidth / 2 - 350, formHeight - 150),
                Size = new Size(100, 30),
                Text = ""
            };
            this.Controls.Add(betTextBox);

            startGameButton = new Button
            {
                Text = "Start Spiel",
                Location = new Point(formWidth / 2 - 350, formHeight - 100),
                Size = new Size(100, 30)
            };
            startGameButton.Click += StartGame;
            this.Controls.Add(startGameButton);

            backButton = new Button
            {
                Text = "Zurück",
                Location = new Point(formWidth / 2 - 50, formHeight - 250),
                Size = new Size(100, 30)
            };
            backButton.Click += button1_Click;
            this.Controls.Add(backButton);
        }

        private void StartGame(object sender, EventArgs e)
        {
            if (int.TryParse(betTextBox.Text, out int betAmount) && betAmount > 0 && betAmount <= playerBalance)
            {
                playerBet = betAmount;
                playerBalance -= playerBet;
                balanceLabel.Text = "Jetons: " + playerBalance;
                startGameButton.Enabled = false;
                betTextBox.Enabled = false;

                deck = CreateDeck();
                playerHand.Clear();
                dealerHand.Clear();
                playerScore = 0;

                playerHand.Add(deck[0]); deck.RemoveAt(0);
                playerHand.Add(deck[0]); deck.RemoveAt(0);
                dealerHand.Add(deck[0]); deck.RemoveAt(0);
                dealerHand.Add(deck[0]); deck.RemoveAt(0);

                playerScore = CalculateScore(playerHand);
                scoreLabel.Text = "Punkte: " + playerScore;
                dealerLabel.Text = $"Dealer: {dealerHand[0]} + ?";

                DisplayCards();

                drawButton.Enabled = true;
                holdButton.Enabled = true;
                doubleButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ungültiger Einsatz. Deine Jetons: " + playerBalance);
            }
        }

        private void DisplayCards()
        {
            ClearCardLabels();

            int cardWidth = 120;
            int cardHeight = 30;
            int spacing = 10;

            // Spieler-Karten (unten)
            for (int i = 0; i < playerHand.Count; i++)
            {
                int column = i / 2;
                int row = i % 2;
                int x = 250 + column * (cardWidth + spacing);
                int y = this.ClientSize.Height - 150 + row * (cardHeight + spacing);

                this.Controls.Add(CreateCardLabel(playerHand[i].ToString(), new Point(x, y)));
            }

            // Dealer-Karten (oben)
            for (int i = 0; i < dealerHand.Count; i++)
            {
                int column = i / 2;
                int row = i % 2;
                int x = 250 + column * (cardWidth + spacing);
                int y = 45 - row * (cardHeight + spacing);

                this.Controls.Add(CreateCardLabel(dealerHand[i].ToString(), new Point(x, y)));
            }
        }

        private void ClearCardLabels()
        {
            foreach (Control c in this.Controls.OfType<Label>().ToList())
            {
                if (c != scoreLabel && c != dealerLabel && c != balanceLabel)
                {
                    this.Controls.Remove(c);
                    c.Dispose();
                }
            }
        }

        private Label CreateCardLabel(string text, Point location)
        {
            return new Label
            {
                Text = text,
                Size = new Size(120, 30),
                Location = location,
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
        }

        private void DrawCard(object sender, EventArgs e)
        {
            if (deck.Count == 0) { MessageBox.Show("Das Deck ist leer!"); return; }

            Card drawnCard = deck[0];
            deck.RemoveAt(0);
            playerHand.Add(drawnCard);
            playerScore = CalculateScore(playerHand);

            scoreLabel.Text = "Punkte: " + playerScore;
            DisplayCards();

            if (playerScore > 21)
            {
                MessageBox.Show("Du hast dich überkauft! Punktzahl: " + playerScore);
                EndGame(false);
            }
            else if (playerScore == 21)
            {
                MessageBox.Show("Blackjack! Du hast gewonnen!");
                EndGame(true);
            }
        }

        private void Hold(object sender, EventArgs e)
        {
            drawButton.Enabled = false;
            holdButton.Enabled = false;
            doubleButton.Enabled = false;
            DealerTurn();
        }

        private void DoubleDown(object sender, EventArgs e)
        {
            if (playerBalance < playerBet) { MessageBox.Show("Nicht genug Jetons zum Verdoppeln!"); return; }

            playerBalance -= playerBet;
            playerBet *= 2;
            balanceLabel.Text = "Jetons: " + playerBalance;

            if (deck.Count == 0) { MessageBox.Show("Das Deck ist leer!"); return; }

            Card drawnCard = deck[0];
            deck.RemoveAt(0);
            playerHand.Add(drawnCard);
            playerScore = CalculateScore(playerHand);

            scoreLabel.Text = "Punkte: " + playerScore;
            DisplayCards();

            drawButton.Enabled = false;
            holdButton.Enabled = false;
            doubleButton.Enabled = false;

            if (playerScore > 21)
            {
                MessageBox.Show("Du hast dich überkauft! Punktzahl: " + playerScore);
                EndGame(false);
            }
            else
            {
                DealerTurn();
            }
        }

        private void DealerTurn()
        {
            while (CalculateScore(dealerHand) < 17)
            {
                dealerHand.Add(deck[0]);
                deck.RemoveAt(0);
            }
            dealerLabel.Text = $"Dealer Punkte: {CalculateScore(dealerHand)}";
            DisplayCards();

            EndGame(CalculateScore(dealerHand) <= 21 && playerScore > CalculateScore(dealerHand));
        }

        private void EndGame(bool playerWins)
        {
            int dealerScore = CalculateScore(dealerHand);
            dealerLabel.Text = $"Dealer Punkte: {dealerScore}";

            if (playerWins)
            {
                int winAmount = playerBet * 2;
                playerBalance += winAmount;
                MessageBox.Show($"Du hast gewonnen! Dein Gewinn: {winAmount} Deine Jetons: {playerBalance}");
            }
            else if (playerScore == dealerScore)
            {
                playerBalance += playerBet;
                MessageBox.Show($"Unentschieden! Deine Jetons bleibt bei: {playerBalance}");
            }
            else
            {
                MessageBox.Show($"Du hast verloren! Deine Jetons: {playerBalance}");
            }

            balanceLabel.Text = "Jetons: " + playerBalance;
            SaveBalance(playerBalance);

            drawButton.Enabled = false;
            holdButton.Enabled = false;
            doubleButton.Enabled = false;

            Task.Delay(2000).ContinueWith(_ => this.Invoke(new Action(ResetGame)));
        }

        private void ResetGame()
        {
            ClearCardLabels();

            dealerLabel.Text = "Dealer: ? + ?";
            scoreLabel.Text = "Punkte: 0";

            deck = CreateDeck();
            playerHand.Clear();
            dealerHand.Clear();
            playerScore = 0;

            betTextBox.Clear();
            betTextBox.Enabled = true;

            startGameButton.Enabled = true;
            drawButton.Enabled = false;
            holdButton.Enabled = false;
            doubleButton.Enabled = false;
        }

        private int CalculateScore(List<Card> hand)
        {
            int score = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                score += card.Value;
                if (card.Rank == "A") aceCount++;
            }

            while (score > 21 && aceCount > 0)
            {
                score -= 10;
                aceCount--;
            }

            return score;
        }

        public class Card
        {
            public string Suit { get; set; }
            public string Rank { get; set; }
            public int Value { get; set; }

            public override string ToString()
            {
                return $"{Rank} of {Suit}";
            }
        }

        private int LoadBalance()
        {
            string filePath = "balance.txt";
            if (File.Exists(filePath))
            {
                string content = File.ReadAllText(filePath);
                if (int.TryParse(content, out int balance)) return balance;
            }
            return 10000;
        }

        private void SaveBalance(int balance)
        {
            File.WriteAllText("balance.txt", balance.ToString());
        }

        public List<Card> CreateDeck()
        {
            string[] suits = { "Herz", "Karo", "Kreuz", "Pic" };
            string[] ranks = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            List<Card> deck = new List<Card>();

            foreach (var suit in suits)
            {
                for (int i = 0; i < ranks.Length; i++)
                {
                    int value = (i < 9) ? i + 2 : (i < 12) ? 10 : 11;
                    deck.Add(new Card { Suit = suit, Rank = ranks[i], Value = value });
                }
            }

            Random rnd = new Random();
            return deck.OrderBy(x => rnd.Next()).ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
