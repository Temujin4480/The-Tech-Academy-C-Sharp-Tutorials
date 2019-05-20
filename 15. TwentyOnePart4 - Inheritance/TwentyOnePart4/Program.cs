using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Card card = new Card() { Face = "King", Suit = "Spades" }; //Another way to initialize an object(s) of a class


            //Main point of this tutorial is to demonstrate INHERITANCE (emphasis mine). This is a big part of object oriented programming. 
            //Inheritance is the ability for a class to inherit other properties and methods from another class. 
            //DRY - don't repeat yourself is a motto of coding, and inheritance is an important way to do that. 

            //Game game = new Game();
            //game.Dealer = "Ben";
            //game.Name = "TwentyOne";//Could add all this information (name, dealer, etc.) here in the main method, but would get crowded quickly. So we're going to 
            ////create a new class TwentyOne game and then do the following stuff

            TwentyOneGame game = new TwentyOneGame();//because TwentyOneGame inherited from game, it has access to all the same properties and methods. 
            //i.e. Players, Name, Dealer, ListPlayers 
            game.Players = new List<string>() { "Jesse", "Bill", "Joe" };
            game.ListPlayers();
            Console.ReadLine();
            //When you call a method from a class you're inheriting from you're calling the superclass method.  Game in this example is the superclass
            game.Play();//This will trigger the catch in the TwentyOneGame class

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
