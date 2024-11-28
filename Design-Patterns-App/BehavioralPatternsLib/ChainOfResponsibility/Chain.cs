using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.ChainOfResponsibility
{
    public class Chain
    {
        public void Start()
        {
            TestHandler level_1 = new TestLevel_1();
            TestHandler level_2 = new TestLevel_2();
            TestHandler level_3 = new TestLevel_3();

            level_1.Next(level_2);
            level_2.Next(level_3);

            Console.WriteLine("Testing For Level 1:");
            level_1.Handle(TestLevel.Level_1);

            Console.WriteLine("\nTesting For Level 2:");
            level_2.Handle(TestLevel.level_2);

            Console.WriteLine("\nTesting For Level 3:");
            level_3.Handle(TestLevel.level_3);
        }
    }
}
