using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.FlyWeight
{
    public class AddingCar
    {
        public void AddCar() 
        { 
            ManageCar manageCar = new ManageCar();

            Car car1 = manageCar.GetCar("Mercedes", "AMG GT", 2023);
            car1.UserInfo("53asd53", "Hakan");

            Car car12 = manageCar.GetCar("Mercedes", "AMG GT", 2023);
            car12.UserInfo("53trz53", "Burak");

            Car car2 = manageCar.GetCar("Porche", "911",2010);
            car2.UserInfo("53qwe53", "Terzi");
            Car car22 = manageCar.GetCar("Porche", "911", 2010);
            car22.UserInfo("55qwe55", "Duygu");
        }
        
    }
}
