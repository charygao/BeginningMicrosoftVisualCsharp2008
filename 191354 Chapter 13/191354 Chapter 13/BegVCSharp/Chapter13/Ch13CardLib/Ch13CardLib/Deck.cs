﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ch13CardLib
{
    // Addition for Expanding and Using CardLib section
    public delegate void LastCardDrawnHandler(Deck currentDeck);

    public class Deck : ICloneable
    {
        // Addition for Expanding and Using CardLib section
        public event LastCardDrawnHandler LastCardDrawn;

        public object Clone()
        {
            Deck newDeck = new Deck(cards.Clone() as Cards);
            return newDeck;
        }

        private Deck(Cards newCards)
        {
            cards = newCards;
        }

        private Cards cards = new Cards();

        public Deck()
        {
            // Line of code removed here
            for (int suitVal = 0; suitVal < 4; suitVal++)
            {
                for (int rankVal = 1; rankVal < 14; rankVal++)
                {
                    cards.Add(new Card((Suit)suitVal, (Rank)rankVal));
                }
            }
        }

        // Nondefault constructor. Allows aces to be set high.
        public Deck(bool isAceHigh)
            : this()
        {
            Card.isAceHigh = isAceHigh;
        }

        // Nondefault constructor. Allows a trump suit to be used.
        public Deck(bool useTrumps, Suit trump)
            : this()
        {
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        // Nondefault constructor. Allows aces to be set high and a trump suit
        // to be used.
        public Deck(bool isAceHigh, bool useTrumps, Suit trump)
            : this()
        {
            Card.isAceHigh = isAceHigh;
            Card.useTrumps = useTrumps;
            Card.trump = trump;
        }

        public Card GetCard(int cardNum)
        {
            if (cardNum >= 0 && cardNum <= 51)
            {
                // Addition for Expanding and Using CardLib section
                if ((cardNum == 51) && (LastCardDrawn != null))
                    LastCardDrawn(this);
                return cards[cardNum];
            }
            else
                throw new CardOutOfRangeException(cards.Clone() as Cards);
        }

        public void Shuffle()
        {
            Cards newDeck = new Cards();
            bool[] assigned = new bool[52];
            Random sourceGen = new Random();
            for (int i = 0; i < 52; i++)
            {
                int sourceCard = 0;
                bool foundCard = false;
                while (foundCard == false)
                {
                    sourceCard = sourceGen.Next(52);
                    if (assigned[sourceCard] == false)
                        foundCard = true;
                }
                assigned[sourceCard] = true;
                newDeck.Add(cards[sourceCard]);
            }
            newDeck.CopyTo(cards);
        }
    }
}