using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class TurkeyStyleSedan: Car
    {
        public TurkeyStyleSedan()
        {
            Description = "Turkey Style Sedan";
        }
        public override double getCost()
        {
            return 200000;
        }
    }
}
