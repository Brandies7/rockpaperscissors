using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {

        public string hand;
        public string name;
        public int move;
        public int score;
        public Player()
        {
            Console.WriteLine("Please enter name.");
            name = Console.ReadLine();
            
        }

        
        public void GetMove(hand gesture)
        {
            string move = move.hand();
            Console.WriteLine("You chose " + move + ".");
        }

    }
}