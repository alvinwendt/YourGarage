using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    public class Car : Vehicle
    {
        public int BatteryCapacity { get; set; }


        public void Driving()
        {
            Console.WriteLine("Driving");
        }

        public void Braking()
        {
            Console.WriteLine("Braking");
        }
    }
}
