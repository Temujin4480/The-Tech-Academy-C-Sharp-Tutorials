using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart3
{
    class Program
    {
        static void Main(string[] args)
        {
            //In part 3 we're going to move the shuffle method into the class deck which makes the code much more stream lined
            Deck deck = new Deck();
            deck.Shuffle(3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }
    }
}
