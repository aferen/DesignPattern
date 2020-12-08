using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class TripComputer: AdditionDecorator
    {
        Car car;
        public TripComputer(Car car)
        {
            this.car = car;
        }
        public override string getDescription()
        {
            return "Trip Computer";
        }
        public override double getCost()
        {
            return 3000 + car.getCost();
        }

        public void On()
        {
            Console.WriteLine("Trip Computer On");
        }

        public void Off()
        {
            Console.WriteLine("Trip Computer Off");
        }
    }
}
