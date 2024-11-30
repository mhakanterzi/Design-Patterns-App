using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Visitor
{
    public class DustingVisitor : ICleanVisitor
    {
        public void Clean(LivingRoom livingRoom)
        {
            Console.WriteLine("Dusting Living Room..");
        }
        public void Clean(Corridor corridor)
        {
            Console.WriteLine("Dusting Corridor");
        }
        public void Clean(Rooms rooms)
        {
            Console.WriteLine("Dusting Rooms..");
        }
    }
}
