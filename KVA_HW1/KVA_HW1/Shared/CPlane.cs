using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVA_HW1.Shared
{
    class CPlane : CVehicle, IPassenger, IFly
    {
        public int Height { set; get; }
        public int PassengerCapacity { set; get; }

        public CPlane(string name, int cost, int speed, int yearMake, int x, int y, int height, int passengerCapacity) : base(name, cost, speed, yearMake, x, y)
        {
            Height = height;
            PassengerCapacity = passengerCapacity;
        }


    }
}
