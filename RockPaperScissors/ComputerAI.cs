using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class ComputerAI : Player
    {

        Random random;
        public ComputerAI()
        {
            name = "AIRobot";
        }
        public override string GetHand()
        {
            Random random = new Random();
            int hand = random.Next(1, 5);
            return hand.ToString();
        }
    }
}

        





  
