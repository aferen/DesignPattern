using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class EnglandStyleSUV : Car
    {
        public EnglandStyleSUV()
        {
            Description = "England Style SUV";
        }
        public override double getCost() 
        {
            return 30000;
        }
    }
}
