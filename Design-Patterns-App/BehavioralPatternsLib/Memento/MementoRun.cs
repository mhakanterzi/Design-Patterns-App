using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Memento
{
    public class MementoRun
    {
        public void RunMemento()
        {
            var editor = new NoteEditor();
            var history = new NoteHistory();

            editor.Write("First Note");
            history.Save(editor.Save());

            editor.Write("Second Note");
            history.Save(editor.Save());

            editor.Write("Third Note");

            Console.WriteLine("Undo");
            editor.Restore(history.Undo());
            editor.Restore(history.Undo());
        }
    }
}
