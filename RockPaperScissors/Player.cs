using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public abstract class Player
    {
        public string name;
        public int score;
        public string hand;
        public Player()
        {

        }
        public virtual string GetHand()
        {
            Console.WriteLine("Make Your Move! Choose Wisely!" + Environment.NewLine +
                "Select '1' for Rock" + Environment.NewLine +
                "Select '2' for Paper" + Environment.NewLine +
                "Select '3' for Scissors" + Environment.NewLine +
                "select '4' for Lizard" + Environment.NewLine +
                "Select '5' for Spock");
            hand = Console.ReadLine();
            Console.WriteLine("You chose " + hand + ".");
            return hand;
        }
    }
}
            
 



 
