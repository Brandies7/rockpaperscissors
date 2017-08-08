using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Gametime gametime = new Gametime();
            gametime.PlayGame();
            Console.ReadLine();
            
           
        }
    }
}
