using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart4
{
    public class Card //We added a public here to make this accessible
    {
        public Card()
        {
            Suit = "Spades";
            Face = "Two";
        }

        public string Suit { get; set; }

        public string Face { get; set; }
    }
}
