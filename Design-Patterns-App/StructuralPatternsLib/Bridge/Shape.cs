using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Bridge
{
    public abstract class Shape
    {
        protected IColor _color;

        protected Shape(IColor color) 
        {
            _color = color;
        }
        public abstract void Draw();
    }
}
