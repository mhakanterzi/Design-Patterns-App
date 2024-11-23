using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.AbstractFactory
{
    public class LightWorkMode : LightingInterface
    {
        public void SetLighting()
        {
            Console.WriteLine("Işıklar çalışma modu için sıcak moda getirildi.");
        }
    }
}
