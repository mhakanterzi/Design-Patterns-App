using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Memento
{
    public class NoteEditor
    {
        public string Note { get; private set; }

        public void Write(string text)
        {
            Note = text;
            Console.WriteLine($"Note Editor : {Note}");
        }

        public NoteMemento Save()
        {
            Console.WriteLine("NoteEditor: Saving the note.");
            return new NoteMemento(Note);
        }

        public void Restore(NoteMemento memento)
        {
            Note = memento.Note;
            Console.WriteLine($"NoteEditor: Restored Note = {Note}");
        }
    }
}
