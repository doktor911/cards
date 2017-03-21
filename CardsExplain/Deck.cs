using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsExplain
{
    public class Deck
    {
        List<Card> cards = new List<Card>();



        public Deck()
        {
            cards.Add(new Card("6", Suit.Clubs));
            cards.Add(new Card("6", Suit.Diamonds));
            cards.Add(new Card("6", Suit.Hearts));
            cards.Add(new Card("6", Suit.Spades));
            cards.Add(new Card("7", Suit.Clubs));
            cards.Add(new Card("7", Suit.Diamonds));
            cards.Add(new Card("7", Suit.Hearts));
            cards.Add(new Card("7", Suit.Spades));
            cards.Add(new Card("8", Suit.Clubs));
            cards.Add(new Card("8", Suit.Diamonds));
            cards.Add(new Card("8", Suit.Hearts));
            cards.Add(new Card("8", Suit.Spades));
            cards.Add(new Card("9", Suit.Clubs));
            cards.Add(new Card("9", Suit.Diamonds));
            cards.Add(new Card("9", Suit.Hearts));
            cards.Add(new Card("9", Suit.Spades));
            cards.Add(new Card("10", Suit.Clubs));
            cards.Add(new Card("10", Suit.Diamonds));
            cards.Add(new Card("10", Suit.Hearts));
            cards.Add(new Card("10", Suit.Spades));
            cards.Add(new Card("jack", Suit.Clubs));
            cards.Add(new Card("jack", Suit.Diamonds));
            cards.Add(new Card("jack", Suit.Hearts));
            cards.Add(new Card("jack", Suit.Spades));
            cards.Add(new Card("qeen", Suit.Clubs));
            cards.Add(new Card("qeen", Suit.Diamonds));
            cards.Add(new Card("qeen", Suit.Hearts));
            cards.Add(new Card("qeen", Suit.Spades));
            cards.Add(new Card("king", Suit.Clubs));
            cards.Add(new Card("king", Suit.Diamonds));
            cards.Add(new Card("king", Suit.Hearts));
            cards.Add(new Card("king", Suit.Spades));
            cards.Add(new Card("ace", Suit.Clubs));
            cards.Add(new Card("ace", Suit.Diamonds));
            cards.Add(new Card("ace", Suit.Hearts));
            cards.Add(new Card("ace", Suit.Spades));
        }



        public void ShuffleCards()
        {
            Random rng = new Random();
            int n = cards.Count;

            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);


                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }



        public void PrintOnConsole()
        {
            foreach (Card item in cards)
            {
                Console.Write(item);
            }
        }
    }
}
