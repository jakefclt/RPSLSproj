using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            Game runGame = new Game();
            runGame.RunGame();
            Console.ReadLine();
            
        }
    }
}
