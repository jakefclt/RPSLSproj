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
        public string singlePlayerMode;
        public string twoPlayerMode;
        //constructor
        public Game()
        {

        }

        //member method
        public void ChooseGameMode()
        {
            //single player or two player
        }
        public void DisplayGestureOptions()
        {
            //player 1 chooses gesture
            //player two chooses gesture
            //or AI chooses random gesture

        }
        public void AssignPlayerGesture()
        {
            //displays players gesture choice
        }
        public void DisplayRoundWinner()
        {
            // displays winner after each round
        }
        public void DisplayGameWinner()
        {
            //displays winner after best out of 2/3: the overall game winner
        }
    }
}
