using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Command
{
    public class StopMusic : ICommand
    {
        private readonly Music _music;

        public StopMusic(Music music)
        {
            _music = music;
        }

        public void Execute()
        {
            _music.StopMusic();
        }

        public void Undo()
        {
            _music.StartMusic();
        }
    }
}
