using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Deck
    {
        public List<Card> DeckofCards;

        string[] suits = new string[] {"Clubs", "Spades", "Hearts", "Diamonds"};
        string[] cards = new string[] {"Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Qween", "King"};
        public Deck()
        {
            DeckofCards = new List<Card>();
            {
                for (int i = 0; i<suits.Length; i++)
                {
                    for (int j=0; j<cards.Length; j++)
                    {
                        DeckofCards.Add(new Card(cards[j], suits[i], j+1));
                    }
                }
            }
        }
        public void showDeck()
        {
            int num = 1;
            foreach (Card card in DeckofCards)
            {
                Console.WriteLine($"Card's #: {num}, {card.stringVal} {card.suit}, {card.val}");
                num++;
            }
        }

        public Card dealCard()
        {
            Card dealtCard = DeckofCards[0];
            DeckofCards.RemoveAt(0);
            Console.WriteLine($"{dealtCard.stringVal} {dealtCard.suit} has been dealt");
            return dealtCard;
        }

        public void resetDeck()
        {
            DeckofCards = new List<Card>();
            {
                for (int i = 0; i<suits.Length; i++)
                {
                    for (int j=0; j<cards.Length; j++)
                    {
                        DeckofCards.Add(new Card(cards[j], suits[i], j+1));
                    }
                }
            }
        }

        public void shuffleDeck()
        {
            Random rand = new Random();
            for (int i=0; i<DeckofCards.Count; i++)
            {
                int count = DeckofCards.Count + 1 - i;
                int randomNow = rand.Next(0, count);
                Card randCard = DeckofCards[randomNow];
                DeckofCards.RemoveAt(randomNow);
                DeckofCards.Add(randCard);
            }
        }
    }
}



