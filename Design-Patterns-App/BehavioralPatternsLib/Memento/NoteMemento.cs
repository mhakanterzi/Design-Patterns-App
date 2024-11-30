using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Memento
{
    public class NoteMemento
    {
        public string Note { get; private set; }

        public NoteMemento(string note) 
        {
            Note = note;
        }
    }
}
