using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOnePart6
{
    public class Player
    {
        public List<Card> Hand { get; set; }
        public int Balance { get; set; } //This is money so should probably be double, but keeping it simple
        public string Name { get; set; }
        public bool IsActivelyPlaying { get; set; }
    }
}
