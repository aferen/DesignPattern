using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class TurkeyStyleSUV: Car
    {
        public TurkeyStyleSUV()
        {
            Description = "Turkey Style SUV";
        }
        public override double getCost()
        {
            return 300000;
        }
    }
}
