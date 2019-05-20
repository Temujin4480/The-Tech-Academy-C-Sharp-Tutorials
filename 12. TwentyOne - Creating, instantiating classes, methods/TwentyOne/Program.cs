using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            //Deck deck = new Deck();

            //deck.Cards = new List<Card>();

            //Card cardOne = new Card(); //object of data type card, assigned to the variable cardOne
            //cardOne.Face = "Queen"; //We've assigned the string queen to the property face of the object cardOne
            //cardOne.Suit = "Spades";

            ////deck.Cards.Add(cardOne); //Instead of using all the above commented out code, we're going to use constructors to fill out the deck. 

            //Console.WriteLine(cardOne.Face + " of " + cardOne.Suit); 
            //Console.ReadLine();

            ////The following is an example of how to show the deck from the initial commented out constructor in Deck.cs
            //Deck deck = new Deck();
            //Console.WriteLine(deck.Cards[0].Face + " of " + deck.Cards[0].Suit);
            //Console.ReadLine();

            Deck deck = new Deck();
            deck = Shuffle(deck);//This calls the method Shuffle below

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.ReadLine();
        }

            public static Deck Shuffle(Deck deck)//This is a method or a function.  public so that it's accesible everywhere. static because
            //we don't want to create an object program before calling this.  Static members are not accessible by the object, 
            //they're only accessible by the class.  Deck is the type of data it's returning.
            //Shuffle is the name of the function. Takes the paramater of Deck and we're giving it the variable deck when we want 
            //to refer to it below. 
{
            List<Card> TempList = new List<Card>();//This is creating a new temporary list to store shuffled cards in
            Random random = new Random();

            while (deck.Cards.Count > 0)
            {
                int randomIndex = random.Next(0, deck.Cards.Count);//This will get a random number between 0 and 52(deck.Cards.Count = 52)
                TempList.Add(deck.Cards[randomIndex]);//This stores the random number in the TempList
                deck.Cards.RemoveAt(randomIndex);//This deletes the random index from the list of cards, and this loop will do that til there are no cards left
            }
            deck.Cards = TempList;
            return deck;
           
        }
    }
}
