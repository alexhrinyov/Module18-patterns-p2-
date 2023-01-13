using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder_cars_scooters_.Conveyors
{
    internal class MotoConveyor : Conveyor
    {
        Product MotoBike;
        public MotoConveyor()
        {
            MotoBike = new Product("MotoBike");
        }
        public override void BuildDoors()
        {
            MotoBike["doors"] = "No";
        }

        public override void BuildEngine()
        {
            MotoBike["engine"] = "600 cm3, 150 h.p.";
        }

        public override void BuildFrame()
        {
            MotoBike["frame"] = "Aluminium";
        }

        public override void BuildWheels()
        {
            MotoBike["wheels"] = "2 wheels";
        }

        public override void Display()
        {
            MotoBike.Show();
        }
    }
}
