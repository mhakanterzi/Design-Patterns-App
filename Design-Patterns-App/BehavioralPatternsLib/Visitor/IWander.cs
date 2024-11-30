using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Visitor
{
    public interface IWander
    {
        void Accept(ICleanVisitor visitor);
    }
}
