using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Adapter
{
    //This class unadapted class
    public class USD
    {
        private double _usdValue;
        public USD(double usdValue)
        {
            _usdValue = usdValue;
        }
        public double GetUSD()
        {
            return _usdValue;
        }
    }
}
