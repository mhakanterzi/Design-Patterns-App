using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Visitor
{
    public class RunVisitor
    {
        public void Run()
        {
            List<IWander> clean = new List<IWander>()
            {
                new LivingRoom(),
                new Corridor(),
                new Rooms()
            };

            ICleanVisitor dusting = new DustingVisitor();
            ICleanVisitor wiping = new WipingVisitor();

            Console.WriteLine("Start Dusting");
            foreach (var w in clean)
            {
                w.Accept(dusting);
            }

            Console.WriteLine("\nStart Wiping");
            foreach (var w in clean)
            {
                w.Accept(wiping);
            }
        }
    }
}
