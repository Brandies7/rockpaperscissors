using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Gametime
    {
        public Player playerOne;
        public Player playerTwo;
        public Move = new move;
        public int score;
        public Gametime()
        {

        }

        public string GetRules;
        

        public void Rules()
        {
            Console.WriteLine("Welcome Players To The R.P.S.L.S. Game! Before we begin, lets go over the rules." + Environment.NewLine +
                               "Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Spock smashes Scissors, Scissors decapitates Lizard" + Environment.NewLine +
                               "Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and as always, Rock crushes Scissors." + Environment.NewLine +
                               "Choose '1' for Rock." + Environment.NewLine +
                               "Choose '2' for Paper." + Environment.NewLine +
                               "Choose '3' for Scissors." + Environment.NewLine +
                               "Choose '4' for Lizard." + Environment.NewLine +
                               "Choose '5' for Spock." + Environment.NewLine +
                               "Best out of 3 Wins. Choose Wisely and Live Long and Prosper!");

           
            GetRules = Console.ReadLine();
            

        }

        
        public void GetPlayers()
        {
            playerOne = new Human();
            Console.WriteLine("Are you playing against another human (1) or the computer (2)?");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    playerTwo = new Human();
                    break;
                case "2":
                    playerTwo = new ComputerAI();
                    break;
                default:
                    Console.WriteLine("Invalid response.");
                    GetPlayers();
                    break;
            }
        }
        //Scissors cuts Paper
        //Paper covers Rock
        //Rock crushes Lizard
        //Lizard poisons Spock
        //Spock smashes Scissors
        //Scissors decapitates Lizard
        //Lizard eats Paper
        //Paper disproves Spock
        //Spock vaporizes Rock
        //(and as it always has) Rock crushes Scissors
        //1=rock
        //2=Paper
        //3=scissors
        //4=Lizard
        //5=Spock

        //public void RoundOne()
        //{
        ///Console.WriteLine("Player One's Turn");
        //string playerone = Console.ReadLine();
        //switch (playerone)
        //{
        // case "1":

        // default:
    }

        }


    //}
//}
