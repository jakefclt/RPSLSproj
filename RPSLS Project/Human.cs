using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
   public class Human : Player 
    {
        public override string ChooseGesture()
        {
            
            for (int i = 0; i < gestureList.Count; i++)
            {               
                Console.WriteLine(gestureList[i].name);                               
                             
            }
            string result = Console.ReadLine();
            return result;
            

        }
        

    }
}
