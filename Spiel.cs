using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
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
        private TextBox betTextBox;
        private Button startGameButton;
        private Button backButton; // Zurück-Button

        public Spiel()
        {
            InitializeComponent();
            deck = CreateDeck();
            playerHand = new List<Card>();
            dealerHand = new List<Card>();
            playerScore = 0;

            // Lade Guthaben
            playerBalance = LoadBalance();

            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;

            // Balance Label
            balanceLabel = new Label
            {
                Text = "Guthaben: " + playerBalance,
                Location = new Point(formWidth - 500, 20),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(balanceLabel);

            // Score Label
            scoreLabel = new Label
            {
                Text = "Punkte: 0",
                Location = new Point(formWidth - 500, 200),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(scoreLabel);

            // Dealer Label
            dealerLabel = new Label
            {
                Text = "Dealer: ? + ?",
                Location = new Point(formWidth / 2 - 100, 80),
                Size = new Size(200, 30),
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(dealerLabel);

            // Karte ziehen Button
            drawButton = new Button
            {
                Text = "Karte ziehen",
                Location = new Point(formWidth / 2 - 200, formHeight - 300),
                Size = new Size(100, 30)
            };
            drawButton.Click += DrawCard;
            drawButton.Enabled = false; // Zu Beginn deaktiviert
            this.Controls.Add(drawButton);

            // Halten Button
            holdButton = new Button
            {
                Text = "Halten",
                Location = new Point(formWidth / 2 + 50, formHeight - 300),
                Size = new Size(100, 30)
            };
            holdButton.Click += Hold;
            holdButton.Enabled = false; // Zu Beginn deaktiviert
            this.Controls.Add(holdButton);

            // Einsatz Eingabe
            betTextBox = new TextBox
            {
                Location = new Point(formWidth / 2 - 50, formHeight - 400),
                Size = new Size(100, 30),
                Text = "0"
            };
            this.Controls.Add(betTextBox);

            // Start Spiel Button
            startGameButton = new Button
            {
                Text = "Start Spiel",
                Location = new Point(formWidth / 2 - 50, formHeight - 350),
                Size = new Size(100, 30)
            };
            startGameButton.Click += StartGame;
            this.Controls.Add(startGameButton);

            // "Zurück"-Button hinzufügen
            backButton = new Button
            {
                Text = "Zurück",
                Location = new Point(formWidth / 2 - 50, formHeight - 250), // Position anpassen
                Size = new Size(100, 30)
            };
            backButton.Click += button1_Click; // Ereignis verknüpfen
            this.Controls.Add(backButton);
        }

        private void StartGame(object sender, EventArgs e)
        {
            // Setze den Einsatz des Spielers
            int betAmount;
            if (int.TryParse(betTextBox.Text, out betAmount) && betAmount > 0 && betAmount <= playerBalance)
            {
                playerBet = betAmount;
                playerBalance -= playerBet;
                balanceLabel.Text = "Guthaben: " + playerBalance;
                startGameButton.Enabled = false;
                betTextBox.Enabled = false;

                // Starte das Spiel
                deck = CreateDeck();
                playerHand.Clear();
                dealerHand.Clear();
                playerScore = 0;

                // Karten austeilen
                playerHand.Add(deck[0]);
                deck.RemoveAt(0);
                playerHand.Add(deck[0]);
                deck.RemoveAt(0);
                dealerHand.Add(deck[0]);
                deck.RemoveAt(0);
                dealerHand.Add(deck[0]);
                deck.RemoveAt(0);

                playerScore = CalculateScore(playerHand);
                scoreLabel.Text = "Punkte: " + playerScore;
                dealerLabel.Text = $"Dealer: {dealerHand[0]} + ?";

                // Setze Dealer- und Spieler-Karten
                int formWidth = this.ClientSize.Width;
                int formHeight = this.ClientSize.Height;

                // Dealer
                Label dealerCard1 = new Label
                {
                    Text = dealerHand[0].ToString(),
                    Size = new Size(120, 30),
                    Location = new Point(250, 45),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                this.Controls.Add(dealerCard1);

                Label dealerCard2 = new Label
                {
                    Text = "Verdeckt",
                    Size = new Size(120, 30),
                    Location = new Point(formWidth - 400, 45),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                this.Controls.Add(dealerCard2);

                // Spieler
                Label playerCard1 = new Label
                {
                    Text = playerHand[0].ToString(),
                    Size = new Size(120, 30),
                    Location = new Point(250, formHeight - 150),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                this.Controls.Add(playerCard1);

                Label playerCard2 = new Label
                {
                    Text = playerHand[1].ToString(),
                    Size = new Size(120, 30),
                    Location = new Point(formWidth - 400, formHeight - 150),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                this.Controls.Add(playerCard2);

                // Buttons aktivieren
                drawButton.Enabled = true;
                holdButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ungültiger Einsatz. Dein Guthaben: " + playerBalance);
            }
        }

        private void DrawCard(object sender, EventArgs e)
        {
            if (deck.Count == 0)
            {
                MessageBox.Show("Das Deck ist leer!");
                return;
            }

            Card drawnCard = deck[0];
            deck.RemoveAt(0);
            playerHand.Add(drawnCard);
            playerScore = CalculateScore(playerHand);

            Label cardLabel = new Label
            {
                Text = drawnCard.ToString(),
                Location = new Point(this.ClientSize.Width / 2, this.ClientSize.Height - 120 - (playerHand.Count * 30)),
                Size = new Size(120, 30),
                BorderStyle = BorderStyle.FixedSingle,
                TextAlign = ContentAlignment.MiddleCenter
            };
            this.Controls.Add(cardLabel);

            scoreLabel.Text = "Punkte: " + playerScore;

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
            // Deaktiviere den "Karte ziehen"-Button, damit der Spieler nicht weiterziehen kann
            drawButton.Enabled = false;

            // Der Dealer zieht nun Karten, bis seine Punktzahl mindestens 17 beträgt
            DealerTurn();
        }

        private void DealerTurn()
        {
            // Aktualisiere die Dealer-Kartenanzeige, um die aktuelle Hand des Dealers zu zeigen
            dealerLabel.Text = $"Dealer: {dealerHand[0]} + {dealerHand[1]}";

            // Solange der Dealer weniger als 17 Punkte hat, zieht er Karten
            while (CalculateScore(dealerHand) < 17)
            {
                Card drawnCard = deck[0];
                deck.RemoveAt(0);
                dealerHand.Add(drawnCard);

                // Dealer-Karten anzeigen
                Label dealerCard = new Label
                {
                    Text = drawnCard.ToString(),
                    Location = new Point(this.ClientSize.Width / 2 + 100, 80 + dealerHand.Count * 30),
                    Size = new Size(120, 30),
                    BorderStyle = BorderStyle.FixedSingle,
                    TextAlign = ContentAlignment.MiddleCenter
                };
                this.Controls.Add(dealerCard);
            }

            // Berechne die Dealer-Punktzahl
            int dealerScore = CalculateScore(dealerHand);

            // Zeige das Ergebnis an
            EndGame(dealerScore <= 21 && CalculateScore(playerHand) > dealerScore);
        }

        private void EndGame(bool playerWins)
        {
            int dealerScore = CalculateScore(dealerHand);
            int playerScore = CalculateScore(playerHand);

            if (playerWins)
            {
                int winAmount = playerBet * 2; // Blackjack Gewinn (doppelt)
                if (playerScore == 21)
                {
                    winAmount = playerBet * 2; // Blackjack-Sonderregel
                }
                playerBalance += winAmount;
                MessageBox.Show($"Du hast gewonnen! Dein Gewinn: {winAmount} Dein Guthaben: {playerBalance}");
            }
            else if (playerScore == dealerScore)
            {
                playerBalance += playerBet; // Unentschieden - Einsatz zurück
                MessageBox.Show($"Unentschieden! Dein Guthaben bleibt bei: {playerBalance}");
            }
            else
            {
                MessageBox.Show($"Du hast verloren! Dein Guthaben: {playerBalance}");
            }

            // Guthaben anzeigen und speichern
            balanceLabel.Text = "Guthaben: " + playerBalance;
            SaveBalance(playerBalance);

            // Deaktiviere Buttons nach Spielende
            drawButton.Enabled = false;
            holdButton.Enabled = false;

            // Spiel zurücksetzen für das nächste Spiel
            ResetGame();
        }

        private void ResetGame()
        {
            startGameButton.Enabled = true;
            betTextBox.Enabled = true;
            betTextBox.Clear();
        }

        private int CalculateScore(List<Card> hand)
        {
            int score = 0;
            int aceCount = 0;

            foreach (var card in hand)
            {
                score += card.Value;
                if (card.Rank == "A")
                    aceCount++;
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

        // Lade Guthaben
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
            return 10000; // Standardwert
        }

        // Speichere Guthaben
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
                    deck.Add(new Card
                    {
                        Suit = suit,
                        Rank = ranks[i],
                        Value = value
                    });
                }
            }

            Random rnd = new Random();
            return deck.OrderBy(x => rnd.Next()).ToList();
        }

        // Zurück-Button Ereignis
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
