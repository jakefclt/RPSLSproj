using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
   abstract public class Player
    {
        //member variable
        public string name;
        public string score;
        public List<Gesture>gestureList;

        //constructor
        public Player()
        {
            gestureList = new List<Gesture>() { new Gesture("0: Rock"), new Gesture("1: Paper"), new Gesture("2: Scissors"), new Gesture("3: Lizard"), new Gesture("4: Spock")};  
            
        }



        //member method
        public abstract string ChooseGesture();
        

        
        
      
        
        
    }
    
    
}
