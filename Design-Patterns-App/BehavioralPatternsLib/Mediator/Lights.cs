using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Mediator
{
    public class Lights : Component
    {
        public void TurnOn()
        {
            Console.WriteLine("Lights Turning On..");
        }
        public void TurnOff()
        {
            Console.WriteLine("Lights Turning Off..");
        }
    }
}
