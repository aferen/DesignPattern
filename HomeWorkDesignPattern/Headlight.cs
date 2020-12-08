using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class Headlight
    {
        public int State = 0;
        public void On()
        {
            Console.WriteLine("Headlight turn on");
            State = 1;
        }
        public void Off()
        {
            Console.WriteLine("Headlight turn off");
            State = 0;
        }
        public int getState()
        {
            return State;
        }
    }
}
