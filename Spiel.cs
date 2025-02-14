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
    public partial class Spiel : Form
    {
        private List<Card> deck;

        public Spiel()
        {
            InitializeComponent();
            deck = CreateDeck(); 
            DisplayDeckAsLabels(deck);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1(); 
            form1.Show();             
            this.Hide();
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
        private void DisplayDeckAsLabels(List<Card> deck)
        {
            int x = 10, y = 10; 

            foreach (var card in deck)
            {
                Label cardLabel = new Label
                {
                    Text = card.ToString(), 
                    Size = new Size(120, 30), 
                    Location = new Point(x, y), 
                    BorderStyle = BorderStyle.FixedSingle 
                };

                this.Controls.Add(cardLabel); 

                y += 35; 
                if (y > this.Height - 50) 
                {
                    y = 10;
                    x += 130; 
                }
            }
        }

    }
}
