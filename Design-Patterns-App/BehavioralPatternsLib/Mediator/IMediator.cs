using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Mediator
{
    public interface IMediator
    {
        void Notify(Component sender, string message);
    }
}
