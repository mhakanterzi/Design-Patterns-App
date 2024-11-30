using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Mediator
{
    public class Camera : Component
    {
        public void TurnOn()
        {
            Console.WriteLine("Security Camera Activeted..");
        }
        public void TurnOff()
        {
            Console.WriteLine("Security Camera Turned Off..");
        }
    }
}
