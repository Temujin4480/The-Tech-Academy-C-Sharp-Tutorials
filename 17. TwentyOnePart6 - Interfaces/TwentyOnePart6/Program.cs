using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart6
{
    class Program
    {
        static void Main(string[] args)
        {
            //Topic of this tutorial is interfaces.  Interfaces are similar to abstract classes in that there are no 
            //implementation details in an interface. Use b/c dotnet framework does not support multiple inheritances. (Refer to 
            //TwentyOneGame.cs for example of this)


            


            

            TwentyOneGame game = new TwentyOneGame();
            game.Players = new List<string>() { "Jesse", "Bill", "Bob" };
            game.ListPlayers();
            Console.ReadLine();

            //Deck deck = new Deck();
            //deck.Shuffle(3);

            //foreach (Card card in deck.Cards)
            //{
            //    Console.WriteLine(card.Face + " of " + card.Suit);
            //}
            //Console.WriteLine(deck.Cards.Count);
            //Console.ReadLine();
        }
    }
}
