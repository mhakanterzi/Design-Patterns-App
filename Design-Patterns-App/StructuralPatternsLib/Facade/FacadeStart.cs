using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Facade
{
    public class FacadeStart
    {
        private readonly Computer _computer;
        private readonly Monitor _monitor;
        private readonly Light _light;

        public FacadeStart()
        {
            _computer = new Computer();
            _monitor = new Monitor();
            _light = new Light();
        }

        public void StartsPc()
        {
            Console.WriteLine("Start Command Received..");

            _computer.StartComputer();
            _monitor.OpenMonitor();
            _light.OpenLight();

            Console.WriteLine("Succesfuly...");
        }
    }
}
