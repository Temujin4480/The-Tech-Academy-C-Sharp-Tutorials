using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart6
{
    public class TwentyOneGame : Game, IWalkAway //Can only inherit from one class.  So, if we also try to write TwentyOneGame : Dealer, we'll
        //get an error message.  Cannot inherit from multiple classes, but we can do a class and an interface as we have here. 
    {
        public override void Play() //Had to add override here because this is an abstract class. 
        {
            throw new NotImplementedException();//throws in a catch to not call a method until we actually define it, which I'm assuming we will later. 
        }

        public override void ListPlayers()
        {
            Console.WriteLine("21 players:");//We added this in after the line below automatically appeared. 
            base.ListPlayers(); //This was automatically put in when I entered the virtual class in
        }

        public void WalkAway(Player player)
        {
            throw new NotImplementedException();//we'll add this in later as with Play above
        }
    }
}
