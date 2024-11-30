using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.TemplateMethod
{
    public abstract class Weapon
    {
        public void Fire()
        {
            Aim();
            Reload();
            Trigger();
            Range();
        }

        private void Aim()
        {
            Console.WriteLine("Aiming to target.");
        }
        private void Reload()
        {
            Console.WriteLine("Reloading Weapon.");
        }
        protected abstract void Trigger();
        protected abstract void Range();
    }
}
