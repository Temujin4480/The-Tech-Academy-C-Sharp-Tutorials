using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart6
{
    public class Dealer //Classes, which turn into objects in the main program try to mimic the real world.  They have properties and they do things
    {
        //Properties:
        public string Name { get; set; }
        public Deck Deck { get; set; }
        public int Balance { get; set; }

        //Methods:
        public void Deal(List<Card> Hand)
        {
            Hand.Add(Deck.Cards.First()); //First is a method available to a list which takes the first item in that list.  Here we take 
            //the first card and add it into the Hand to be dealt. 
            Console.WriteLine(Deck.Cards.First().ToString() + "\n"); //Print the first card to the console for the user to see
            Deck.Cards.RemoveAt(0); //First item on the list is being removed

            //Why didn't we just inherit from the Deck class for the deck in here?  It's because inherit works for things that are, not for 
            //things that it has.  A dealer has a deck, the dealer isn't a deck, so it doesn't work to inherit.  TwentyOne is a game, so it 
            //works to inherit from Game.  If it 'is' inherit.  If it 'has', include it as a property as we have in this class. 
            //"Composition over inheritance" - Martin Fowler. Means it's better to error on the side of adding things as a property of 
            //a class rather than inheriting.  If you're not sure if it's a 'is a' or 'has a' go with property.  

        }
    }
}
