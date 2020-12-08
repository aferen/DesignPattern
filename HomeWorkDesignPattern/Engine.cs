using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class Engine
    {
        public int State = 0;
        public void Start()
        {
            Console.WriteLine("Engine Starting");
            State = 1;
        }
        public void Stop()
        {
            Console.WriteLine("Engine Stopping");
            State = 0;
        }

        public int getState()
        {
            return State;
        }
    }
}
