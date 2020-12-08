using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class CarFacade
    {
        Engine engine;
        Headlight headlight;
        SeatBelt seatBelt;
        Car car;

        public CarFacade(Car car, Engine engine, Headlight headlight, SeatBelt seatBelt)
        {
            this.car = car;
            this.engine = engine;
            this.headlight = headlight;
            this.seatBelt = seatBelt;
        }

        public void StartDrive()
        {
            Console.WriteLine("Get ready to drive a car...");
            int CarState = car.getState();
            if (CarState == 0)
            {
                car.Start();
                int state1 = seatBelt.getState();
                int state2 = headlight.getState();
                int state3 = engine.getState();
                if (state1 == 1)
                {
                    Console.WriteLine("Emniyet kemeri zaten takılı.");
                }
                else
                {
                    seatBelt.Fasten();
                }

                if (state2 == 1)
                {
                    Console.WriteLine("Farlar zaten açık.");
                }
                else
                {
                    headlight.On();
                }

                if (state3 == 1)
                {
                    Console.WriteLine("Motor zaten çalışıyor.");
                }
                else
                {
                    engine.Start();
                }
            }
            else
            {
                Console.WriteLine("Araba zaten çalışıyor.");
            }
        }

        public void StopDrive()
        {
            Console.WriteLine(Environment.NewLine + "Stopping drive...");
            int CarState = car.getState();
            if (CarState == 1)
            {
                car.Stop();
                int state1 = seatBelt.getState();
                int state2 = headlight.getState();
                int state3 = engine.getState();
                if (state3 == 0)
                {
                    Console.WriteLine("Motor zaten çalışmıyor.");
                }
                else
                {
                    engine.Stop();
                }

                if (state2 == 0)
                {
                    Console.WriteLine("Farlar zaten kapalı.");
                }
                else
                {
                    headlight.Off();
                }

                if (state1 == 0)
                {
                    Console.WriteLine("Emniyet kemeri zaten takılı değil.");
                }
                else
                {
                    seatBelt.TakeOff();
                }
            }
            else
            {
                Console.WriteLine("Araba zaten kapalı.");
            }


        }
    }
}
