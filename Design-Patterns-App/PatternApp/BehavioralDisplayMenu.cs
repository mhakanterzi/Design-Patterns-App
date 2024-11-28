using Design_Patterns_App.BehavioralPatternsLib.ChainOfResponsibility;
using Design_Patterns_App.BehavioralPatternsLib.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.PatternApp
{
    public class BehavioralDisplayMenu
    {
        public void ChainOfResponsibilityMenu()
        {
            Console.Clear();
            Console.WriteLine("Chain Of Responsibility: Bu yöntem istekleri işleyici bir zincir boyunca iletir. Her bir işleyici ya isteği işler ya da bir sonraki işleyiciye aktarır.\n\n");

            Chain start = new Chain();
            start.Start();

            Console.ReadKey();
            var program = new Program();
            program.BehavioralPatterns();
        }

        public void CommandMenu()
        {
            Console.Clear();
            Console.WriteLine("Command: Bu yöntem sayesinde bir isteğin bilgilerini istekten bağımsız bir nesneye çevirebiliyoruz." +
                "Bu dönüşümle bir isteğin yürütülmesini geciktirmenize veya sıraya koymanıza ve geri alınamaz işlemleri desteklememizi sağlar.\n\n");

            Music music = new Music();

            ICommand startMusic = new PlayMusic(music);
            ICommand stopMusic = new StopMusic(music);

            Control control = new Control();

            control.ExecuteCommand(startMusic); 
            control.ExecuteCommand(stopMusic); 

            control.UndoCommand();    
            control.UndoCommand();

            Console.ReadKey();
            var program = new Program();
            program.BehavioralPatterns();
        }
    }
}
