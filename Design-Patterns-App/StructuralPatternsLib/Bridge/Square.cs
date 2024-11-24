using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Bridge
{
    public class Square : Shape
    {
        public Square(IColor color) : base(color) { }

        public override void Draw()
        {
            Console.WriteLine($"{_color.Color()} Kare");
        }
    }
}
