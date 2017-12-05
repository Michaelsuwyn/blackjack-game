using System;
using System.Collections.Generic;
using System.Text;

namespace blackjack
{
    class Card
    {
        public int value { get; set; }
        public string suite { get; set; }
        
        public Card(int value, string suite)
        {
            this.value = value;
            this.suite = suite;
        }

        override
        public string ToString()
        {
            return value + " of " + suite; 
            
        }
    }
}
