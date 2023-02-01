using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YourGarage
{
    public class Aircraft : Vehicle
    {

        public void Flying()
        {
            Console.WriteLine("Flying");
        }

        public void Landing()
        {
            Console.WriteLine("Landing");
        }
    }
}
