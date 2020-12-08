using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class SeatBelt
    {
        public int State = 0;
        public void Fasten()
        {
            Console.WriteLine("Seat belt fasten");
            State = 1;
        }
        public void TakeOff()
        {
            Console.WriteLine("Seat belt take off");
            State = 0;
        }
        public int getState()
        {
            return State;
        }
    }
}
