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
        int counter1= 0;
        int counter2= 0;
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




        

        public void CompareGesture(int player1Gesture, int player2Gesture)
        {
           
                if (player1Gesture == player2Gesture)
                {
                    Console.WriteLine("This round is a Tie!");
                    
                }
                else if (player1Gesture == 0 && (player2Gesture == 2 || player2Gesture == 3))
                {
                    Console.WriteLine("Player 1 Wins the Round!");
                    counter1++;
                }
                else if (player1Gesture == 2 && (player2Gesture == 1 || player2Gesture == 3))
                {
                    Console.WriteLine("Player 1 Wins the Round!");
                    counter1++;
                }
                else if (player1Gesture == 1 && (player2Gesture == 0 || player2Gesture == 4))
                {
                    Console.WriteLine("Player 1 Wins the Round!");
                    counter1++;
                }
                else if (player1Gesture == 3 && (player2Gesture == 4 || player2Gesture == 1))
                {
                    Console.WriteLine("Player 1 Wins the Round!");
                    counter1++;
                }
                else if (player1Gesture == 4 && (player2Gesture == 2 || player2Gesture == 0))
                {
                    Console.WriteLine("Player 1 Wins the Round!");
                    counter1++;
                }
                else
                {
                    Console.WriteLine("Player 2 Wins the Round!");
                    counter2++;
                }
            
        }  
        public void DisplayWinner()
        {
            if (counter1 >= 2)
            {
                Console.WriteLine("Player 1 Wins the Game!");
            }
            if(counter2 >= 2)
            {
                Console.WriteLine("Player 2 Wins the Game!");
            }
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
            Console.WriteLine("Choose Gesture");

            while (counter1 < 2 && counter2 < 2)
            {
                CompareGesture(player1.ChooseGesture(), player2.ChooseGesture());
            }
            
            DisplayWinner();
    
            Console.ReadLine();
        }
        
    }
}
