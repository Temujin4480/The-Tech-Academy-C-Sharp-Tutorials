using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart6
{
    interface IWalkAway //interface naming conventions usually start with an I, hence IWalkAway, not WalkAway
    {
        //Add interface the same way as adding a class.  Right click the project, click add, click class, but then click interface. 
        //This interface is to exemplify if there were a regulation where players would have to be given option of being able to walk away 
        //from a game with their money, and we have to support this in our code. This would only be for gambling games, so a game like 
        //solitaire wouldn't need the walkaway option.  Therefore we don't want to apply this to all the games in the class games, so we 
        //need a new interface as we don't want all the games affected by an abstract class. dotnet supports multiple inheritance of interfaces.

        void WalkAway(Player player); //everything is public in an interface, so we don't need to include public before void. 

        //Most likely won't be writing many of my own interfaces for awhile until I'm constructing my own apps (which usually comes after 
        //a fair amount of experience), but will probably be using lots of built in ones.  
    }
}
