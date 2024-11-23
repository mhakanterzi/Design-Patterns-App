using Design_Patterns_App.CreationalPatternsLib.Builder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Design_Patterns_App.CreationalPatternsLib.Prototype
{
    public class Prototype  :PrototypeInterface
    {
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Door {  get; set; }

        public Prototype(string brand, string color, int door)
        {
            Brand = brand;
            Color = color;
            Door = door;
        }
        public PrototypeInterface GetClone()
        {
            return new Prototype(Brand, Color, Door);
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Marka: {Brand}, Renk: {Color}, Kapı Sayısı: {Door}");
        }
    }
}
