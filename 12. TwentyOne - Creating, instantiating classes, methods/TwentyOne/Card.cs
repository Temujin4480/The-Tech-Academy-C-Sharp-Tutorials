using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class Card //We added a public here to make this accessible
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }//This is called a constructor.  If we don't assign values later (in the program page we assigned queen of spades) this will 
        //be the default value.  Constructors are ways to assign values to a class immediately upon creation. 

        public string Suit { get; set; } //public by making this property public it is accessible to other parts of the program; 
        //string data type; Suit is the name of the property; get and set are the only two things you can do with an object property
        public string Face { get; set; } //A second property for the value of the card
    }
}
