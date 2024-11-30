using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Mediator
{
    public class AirCondition : Component
    {
        public void TurnOn()
        {
            Console.WriteLine("Air Condition Working..");
        }
        public void TurnOff()
        {
            Console.WriteLine("Air Conditioning temprature Reducing..");
        }
    }
}
