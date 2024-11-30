using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.TemplateMethod
{
    public class Sniper : Weapon
    {
        protected override void Trigger()
        {
            Console.WriteLine("Shooting bullets..");
        }
        protected override void Range()
        {
            Console.WriteLine("Range 800 meter");
        }
    }
}
