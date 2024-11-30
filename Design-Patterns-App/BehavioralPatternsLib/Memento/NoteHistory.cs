using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Memento
{
    public class NoteHistory
    {
        Stack<NoteMemento> _undo = new Stack<NoteMemento>();
        public void Save(NoteMemento noteMemento)
        {
            _undo.Push(noteMemento);
        }

        public NoteMemento Undo()
        {
            if (_undo.Count > 0)
            {
                Console.WriteLine("NoteHistory: Undoing the last change.");
                return _undo.Pop();
            }
            else
            {
                Console.WriteLine("NoteHistory: No changes to undo.");
                return null;
            }
        }
    }
}
