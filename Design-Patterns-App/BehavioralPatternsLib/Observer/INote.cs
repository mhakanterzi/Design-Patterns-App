using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Observer
{
    public interface INote
    {
        void Add(IObserver student);
        void Delete(IObserver student);
        void Notify();
    }
}
