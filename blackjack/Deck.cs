using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack
{
    class Deck
    {

        private List<Card> Cards { get; set; }
        private string[] suites = { "Spade", "Heart", "Club", "Diamond" };

        public Deck()
        {
            Cards = new List<Card>();
            foreach(string suite in suites)
            {
                for(int i = 1; i <= 13; i++)
                {
                    if (i > 10)
                    {
                        Cards.Add(new Card(10, suite));
                    }
                    else
                    {

                        Cards.Add(new Card(i, suite));
                    }
                }
            }
            Shuffle(Cards);
                

        }

       
            public static void Shuffle(List<Card> list)
            {
                int n = list.Count;
                Random rnd = new Random();
                while (n > 1)
                {
                    int k = (rnd.Next(0, n) % n);
                    n--;
                    Card value = list[k];
                    list[k] = list[n];
                    list[n] = value;
                }
            }
        
            
        public Card deal()
        {
            Card card = Cards[0];
            Cards.RemoveAt(0);
            
            return card;
            }


       



    }
}
