using System;
using System.Collections.Generic;

namespace blackjack
{
    class Program
    {
        static void Main()
        {
            string start = "";
            Hand hand = new Hand();
            dealer dealer = new dealer();
            Deck deckOne = new Deck();
            bool isGameOver = false;




            Console.WriteLine("Type Go to begin!");
            start = Console.ReadLine();
            if (start == "go")
            {
                Console.WriteLine("here we go");

                hand.AddCard(deckOne.deal());
                hand.AddCard(deckOne.deal());
                dealer.AddCard(deckOne.deal());
                dealer.AddCard(deckOne.deal());
                

                while(!isGameOver)
                {
                    hand.DisplayHand();
                    Console.WriteLine(hand.GetPoints() + " your points");
                    Console.WriteLine("-----------------------------------------------------------");
                    dealer.DisplayHand();
                    Console.WriteLine(dealer.PartialPoints() + " dealers points");
                    Console.WriteLine("-----------------------------------------------------------");


                    if (hand.GetPoints() > 21)
                    {
                        Console.WriteLine("Busted!!!");
                        isGameOver = true;
                    }

                    else if (hand.GetPoints() == 21)
                    {
                        Console.WriteLine("winner");
                        isGameOver = true;
                    }
                    else
                    {
                        if (dealer.GetPoints() <= 13)
                        {
                            dealer.AddCard(deckOne.deal());
                            Console.WriteLine("Dealer Hit!");
                        }
                        else if(dealer.GetPoints() < 15 && dealer.flip())
                        {
                            dealer.AddCard(deckOne.deal());
                        }
                        else
                        {
                            Console.WriteLine("Dealer passed!");
                        }
                        

                        Console.WriteLine("hit or pass?");
                        string comment = Console.ReadLine();
                       
                        
                        if (comment == "hit")
                        {
                            hand.AddCard(deckOne.deal());

                        }
                        else if (comment == "pass")
                        {
                            if(hand.GetPoints() > dealer.GetPoints())
                            {
                                Console.WriteLine("Winner!");
                                
                            }
                            else if(hand.GetPoints() == dealer.GetPoints())
                            {
                                Console.WriteLine("Draw!");
                            }
                            else
                            {
                                Console.WriteLine("You Lose!");
                            }
                            Console.WriteLine("Dealer had " + dealer.GetPoints() + " Points!");
                            isGameOver = true;
                        }


                   
 }

                }







            }
            else
            {
                Console.WriteLine("cmon type go");
                Console.ReadLine();

            }

            List<Card> cards = new List<Card>();
            Console.ReadLine();

        }

             





            


           


        
        }
        
    }

