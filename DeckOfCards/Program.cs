using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            d1.dealCard();
            d1.dealCard();
            d1.dealCard();
            d1.showDeck();
            Console.WriteLine("************************");
            d1.resetDeck();
            d1.showDeck();
        }
    }
}
