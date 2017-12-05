using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack
{
    class dealer
    {
        public List<Card> PlayerHand = new List<Card>();
        

      public void AddCard(Card card)
        {
            PlayerHand.Add(card);
           
        }

        public void DisplayHand()
        {
            for(int i = 1; i<PlayerHand.Count; i++)
            {
                Console.WriteLine(PlayerHand[i].ToString());

            }
        }

           public int GetPoints()
            {
                int points = 0;
                foreach (Card c in PlayerHand)
                {
                    
                    points += c.value;
                    

                }
                return points;
            
             }
        public int PartialPoints()
        {
            int points = 0;
            for (int i = 1; i<PlayerHand.Count; i++)
            {

                points += PlayerHand[i].value;


            }
            return points;
        }
        public bool flip()
        {
            Random random = new Random();
            int randomNum = random.Next(0, 100);
            return randomNum > 50;
        }

    }
}
