using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Command
{
    public class Music
    {
        public void StartMusic()
        {
            Console.WriteLine("Playing Music...");
        }
        public void StopMusic()
        {
             Console.WriteLine("Stopped Music.");
        }
    }
}
