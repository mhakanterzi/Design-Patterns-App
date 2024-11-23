using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.AbstractFactory
{
    public class VolumeWorkMode : VolumeInterface
    {
        public void SetVolume()
        {
            Console.WriteLine("Ses çalışma modu için azaltıldı.");
        }
    }
}
