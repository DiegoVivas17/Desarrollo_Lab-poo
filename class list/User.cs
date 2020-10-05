using System;
using System.Collections.Generic;
using System.Text;

namespace class_list
{
    public class User
    {
        List<Card> hand;

        public List<Card> Hand { get => hand; set => hand = value; }

        public void AddCard(Card c)
        {
            hand.Add(c);
        }
    }
}
