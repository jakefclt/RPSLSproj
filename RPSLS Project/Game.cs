using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    public class Game
    {
        //member variable
        public Player player1;
        public Player player2;
        //constructor
        public Game()
        {

        }

        //member method
        public void DisplayRules()
        {
            Console.WriteLine("Game Rules: " +
                               "\n *Rock crushes Scissors " +
                               "\n *Scissors cuts Paper " +
                               "\n *Paper covers Rock " +
                               "\n *Rock crushes Lizard " +
                               "\n *Lizard poisons Spock " +
                               "\n *Spock smashes Scissors" +
                               "\n *Scissors decapitates Lizard" +
                               "\n *Lizard eats Paper" +
                               "\n *Paper disproves Spock" +
                               "\n *Spock vaporizes Rock");
        }
        public string ChooseGameMode()
        {
            Console.WriteLine("Choose Game Mode" + "\n 1. Single Player" + "\n 2. Two Player");
            string numberPlayers = Console.ReadLine();
            return numberPlayers;
        }

        public void SetGameMode(string numberPlayers)
        {
            if(numberPlayers == "1")
            {
                player1 = new Human();
                player2 = new Ai();
            }
            else if (numberPlayers == "2")
            {
                player1 = new Human();
                player2 = new Human();
            }
        }

       


        
        
        public void CompareGesture()
        {

        }
        public void DisplayRoundWinner()
        {
            // displays winner after each round
        }
        public void DisplayGameWinner()
        {
            //displays winner after best out of 2/3: the overall game winner
        }
        public void RunGame()
        {
            DisplayRules();

            Console.WriteLine("Press Enter to Continue");
            Console.ReadLine();
            string players = ChooseGameMode();
            SetGameMode(players);
            Console.WriteLine("Press Enter to Start Game");
            Console.ReadLine();
            player1.ChooseGesture();
            player2.ChooseGesture();
            
        }
    }
}
