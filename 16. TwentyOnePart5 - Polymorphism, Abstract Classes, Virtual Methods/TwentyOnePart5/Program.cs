using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart5
{
    class Program
    {
        static void Main(string[] args)
        {
            //The second pillar of object oriented is polymorphism, which is what we're going to talk about in 
            // this tutorial.  I believe inheritance is the first pillar.

            //Game game = new TwentyOneGame(); //this is polymorphism.  One object, TwentyOneGame, has morphed into a higher order 
            //object, Game.  Game is higher order, because TwentyOneGame inherits from it, and the inheritance is why it can morph into it. 
            //Polymorphism allows a class to morph into a class it inherits from (aka, the superclass) and it gives certain advantages.

            //Why do it that way instead of TwentyOneGame game = new TwentyOneGame(); ? 
            //One advantage is that it allows you to make a list, in this case a list of games, even though the list encompasses things of different data types. 
            //Example: 
            //List<Game> games = new List<Game>();
            //Game game = new TwentyOneGame(); or can use TwentyOneGame game = new TwentyOneGame();
            //games.Add(game);
            //Then you'd add games to encompass all the games such as poker, solitaire, etc. 


            //That was a quick bit on polymorphism.  Now we're just going to do more work/house cleaning on our TwentyOne game un polymorphism related 


            //Game game = new Game();  //Can no longer do instantiate Game as it's now an abstract class

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
