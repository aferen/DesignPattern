using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class TurkeyCarFactroy: CarShowroom
    {
        Car car;
        public override Car CreateCar(string type)
        {
            if (type.Equals("Sedan"))
            {
                car = new TurkeyStyleSedan();
            }
            else if (type.Equals("SUV"))
            {
                car = new TurkeyStyleSUV();
            }
            return car;
        }
    }
}
