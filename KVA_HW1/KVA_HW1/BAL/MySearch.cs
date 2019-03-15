using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVA_HW1.Shared;

namespace KVA_HW1.BAL
{
    class MySearch
    {
        public static void VehicleYear(CVehicle[] massVeh, int yearUp, int yearDown)
        {
            foreach (var item in massVeh)
            {
                if (item.YearMake >= yearDown && item.YearMake <= yearUp)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public static void VehicleSpeed(CVehicle[] massVeh, int speedUp, int speedDown)
        {
            foreach (var item in massVeh)
            {
                if (item.Speed >= speedDown && item.Speed <= speedUp)
                {
                    Console.WriteLine(item.ToString());
                }
            }
        }

        public static void VehiclePassengerCapacity(CVehicle[] massVeh, int passengerCapacityUp, int passengerCapacityDown)
        {
            foreach (var item in massVeh)
            {
                if (item is CShip)
                {

                    if (((CShip)item).PassengerCapacity >= passengerCapacityDown && ((CShip)item).PassengerCapacity <= passengerCapacityUp)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

                if (item is CPlane)
                {

                    if (((CPlane)item).PassengerCapacity >= passengerCapacityDown && ((CPlane)item).PassengerCapacity <= passengerCapacityUp)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }

            }
        }


        public static void VehicleColor(CVehicle[] massVeh, string color)
        {
            foreach (var item in massVeh)
            {
                if (item is CCar)
                {

                    if (((CCar)item).Color == color)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
        }


    }
}
