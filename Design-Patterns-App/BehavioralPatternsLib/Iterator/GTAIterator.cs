using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Iterator
{
    public class GTAIterator : IIterator
    {
        private GTA _alphabet;
        private int _index; 

        public GTAIterator(GTA alphabet)
        {
            _alphabet = alphabet;
            _index = 0;
        }

        public bool HasNext()
        {
            return _index < _alphabet.Count;
        }

        public string Next()
        {
            if (_index < _alphabet.Count)
            {
                return _alphabet.GetItem(_index++);
            }
            return null;
        }
    }
}
