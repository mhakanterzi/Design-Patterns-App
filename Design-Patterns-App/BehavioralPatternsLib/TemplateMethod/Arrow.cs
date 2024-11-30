using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.TemplateMethod
{
    public class Arrow : Weapon
    {
        protected override void Trigger()
        {
            Console.WriteLine("Releasing Arrow..");
        }
        protected override void Range()
        {
            Console.WriteLine("Range 25 meter");
        }
    }
}
