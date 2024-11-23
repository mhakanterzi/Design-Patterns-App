using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.FactoryMethod
{
    public class FactoryMethodAirway : FactoryMethodBase
    {
        public FactoryMethodAirway()
        {
            DeliveryTime = "10 Saat";
            SpentGas = "50 litre";
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Ulaşma Zamanı: {DeliveryTime}, Harcanan gas: {SpentGas}");
        }
    }
}
