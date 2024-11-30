using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Mediator
{
    public class Home : Component
    {
        public void EnterHome()
        {
            Console.WriteLine("User: Entering home...");
            _mediator.Notify(this, "entered home");
        }

        public void LeaveHome()
        {
            Console.WriteLine("User: Leaving home...");
            _mediator.Notify(this, "left home");
        }
    }
}
