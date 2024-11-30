using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Strategy
{
    public class Navigate
    {
        private ITransportStrategy _transportStrategy;

        public Navigate(ITransportStrategy transportStrategy)
        {
            _transportStrategy = transportStrategy;
        }

        public void SetStrategy(ITransportStrategy strategy)
        {
            _transportStrategy = strategy;
        }

        public void Route(string start, string end)
        {
            Console.WriteLine("Planning route...");
            _transportStrategy.Travel(start, end);
        }
    }
}
