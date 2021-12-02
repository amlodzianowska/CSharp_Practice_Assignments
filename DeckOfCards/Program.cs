using System;

namespace DeckOfCards
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            Player p1 = new Player("Nose");
            // d1.dealCard();
            // d1.dealCard();
            // d1.dealCard();
            // d1.showDeck();
            // Console.WriteLine("************************");
            // d1.resetDeck();
            // d1.showDeck();
            // d1.shuffleDeck();
            // Console.WriteLine("************************");
            // d1.showDeck();
            p1.draw(d1);
            p1.draw(d1);
            p1.draw(d1);
            p1.draw(d1);
            p1.showHand();
            // d1.showDeck();
            Console.WriteLine("************************");
            p1.discard(2);
            p1.showHand();
        }
    }
}
