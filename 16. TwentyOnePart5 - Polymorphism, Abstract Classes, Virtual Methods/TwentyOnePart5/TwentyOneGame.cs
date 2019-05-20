using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart5
{
    public class TwentyOneGame : Game //this means TwentyOneGame class is going to inherit from Game class
    {
        public override void Play() //Had to add override here because this is an abstract class. 
        {
            throw new NotImplementedException();//throws in a catch to not call a method until we actually define it, which I'm assuming we will later. 
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 players:");
            base.ListPlayers(); //This was automatically put in when I entered the virtual class in
        }
    }
}
