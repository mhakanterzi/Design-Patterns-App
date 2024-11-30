using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Strategy
{
    public interface ITransportStrategy
    {
        void Travel(string start,  string end);
    }
}
