using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Decorator
{
    public class SkinsDLC : Decorator
    {
        public SkinsDLC(IGame game) : base(game) { }

        public override string GetName()
        {
            return _game.GetName() + " + Skins DLC";
        }
        public override double GetCost()
        {
            return _game.GetCost() + 15.50;
        }
    }
}
