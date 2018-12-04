using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : IElectricCar
    {
        public Tesla(string model, string color, int battery)
        {
            this.Model = model;
            this.Battery = battery;
            this.Color = color;
        }

        public string Model { get; set; }

        public int Battery { get; set; }

        public string Color { get; set; }

        public void Start()
        {
            Console.WriteLine("Engine start"); ;
        }

        public void Stop()
        {
            Console.WriteLine("Breaaak!"); ;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
