using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart2
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            //deck = Shuffle(deck, 3);//This will shuffle the deck 3 times and give result after 3rd time. This goes with the code on the very bottom. 
            //deck = Shuffle(deck: deck, times: 3); //Another way to do the same thing as Shuffle above.  Just added a named paramater 
            //to make the code easier to read/understand. Goes with the code immediately below the foreach loop.
            int timesShuffled = 0;//This line and following line call the Shuffle method with the out parameter. 
            deck = Shuffle(deck, out timesShuffled, 3);

            foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled: {0}", timesShuffled);
            //Console.WriteLine("Times shuffled: {0} {1}", timesShuffled, deck); //Just showing another way to do the line above with multiple variables.
            //The 0 goes with timesShuffled variable, and the 1 goes with deck variable.  I'm not sure if this would work as I don't think you can get a 
            //quantity for deck, but I just wanted an example for future reference. 
            Console.ReadLine();
        }

        //public static Deck Shuffle(Deck deck, int times = 1)//Added the int times = 1, by adding this default value it makes the parameter optional

        //{
        //    for (int i = 0; i < times; i++)//Added this for loop to adjust this so you can Shuffle multiple times.  Like the Shuffle below (2nd one down),
        //        //but just another way to do a Shuffle more than one time. 
        //    {
        //        List<Card> TempList = new List<Card>();//This is creating a new temporary list to store shuffled cards in
        //        Random random = new Random();

        //        while (deck.Cards.Count > 0)
        //        {
        //            int randomIndex = random.Next(0, deck.Cards.Count);//This will get a random number between 0 and 52(deck.Cards.Count = 52)
        //            TempList.Add(deck.Cards[randomIndex]);//This stores the random number in the TempList
        //            deck.Cards.RemoveAt(randomIndex);//This deletes the random index from the list of cards, and this loop will do that til there are no cards left
        //        }
        //        deck.Cards = TempList;
        //    }

        //    return deck;

        //}

        public static Deck Shuffle(Deck deck, out int timesShuffled, int times = 1)//Going to use an out parameter to verify how many 
            //times deck was shuffled. Out parameter has to go before other optional parameters. 
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++;
                List<Card> TempList = new List<Card>();//This is creating a new temporary list to store shuffled cards in
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);//This will get a random number between 0 and 52(deck.Cards.Count = 52)
                    TempList.Add(deck.Cards[randomIndex]);//This stores the random number in the TempList
                    deck.Cards.RemoveAt(randomIndex);//This deletes the random index from the list of cards, and this loop will do that til there are no cards left
                }
                deck.Cards = TempList;
            }

            return deck;

            //public static Deck Shuffle(Deck deck, int times)//Creating a second method to shuffle the deck in case someone wants to shuffle
            //    //the deck multiple times. 
            //{
            //    for (int i = 0; i < times; i++)
            //    {
            //        deck = Shuffle(deck);
            //    }
            //    return deck;
            //}
        }
    }
}
