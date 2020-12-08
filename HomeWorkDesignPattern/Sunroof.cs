using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class Sunroof: AdditionDecorator
    {
        Car car;
        public Sunroof(Car car)
        {
            this.car = car;
        }
        public override string getDescription()
        {
            return "Sunroof";
        }
        public override double getCost()
        {
            return 2000 + car.getCost();
        }

        public void Open()
        {
            Console.WriteLine("Sunroof Open");
        }

        public void Close()
        {
            Console.WriteLine("Sunroof Close");
        }
    }
}
