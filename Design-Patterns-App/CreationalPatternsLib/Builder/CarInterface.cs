using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.CreationalPatternsLib.Builder
{
    public interface CarInterface
    {
        void BuildEngine();
        void BuildWheels();
        void BuildSpoiler();
        void BuildColor();
        Car GetCar();
    }
}
