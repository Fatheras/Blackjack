using System;
using System.Collections.Generic;
using System.Linq;

namespace BlackJack
{
    class CardDeck
    {
        public List<Card> Deck = new List<Card>(52);

        public CardDeck()
        {
            CreateDeck();
            ShuffleDeck();
        }
        private void CreateDeck()
        {
            for (int i = 0; i < MagicNumbers.numberOfRank; i++)
            {
                for (int j = 0; j < MagicNumbers.numberOfSuit; j++)
                {
                    Deck.Add(new Card(i, j));
                }
            }
        }
        private void ShuffleDeck()
        {
            Random rand = new Random();
            for (int i = 0; i < MagicNumbers.numberOfCard; i++)
            {
                Card card = Deck[i];
                Deck.RemoveAt(i);
                Deck.Insert(rand.Next(0, Deck.Count), card);
            }
        }
        public List<Card> GetStartHand()
        {
            List<Card> cards = new List<Card>();
            for (int i = 1; i <= 2; i++)
            {
                cards.Add(Deck.Last());
                Deck.RemoveAt(Deck.Count - i);
            }
            return cards;
        }
        public Card GetCard()
        {
            Card tmp = Deck.Last();
            Deck.RemoveAt(Deck.Count - 1);
            return tmp;
        }
        public void Reset()
        {
            CardDeck temp = new CardDeck();
            Deck = temp.Deck;
        }
    }
}
