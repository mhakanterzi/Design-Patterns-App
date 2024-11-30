using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Visitor
{
    public class LivingRoom : IWander
    {
        public void Accept(ICleanVisitor visitor)
        {
            visitor.Clean(this);
        }
    }
}
