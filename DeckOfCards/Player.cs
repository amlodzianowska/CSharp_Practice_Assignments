using System;
using System.Collections.Generic;

namespace DeckOfCards
{
    class Player
    {
        public string name;
        public List<Card> Hand;

        public Player(string name)
        {
            this.name = name;
            Hand = new List<Card>();
        }

        public Card draw(Deck deck)
        {
            Random rand = new Random();
            int count = deck.DeckofCards.Count;
            int drawIdx = rand.Next(0, count);
            Card drawnCard = deck.DeckofCards[drawIdx];
            deck.DeckofCards.RemoveAt(drawIdx);
            Hand.Add(drawnCard);
            return drawnCard;
        }

        public Card discard(int idx)
        {
            if (idx > Hand.Count)
            {
                return null;
            }
            else
            {
                Card discardedCard = Hand[idx];
                Console.WriteLine($"Discarding: {Hand[idx].stringVal}");
                Hand.RemoveAt(idx);
                return discardedCard;
            }
        }

        public void showHand()
        {
            foreach (Card c in Hand)
            {
                Console.WriteLine($"{c.stringVal} {c.suit}, {c.val}");
            }
        }
    }
}