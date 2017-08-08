using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Human 
    {
        public string hand;
        public string name;
        public string move;
        public int score;
       
        
        public Human()
        {
            Console.WriteLine("Please enter name.");
            name = Console.ReadLine();

        }
        public void GetHand()
        {
            Console.WriteLine("Make Your Move! Choose Wisely!" + Environment.NewLine +
                "Select '1' for Rock" + Environment.NewLine +
                "Select '2' for Paper" + Environment.NewLine +
                "Select '3' for Scissors" + Environment.NewLine +
                "select '4' for Lizard" + Environment.NewLine +
                "Select '5' for Spock");
            hand = Console.ReadLine();

            //string  myMove = new move();
            //Console.WriteLine("You chose " + move + ".");
            //move = Console.ReadLine();
        }

    }
}

