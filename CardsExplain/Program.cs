using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardsExplain
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();

            deck.PrintOnConsole();


            deck.ShuffleCards();

            Console.WriteLine();
            deck.PrintOnConsole();

            Console.Read();
        }
    }
}
