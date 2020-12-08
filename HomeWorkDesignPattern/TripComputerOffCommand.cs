using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class TripComputerOffCommand : Command
    {
        TripComputer tripComputer;
        public TripComputerOffCommand(TripComputer tripComputer)
        {
            this.tripComputer = tripComputer;
        }

        public void Execute()
        {
            tripComputer.Off();
        }
    }
}
