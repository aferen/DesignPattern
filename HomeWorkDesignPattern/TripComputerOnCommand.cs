using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class TripComputerOnCommand : Command
    {
        TripComputer tripComputer;
        public TripComputerOnCommand(TripComputer tripComputer)
        {
            this.tripComputer = tripComputer;
        }

        public void Execute()
        {
            tripComputer.On();
        }
    }
}
