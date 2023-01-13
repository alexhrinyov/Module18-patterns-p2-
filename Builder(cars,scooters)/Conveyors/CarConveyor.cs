using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_cars_scooters_.Conveyors
{
    internal class CarConveyor : Conveyor
    {
        Product Car;
        public CarConveyor()
        {
            Car = new Product("Car");
        }
        public override void BuildDoors()
        {
            Car["doors"] = "Five doors";
        }

        public override void BuildEngine()
        {
            Car["engine"] = "K4M 113 h.p.";
        }

        public override void BuildFrame()
        {
            Car["frame"] = "Car Frame";
        }

        public override void BuildWheels()
        {
            Car["wheels"] = "Four whells";
        }
        public override void Display()
        {
            Car.Show();
        }
    }
}
