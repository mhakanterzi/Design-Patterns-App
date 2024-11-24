using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_App.StructuralPatternsLib.Adapter
{
    public class Adapter : InterfaceTL
    {
        private readonly USD _currency;
        private readonly double _exchange;

        public Adapter(USD currnecy, double exchange)
        {
            _currency = currnecy;
            _exchange = exchange;
        }

        public double GetTL()
        {
            //Exchange USD to TL
            return _currency.GetUSD()*_exchange;
        }
    }
}
