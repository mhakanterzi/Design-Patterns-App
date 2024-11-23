using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.Builder
{
    public class SUVBuilder : CarInterface
    {
        private Car _car = new Car();
        public void BuildEngine()
        {
            _car.Engine = "V8 4.0L Motor";
        }
        public void BuildWheels()
        {
            _car.Wheels = "21 inch Off-Road Jant";
        }
        public void BuildSpoiler()
        {
            _car.Spoiler = "Spoiler Yok";
        }
        public void BuildColor()
        {
            _car.Color = "Siyah";
        }
        public Car GetCar()
        {
            return _car;
        }
    }
}
