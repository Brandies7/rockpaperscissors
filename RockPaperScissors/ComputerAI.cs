using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class ComputerAI
    {
        public string name;
        public int move;
        Random random = new Random();
        public string computerplayer;
        public ComputerAI()
        {


        }

        public void CompMove()
        {
            Console.WriteLine("Make Your Move! Choose Wisely!" + Environment.NewLine +
                "Select '1' for Rock" + Environment.NewLine +
                "Select '2' for Paper" + Environment.NewLine +
                "Select '3' for Scissors" + Environment.NewLine +
                "select '4' for Lizard" + Environment.NewLine +
                "Select '5' for Spock");
            move = random.Next(move);
            Console.WriteLine("You Chose " + move + ".");
        }

        public void GetComputerName()
        {
            Console.WriteLine("Hello My name is Robert. Goodluck!");
            name = Console.ReadLine();
        }


    }
}
