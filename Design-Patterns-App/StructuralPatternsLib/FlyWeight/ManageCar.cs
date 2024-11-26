using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.FlyWeight
{
    public class ManageCar
    {
        private readonly Dictionary<string, Car> _cars = new Dictionary<string, Car>();

        public Car GetCar(string brand, string model, int year)
        {
            string key = $"{brand}_{model}_{year}";

            if (!_cars.ContainsKey(key))
            {
                _cars[key] = new Car(brand, model, year);
                Console.WriteLine($"New Car added: {brand} {model} {year}");
            }
            else
            {
                Console.WriteLine($"Existing Car Used: {brand} {model} {year}");
            }

            return _cars[key];
        }
    }
}
