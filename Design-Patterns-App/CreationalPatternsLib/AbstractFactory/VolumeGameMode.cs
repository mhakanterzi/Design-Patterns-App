using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.AbstractFactory
{
    public class VolumeGameMode : VolumeInterface
    {
        public void SetVolume()
        {
            Console.WriteLine("Ses oyun modu için arttırıldı ve stereo mod açıldı");
        }
    }
}
