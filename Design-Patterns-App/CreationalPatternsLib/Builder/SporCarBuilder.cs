using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.Builder
{
    public class SporCarBuilder : CarInterface
    {
        private Car _car = new Car();
        public void BuildEngine()
        {
            _car.Engine = "V8 Turbo Motor";
        }
        public void BuildWheels()
        {
            _car.Wheels = "18 inch Çelik Jantlar";
        }
        public void BuildSpoiler()
        {
            _car.Spoiler = "Spoiler Var";
        }
        public void BuildColor()
        {
            _car.Color = "Metalik Mavi";
        }
        public Car GetCar() 
        {
            return _car;
        }
    }
}
