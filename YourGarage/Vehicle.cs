using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    public class Vehicle
    {
        public int FuelCapacity { get; set; }

        public int BatteryCapacity { get; set; }

        public string Color { get; set; }

        public int PassengerOccupancy { get; set; }

        public void Refueling()
        {
            Console.WriteLine("Refueling");
        }
    }
}
