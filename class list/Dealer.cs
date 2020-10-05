using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace class_list
{
    public class Dealer
    {
        private List<Card> deck;
        private List<Card> hand;
        
        public List<Card> Hand { get => hand; set => hand = value; }
        public List<Card> Deck { get => deck; set => deck = value; }

        public void Generate()
        {
            Deck = new List<Card>();

            char[] suits = { '♥', '♦', '♣', '♠' };

            string[] symbols = { "A","2","3","4","5","6",
                                 "7","8","9","10","J","Q","K",};

            foreach (char su in suits)
            {
                foreach (string sy in symbols)
                {
                    Card c = new Card(su, sy);
                    Deck.Add(c);
                }
            }
        }

        public void Randomize()
        {
            Random rnd = new Random();

            this.deck = this.deck.OrderBy(x => (rnd.Next())).ToList();

        }

    }   
}
