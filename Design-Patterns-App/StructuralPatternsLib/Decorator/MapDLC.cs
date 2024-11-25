using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Decorator
{
    public class MapDLC : Decorator
    {
        public MapDLC (IGame game) : base (game) { }

        public override string GetName()
        {
            return _game.GetName()+" + Map DLC";
        }

        public override double GetCost()
        {
            return _game.GetCost()+18.00;
        }
    }
}
