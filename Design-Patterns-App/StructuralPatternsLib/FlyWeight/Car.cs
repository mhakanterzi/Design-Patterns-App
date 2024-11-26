using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.FlyWeight
{
    public class Car
    {
        private string Brand {  get; set; }
        private string Model { get; set; }
        private int Year {  get; set; }

        public Car(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public void UserInfo(string plate, string owner)
        {
            Console.WriteLine($"Car Info: {Brand} {Model} {Year}  {plate} ,Owner {owner}");
        }
    }
}
