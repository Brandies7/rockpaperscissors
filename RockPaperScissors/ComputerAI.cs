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
       
        List<string> compmove = new List<string> { "1", "2", "3", "4", "5" };
        public string hand;
        Random random = new Random();
        public int score;
        
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
            hand=compmove[random.Next(0,compmove.Count)];
            Console.WriteLine("You Chose " + hand + ".");
        }

        public void GetComputerName()
        {
            Console.WriteLine("Hello My name is Robert. Goodluck!");
            name = Console.ReadLine();
        }


    }
}
