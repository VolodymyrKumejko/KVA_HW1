using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVA_HW1.Shared
{
    public class CShip : CVehicle
    {
        public int PassengerCapacity { set; get; }
        public string HomePort { set; get; }

        public CShip(string name, int cost, int speed, int yearMake, int x, int y, int passengerCapacity, string homePort) : base(name, cost, speed, yearMake, x, y)
        {
            PassengerCapacity = passengerCapacity;
            HomePort = homePort;

        }
    }
}
