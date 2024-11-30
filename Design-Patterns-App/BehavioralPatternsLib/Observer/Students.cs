using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.BehavioralPatternsLib.Observer
{
    public class Students :IObserver
    {
        private string _name;
        public Students(string name)
        {
            _name = name;
        }

        public void Update(string notes)
        {
            Console.WriteLine($"{_name} send to grade:{notes}");
        }
    }
}
