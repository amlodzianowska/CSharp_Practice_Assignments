using System;

namespace DeckOfCards
{
    class Card
    {
        public string stringVal;
        public string suit;
        public int val;
        
    public Card(string strval, string suit, int val)
        {
            this.stringVal = strval;
            this.suit = suit;
            this.val = val;
        }
    }

}