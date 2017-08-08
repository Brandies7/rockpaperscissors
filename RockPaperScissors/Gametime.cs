using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Gametime
    {
        public Human playerOne;
        public Human playerTwo;
        public ComputerAI playerAI;
        public int score;
        public Gametime()
        {

        }
        public void ExplainRules()
        {
            Console.WriteLine("Welcome Players To The R.P.S.L.S. Game! Before we begin, lets go over the rules." + Environment.NewLine +
                               "Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Spock smashes Scissors, Scissors decapitates Lizard" + Environment.NewLine +
                               "Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock, and as always, Rock crushes Scissors." + Environment.NewLine +
                               "Best out of 3 Wins. Choose Wisely and Live Long and Prosper! Press Any Key To Play");
            Console.ReadLine();
        }
        public void GetPlayers()
        {
            playerOne = new Human();
            Console.WriteLine("To Play Against Another Player Select (1) or To Play Against The Computer Select (2)?");
            string response = Console.ReadLine();
            switch (response)
            {
                case "1":
                    playerTwo = new Human();
                    break;
                case "2":
                    playerAI = new ComputerAI();
                    break;
                default:
                    Console.WriteLine("Invalid response.");
                    GetPlayers();
                    break;
            }
        }
        public void DetermineScore(Human playerOne, Human playerTwo, ComputerAI playerAI)
        {
            if (playerOne.hand == "1" && playerTwo.hand == "3" || playerTwo.hand == "4" || playerAI.hand == "3" || playerAI.hand == "4")
            {
                playerOne.score++;
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == "2" && playerTwo.hand == "1" || playerTwo.hand == "5" || playerAI.hand == "1" || playerAI.hand == "5")
            {
                playerOne.score++;
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == "3" && playerTwo.hand == "2" || playerTwo.hand == "4" || playerAI.hand == "2" || playerAI.hand == "4")
            {
                playerOne.score++;
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == "4" && playerTwo.hand == "2" || playerTwo.hand == "5" || playerAI.hand == "2" || playerAI.hand == "5")
            {
                playerOne.score++;
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == "5" && playerTwo.hand == "1" || playerTwo.hand == "3" || playerAI.hand == "3" || playerAI.hand == "1")
            {
                playerOne.score++;
                Console.WriteLine("Congratulations " + playerOne.name + ", You Win This Round!");
                Console.ReadLine();
            }
            else if (playerOne.hand == playerTwo.hand)
            {
                Console.WriteLine("You Tied, Try Again");
                Console.ReadLine();
                DetermineScore(playerOne, playerTwo, playerAI);
            }
            else
            {
                playerTwo.score++;
                Console.WriteLine("Congratulations " + playerTwo.name + ", You Win This Round!");
                Console.ReadLine();
                CheckForWinner(playerOne, playerTwo, playerAI);
            }
        }

        public void CheckForWinner(Human playerOne, Human playerTwo, ComputerAI playerAI)
        {
            if (playerOne.score == 2)
            {
                Console.WriteLine(playerOne.name + " You Won!");
            }
            else if (playerTwo.score == 2)
            {
                Console.WriteLine(playerTwo.name + " You Won!");
            }
            else if (playerAI.score == 2)
            {
                Console.WriteLine(playerAI.name + "You Won!");
            }
        }

        public void PlayGame()
        {
            ExplainRules();
            GetPlayers();

            while (playerOne.score < 2 && playerTwo.score < 2 || playerAI.score < 2)
            {
                playerOne.GetHand();
                playerTwo.GetHand();
                playerAI.CompMove();
                DetermineScore(playerOne, playerTwo, playerAI);
            }

            Console.WriteLine("Game over, please play again!");
        }
    }
}
            
        
    