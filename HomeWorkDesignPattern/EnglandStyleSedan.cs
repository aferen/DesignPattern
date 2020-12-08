using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class EnglandStyleSedan:Car
    {
        public EnglandStyleSedan()
        {
            Description = "England Style Sedan";
        }
        public override double getCost()
        {
            return 20000;
        }
    }
}
