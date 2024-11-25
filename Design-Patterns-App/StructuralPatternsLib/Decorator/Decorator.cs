using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Decorator
{
    public abstract class Decorator : IGame
    {
        protected IGame _game;

        public Decorator(IGame game)
        {
            _game = game;
        }
        public abstract string GetName();
        public abstract double GetCost();
    }
}
