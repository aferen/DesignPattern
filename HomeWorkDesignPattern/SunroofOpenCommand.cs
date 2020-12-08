using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class SunroofOpenCommand : Command
    {
        Sunroof sunroof;
        public SunroofOpenCommand(Sunroof sunroof)
        {
            this.sunroof = sunroof;
        }

        public void Execute()
        {
            sunroof.Open();
        }
    }
}
