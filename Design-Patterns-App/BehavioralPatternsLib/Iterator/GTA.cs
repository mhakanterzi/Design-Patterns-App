using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Iterator
{
    public class GTA : IAggregate
    {
        private List<string> alphabet = new List<string>();

        public void Add(string letter)
        {
            alphabet.Add(letter);
        }
        public void Remove(string letter)
        {
            alphabet.Remove(letter);
        }

        public IIterator CreateIterator()
        {
            return new GTAIterator(this);
        }

        public int Count => alphabet.Count;

        public string GetItem(int index)
        {
            return alphabet[index];
        }
    }
}
