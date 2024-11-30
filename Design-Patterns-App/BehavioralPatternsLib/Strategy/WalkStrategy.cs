using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Strategy
{
    public class WalkStrategy : ITransportStrategy
    {
        public void Travel(string start, string end)
        {
            Console.WriteLine($"2 hour walking journey from {start} to {end} ");
        }
    }
}
