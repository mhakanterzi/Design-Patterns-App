using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.ChainOfResponsibility
{
    public class TestLevel_2 : TestHandler
    {
        public override void Handle(TestLevel level)
        {
            if (level == TestLevel.level_2)
            {
                Console.WriteLine("This is Test level 2...");
            }
            else
            {
                NextHandler.Handle(level);
            }
        }
    }
}
