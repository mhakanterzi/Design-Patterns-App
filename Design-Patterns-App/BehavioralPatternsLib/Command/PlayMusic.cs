using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Command
{
    public class PlayMusic : ICommand
    {
        private readonly Music _music;

        public PlayMusic(Music music)
        {
            _music = music;
        }

        public void Execute()
        {
            _music.StartMusic();
        }

        public void Undo()
        {
            _music.StopMusic();
        }
    }
}
