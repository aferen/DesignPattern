using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class ControlPanel
    {
        Command command;

        public void setCommand(Command command)
        {
            this.command = command;
        }
        public void ButtonWasPressed()
        {
            command.Execute();
        }
    }
}

