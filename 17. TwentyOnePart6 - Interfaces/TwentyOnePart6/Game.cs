using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart6
{
    //Next topic is Abstract Classes - a class marked as abstract can never be instantiated.  It can't be an object, it's only meant to 
    //be inherited from.  We'll never have an instance of Game, it's always going to be a specific game - 21, poker.  This makes Game
    //a great example of a base class - another name for abstract class. 

    public abstract class Game //Added abstract here for part5
    {
        public List<string> Players { get; set; }
        public string Name { get; set; }
        public string Dealer { get; set; }

        public abstract void Play(); //Creating an abstract method. As Play will be different for each game, it doesn't make sense to define it 
            //for every game within this class.  Abstract methods can only exist within an abstract class and contains NO implementation. 
            //All it does is make it so any class inheriting from the Game class MUST implement a Play method.  

        public virtual void ListPlayers() //virtual methods can only exist within abstract classes. Virtual methods mean this method will get 
            //inherited by an inheriting class, but it has the ability to override it.  Virtual methods have implementation, but they can be overridden
            //or added to.  See TwentyOneGame class for what we added to this. 
        {
            foreach (string player in Players)
            {
                Console.WriteLine(player);
            }
        }

    }
}
