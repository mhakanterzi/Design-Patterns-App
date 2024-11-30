using Design_Patterns_App.BehavioralPatternsLib.ChainOfResponsibility;
using Design_Patterns_App.BehavioralPatternsLib.Command;
using Design_Patterns_App.BehavioralPatternsLib.Iterator;
using Design_Patterns_App.BehavioralPatternsLib.Mediator;
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

        public void IteratorMenu()
        {
            Console.Clear();
            Console.WriteLine("Iterator: Bu yöntem bir koleksiyonun elemanlarını açığa çıkarmadan öğeleri arasında gezinmemize olanak sağlar.\n\n");

            GTA books = new GTA();
            books.Add("Grand Theft Auto San Andreas");
            books.Add("Grand Theft Auto Vice City");
            books.Add("Grand Theft Auto IV");
            books.Add("Grand Theft Auto V");

            IIterator iterator = books.CreateIterator();

            while (iterator.HasNext())
            {
                Console.WriteLine(iterator.Next());
            }


            Console.ReadKey();
            var program = new Program();
            program.BehavioralPatterns();
        }

        public void MediatorMenu()
        {
            Console.Clear();
            Console.WriteLine("Mediator: Bu yöntem nesneler arasındaki doğrudan işletişimleri kısıtlar ve bu iletişimi bir mediator " +
                "nesnesi ile yapmaya zorlar.");

            HomeMediatorRun run = new HomeMediatorRun();
            run.HomeRun();


            Console.ReadKey();
            var program = new Program();
            program.BehavioralPatterns();
        }
    }
}
