using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkDesignPattern
{
    abstract class Car
    {
        Engine engine;
        public int State = 0;
        public Car()
        {
           
        }
        public string Description { get; set; }
        public abstract double getCost();
        public string getDescription()
        {
            return Description;
        }
        public void Prepare()
        {

        }
        public void Dispatch()
        {

        }
        public void Start()
        {
            Console.WriteLine("Car starting");
            State = 1;    
        }
        public void Stop()
        {
            Console.WriteLine("Car Stopping");
            State = 0;
        }
        public int getState()
        {
            return State;
        }
    }
}
