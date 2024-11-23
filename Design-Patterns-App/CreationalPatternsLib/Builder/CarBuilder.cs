using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.Builder
{
    public class CarBuilder
    {
        private CarInterface _builder;

        public CarBuilder(CarInterface builder)
        {
            _builder = builder;
        }

        public Car Construct()
        {
            _builder.BuildEngine();
            _builder.BuildWheels();
            _builder.BuildSpoiler();
            _builder.BuildColor();
            return _builder.GetCar();
        }
    }
}
