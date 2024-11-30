using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.TemplateMethod
{
    public class TempleRun
    {
        public void Run()
        {
            Console.WriteLine("Using a gun:");
            Weapon gun = new Gun();
            gun.Fire();

            Console.WriteLine();

            Console.WriteLine("Using a bow:");
            Weapon bow = new Arrow();
            bow.Fire();

            Console.WriteLine();

            Console.WriteLine("Using Sniper:");
            Weapon sniper = new Sniper();
            sniper.Fire();
        }
    }
}
