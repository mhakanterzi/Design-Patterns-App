using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.FactoryMethod
{
    public class FactoryMethodSeaway : FactoryMethodBase
    {
        public FactoryMethodSeaway()
        {
            DeliveryTime = "20 saat";
            SpentGas = "100 litre";
        }
        public override void DisplayDetails()
        {
            Console.WriteLine($"Ulaşma Zamanı: {DeliveryTime}, Harcanan gas: {SpentGas}");
        }
    }
}
