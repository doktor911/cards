using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cards
{
    class random
    {
        public void shuffleArray()

        {
 string[] cards = {  "6 clubs", "6 diamonds", "6 hearts", "6 spades",
                     "7 clubs", "7 diamonds", "7 hearts", "7 spades",
                            "8 clubs", "8 diamonds", "8 hearts", "8 spades",
                            "9 clubs", "9 diamonds", "9 hearts", "9 spades",
                            "10 clubs", "10 diamonds", "10 hearts", "10 spades",
                            "jack  clubs", "jack diamonds", "jack hearts", "jack spades",
                            "Queen clubs", "Queen diamonds",  "Queen hearts", "Queen spades",
                            "king clubs", "king diamonds", "king hearts", "king spades",
                            "ace clubs", "ace diamonds", "ace hearts", "ace spades"};


            


            for (int i = 0; i < 35; i++) 
            {
                Random rnd = new Random();
                int m = rnd.Next(cards.Length);
                Console.WriteLine("  cards:     {0}", cards[m]);

            }
            Console.ReadLine();
        }
    }
}
