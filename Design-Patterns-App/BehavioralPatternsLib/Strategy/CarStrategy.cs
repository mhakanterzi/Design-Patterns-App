using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Strategy
{
    public class CarStrategy : ITransportStrategy
    {
        public void Travel(string start, string end)
        {
            Console.WriteLine($"15 minutes traveling {start} to {end} with car ");
        }
    }
}
