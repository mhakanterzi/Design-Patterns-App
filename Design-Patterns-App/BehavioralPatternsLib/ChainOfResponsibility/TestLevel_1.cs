using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.ChainOfResponsibility
{
    public class TestLevel_1 : TestHandler
    {
        public override void Handle(TestLevel level)
        {
            if (level == TestLevel.Level_1)
            {
                Console.WriteLine($"This is Test level 1...");
            }
            else
            {
                NextHandler.Handle(level);
            }
        }
    }
}
