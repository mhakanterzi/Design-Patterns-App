using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.ChainOfResponsibility
{
    public abstract class TestHandler
    {
        protected TestHandler NextHandler;

        public void Next(TestHandler nextHandler)
        {
            NextHandler = nextHandler;  
        }

        public abstract void Handle(TestLevel level );
    }

    public enum TestLevel
    {
        Level_1,
        level_2,
        level_3
    }
}
