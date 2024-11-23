using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.Builder
{
    public class Car
    {
        public string Engine {  get; set; }
        public string Wheels { get; set; }
        public string Spoiler { get; set; }
        public string Color { get; set; }

        public void ShowDetail()
        {
            Console.WriteLine($"Motor: {Engine}");
            Console.WriteLine($"Tekerlek Boyutu: {Wheels}");
            Console.WriteLine($"Spoiler: {Spoiler}");
            Console.WriteLine($"Renk: {Color}");
        }
    }
}
