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
            Player playerone = new Player();
            gametime.Rules();
            //playerone.GetPlayerOne();
            gametime.GetPlayers();
        }
    }
}
