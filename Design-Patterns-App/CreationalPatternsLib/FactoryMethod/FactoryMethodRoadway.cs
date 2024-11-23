using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.FactoryMethod
{
    public class FactoryMethodRoadway : FactoryMethodBase
    {
        public FactoryMethodRoadway()
        {
            DeliveryTime = "30 Saat";
            SpentGas = "150 litre";
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Ulaşma Zamanı: {DeliveryTime}, Harcanan gas: {SpentGas}");
        }
    }
}
