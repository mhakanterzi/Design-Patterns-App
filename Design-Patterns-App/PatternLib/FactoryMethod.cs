using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.PatternLib
{
    public static class FactoryMethod
    {
        public static FactoryMethodBase CreateWay(string carType)
        {
            switch (carType)
            {
                case "Airway":
                    return new FactoryMethodAirway(); 
                case "Seaway":
                    return new FactoryMethodSeaway(); 
                case "Roadway":
                    return new FactoryMethodRoadway(); 
                default:
                    throw new ArgumentException("Geçerli bir yol giriniz."); 
            }
        }
    }
}