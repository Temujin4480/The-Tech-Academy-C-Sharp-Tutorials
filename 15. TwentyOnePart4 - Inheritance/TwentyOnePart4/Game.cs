using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart4
{
    public class Game //More generic the code the better, makes it easier to add features later.  So calling this Game instead of 
        //TwentyOneGame is better.  
    {
        //public int MyProperty { get; set; } //Typed prop then hit tab twice to get this to come up.  Then he altered it to look like the next line
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public void ListPlayers() //void because it doesn't return anything, just printing to the console
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }
    }
}
