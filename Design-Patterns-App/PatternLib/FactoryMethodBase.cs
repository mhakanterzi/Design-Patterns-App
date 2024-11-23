using Design_Patterns_App.PatternLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.PatternLib
{
    public abstract class FactoryMethodBase
    {
        public string DeliveryTime {  get; set; }
        public string SpentGas { get; set; }
        public abstract void DisplayDetails(); 
    }
}
