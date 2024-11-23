using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.FactoryMethod
{
    public static class FactoryMethod
    {
        public static FactoryMethodBase CreateWay(string carType)
        {
            switch (carType)
            {
                case "Havayolu":
                    return new FactoryMethodAirway();
                case "Denizyolu":
                    return new FactoryMethodSeaway();
                case "Karayolu":
                    return new FactoryMethodRoadway();
                default:
                    throw new ArgumentException("Geçerli bir yol giriniz.");
            }
        }
    }
}