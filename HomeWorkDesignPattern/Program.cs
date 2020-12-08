using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CarShowroom factroy = new TurkeyCarFactroy();
            Car car2 = factroy.OrderCar("Sedan");
            ControlPanel panel = new ControlPanel();
            Sunroof sunroof = new Sunroof(car2);
            SunroofOpenCommand openCommand = new SunroofOpenCommand(sunroof);
            SunroofCloseCommand closeCommand = new SunroofCloseCommand(sunroof);
            panel.setCommand(openCommand);
            panel.ButtonWasPressed();
            panel.setCommand(closeCommand);
            panel.ButtonWasPressed();

            Engine engine = new Engine();
            Headlight headlight = new Headlight();
            SeatBelt seatBelt = new SeatBelt();
            CarFacade facade = new CarFacade(car2,engine, headlight, seatBelt);
            facade.StartDrive();
            facade.StopDrive();
            Console.ReadLine();
        }
    }
}
