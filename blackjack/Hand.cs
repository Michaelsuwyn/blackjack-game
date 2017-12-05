using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack
{
    class Hand
    {
        
        public List<Card> PlayerHand = new List<Card>();
        

      public void AddCard(Card card)
        {
            PlayerHand.Add(card);
           
        }

        public void DisplayHand()
        {
            foreach (Card c in PlayerHand)
            {
                Console.WriteLine(c.ToString());

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
           

        }

    }

