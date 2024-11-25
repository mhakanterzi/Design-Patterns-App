using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Decorator
{
    public class AC : IGame
    {
        public string GetName()
        {
            return "Assasins Creed";
        }

        public double GetCost()
        {
            return 30.00;
        }
    }
}
