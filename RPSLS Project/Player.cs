using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS_Project
{
   public class Player
    {
        //member variable
        public string name;
        public List<Gesture> gesture;

        //constructor
        public Player(string name)
        {
            this.name = name;
            gesture = new List<Gesture>() { new Gesture ("Rock"), new Gesture ("Paper"), new Gesture("Scissors"), new Gesture("Lizard"), new Gesture ("Spock") };
        }
        

        //member method
        public void ChooseGesture()
        {

        }

        public void RandomGesture()
        {

        }
    }
    
    
}
