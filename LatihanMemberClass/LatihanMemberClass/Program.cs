using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMemberClass
{
    class Program
    {
        static void Main(string[] args)
        {

            //membuat objek taxi
            Taxi taxi = new Taxi();

            //pengesetan nilai properties
            taxi.DriverName = "Jono";
            taxi.OnDuty = true;
            taxi.NumPassenger = 10;

            //pemanggilan method 
            taxi.TaxiInfo();
            Console.WriteLine();

            taxi.PickupPassenger();
            taxi.DropOffPassenger();

            Console.ReadKey();
        }
    }
}
