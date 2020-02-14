using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
   public class Ai : Player
    {
        public override int ChooseGesture()
        {
            Random random = new Random();
            int AiChoice = random.Next(0, 4);
            return AiChoice;
        }
    }
}
