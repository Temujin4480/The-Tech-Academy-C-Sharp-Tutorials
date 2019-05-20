using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Deck
    {
        public Deck() //This is a constructor. constructors always go on top of the class, before the properties. 
        {
            ////Long way to populate the deck, do this for all 52 cards in the deck:
            //Cards = new List<Card>();
            //Card cardOne = new Card();
            //cardOne.Face = "Two";
            //cardOne.Suit = "Hearts";
            //Cards.Add(cardOne);

            //Easier way is with a nested foreach loop: 
            Cards = new List<Card>(); //Cards is already a property of the class Deck (see below this constructor)
            List<string> Suits = new List<string>() { "Clubs", "Hearts", "Diamonds", "Spades" };
            List<string> Faces = new List<string>()
            {
                "Two", "Three", "Four", "Five", "Six", "Seven", "Eight",
                "Nine", "Ten", "Jack", "Queen", "King", "Ace"
            };

            foreach (string face in Faces)
            {
                foreach (string suit in Suits)
                {
                    Card card = new Card(); //once you go through the loop this variable card non longer exists, which is why you can create the variable again below. 
                    card.Suit = suit;
                    card.Face = face;
                    Cards.Add(card);
                }
            }
         
        }
        public List<Card> Cards { get; set; }
    }
}
