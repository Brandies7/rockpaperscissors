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
        //public Move == new move;
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
                               "When Prompted To Do So:" + Environment.NewLine +
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



        public void DetermineScore()
        {
            if (playerOne.hand == "1" && playerTwo.hand == "3" || playerTwo.hand == "4")
            {
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == "2" && playerTwo.hand == "1" || playerTwo.hand == "5")
            {
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == "3" && playerTwo.hand == "2" || playerTwo.hand == "4")
            {
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == "4" && playerTwo.hand == "2" || playerTwo.hand == "5")
            {
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == "5" && playerTwo.hand == "1" || playerTwo.hand == "3")
            {
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == playerTwo.hand)
            {
                Console.WriteLine("You Tied, Try Again");
                Console.ReadLine();
                DetermineScore();
            }
            else
            {
                Console.WriteLine("Congratulations " + playerTwo.name + ", You Win This Round!");
                Console.ReadLine();
            }
        }
    }
}
