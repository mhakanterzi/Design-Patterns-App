using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Iterator
{
    public interface IIterator
    {
        bool HasNext();
        string Next();
    }
}
