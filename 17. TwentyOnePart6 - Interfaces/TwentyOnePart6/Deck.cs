using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart6
{
    public class Deck
    {
        public Deck()
        {
            Cards = new List<Card>();
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

        public void Shuffle(int times = 1)
        {
            for (int i = 0; i < times; i++)
            {
                List<Card> TempList = new List<Card>();//This is creating a new temporary list to store shuffled cards in
                Random random = new Random();

                while (Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, Cards.Count);//This will get a random number between 0 and 52(deck.Cards.Count = 52)
                    TempList.Add(Cards[randomIndex]);//This stores the random number in the TempList
                    Cards.RemoveAt(randomIndex);//This deletes the random index from the list of cards, and this loop will do that til there are no cards left
                }
                Cards = TempList;
            }
        }
    }
}
