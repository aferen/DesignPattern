using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class SunroofCloseCommand : Command
    {
        Sunroof sunroof;
        public SunroofCloseCommand(Sunroof sunroof)
        {
            this.sunroof = sunroof;
        }

        public void Execute()
        {
            sunroof.Close();
        }
    }
}
