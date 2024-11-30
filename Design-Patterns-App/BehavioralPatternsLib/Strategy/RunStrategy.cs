using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Strategy
{
    public class RunStrategy
    {
        public void Run()
        {
            Navigate navigator = new Navigate(new CarStrategy());

            Console.WriteLine("Scenario 1: Traveling by car");
            navigator.Route("Güneysu", "Rize");

            Console.WriteLine();

            Console.WriteLine("Scenario 2: Traveling by bus");
            navigator.SetStrategy(new BusStrategy());
            navigator.Route("Güneysu", "Rize");

            Console.WriteLine();

            Console.WriteLine("Scenario 3: Traveling on foot");
            navigator.SetStrategy(new WalkStrategy());
            navigator.Route("Güneysu", "Rize");
        }
    }
}
