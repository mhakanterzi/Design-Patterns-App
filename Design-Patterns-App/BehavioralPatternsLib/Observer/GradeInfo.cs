using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Observer
{
    public class GradeInfo : INote
    {
        private List<IObserver> _observer = new List<IObserver>();

        private string _notes;

        public string Notes
        {
            get { return _notes; }
            set { _notes = value; Notify(); }
        }

        public void Add(IObserver observer)
        {
            _observer.Add(observer);
            Console.WriteLine("Observer added.");
        }

        public void Delete(IObserver observer)
        {
            _observer.Remove(observer);
            Console.WriteLine("Observer removed.");
        }

        public void Notify()
        {
            Console.WriteLine("Notifying students...");
            foreach (var observer in _observer)
            {
                observer.Update(_notes);
            }
        }
    }
}
