using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Player
    {

        
        public string name;
        public int move;
        public int score;
        Random random;

      
        public Player()
        {
            Console.WriteLine("Please enter .");
            name = Console.ReadLine();
        }

        
        //public void GetMove(Gesture gesture)
        //{
           // move = random.Next(1, Move.numOfSides + 1);
            //Console.WriteLine("You rolled a " + move + ".");
        //}

    }
}