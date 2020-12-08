using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class EnglandCarFactory:CarShowroom
    {
        Car car;
        public override Car CreateCar(string type)
        {
            if (type.Equals("Sedan"))
            {
                car = new EnglandStyleSedan();
            }
            else if (type.Equals("SUV"))
            {
                car = new EnglandStyleSUV();
            }
            return car;
        }
    }
}
