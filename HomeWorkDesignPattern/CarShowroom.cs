using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    abstract class CarShowroom
    {
        public CarShowroom()
        {

        }
        public Car OrderCar(string type)
        {
            Car car;
            car = CreateCar(type);
            car.Prepare();
            car.Dispatch();
            return car;
        }
        public abstract Car CreateCar(string type);
    }
}
