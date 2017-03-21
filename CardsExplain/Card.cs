using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsExplain
{
    public class Card : Object
    {
        public string Name;
        public Suit Suit;

        public Card(string name, Suit suit)
        {
            this.Name = name;
            this.Suit = suit;
        }

        public override string ToString()
        {
            return $"[{Name} {Suit}]";
        }
    }
}
