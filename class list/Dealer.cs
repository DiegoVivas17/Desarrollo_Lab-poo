using System;
using System.Collections.Generic;
using System.Text;

namespace class_list
{
    public class Dealer
    {
        private List<Card> deck;

        public void Generate()
        {
            deck = new List<Card>();

            char[] suits = { '♥', '♦', '♣', '♠' };

            string[] symbols = { "A","2","3","4","5","6",
                                 "7","8","9","10","J","Q","K",};

            foreach (char su in suits)
            {
                foreach (string sy in symbols)
                {
                    Card c = new Card(su, sy);
                    deck.Add(c);
                }
            }
        }

    }
}
