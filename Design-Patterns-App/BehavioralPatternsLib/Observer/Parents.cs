using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Observer
{
    public class Parents : IObserver
    {
        private string _name;
        public Parents(string name)
        {
            _name = name;
        }

        public void Update(string notes)
        {
            Console.WriteLine($"Parent {_name} send to grade:{notes}");
        }
    }
}
