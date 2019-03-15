using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVA_HW1.Shared;
using KVA_HW1.BAL;

namespace KVA_HW1
{
    class Program
    {
        static void Main(string[] args)
        {
            CVehicle[] massTransport = new CVehicle[12];
            massTransport[0] = new CCar("Car  #1", 1000, 100, 2015, 0, 0, "Red");
            massTransport[1] = new CPlane("Plane#1", 500000, 1000, 2010, 0, 0, 5000, 230);
            massTransport[2] = new CShip("Ship #1", 400000, 60, 2016, 0, 0, 500, "Kiyv");
            massTransport[3] = new CCar("Car  #2", 1200, 120, 2017, 0, 0, "Green");
            massTransport[4] = new CPlane("Plane#2", 520000, 900, 2014, 0, 0, 7000, 120);
            massTransport[5] = new CShip("Ship #1", 420000, 40, 2018, 0, 0, 700, "Kiyv 1");
            massTransport[6] = new CCar("Car  #4", 1300, 120, 2016, 0, 0, "Yellow");
            massTransport[7] = new CPlane("Plane#3", 530000, 1100, 2012, 0, 0, 8000, 280);
            massTransport[8] = new CShip("Ship #1", 430000, 30, 2014, 0, 0, 400, "Dnipro");
            massTransport[9] = new CCar("Car  #3", 1400, 130, 2015, 0, 0, "Blue");
            massTransport[10] = new CPlane("Plane#4", 550000, 1200, 2011, 0, 0, 4000, 100);
            massTransport[11] = new CShip("Ship #1", 460000, 70, 2017, 0, 0, 520, "Chernigov");


            Console.WriteLine("1. Найти транспортное стредство от 2011 до 2015 года выпуска");
            Console.WriteLine("2. Найти транспортное стредство со скоростью от 70 до 900 км/час ");
            Console.WriteLine("3. Найти транспортное стредство с посадочными местами от 150 до 500");
            Console.WriteLine("4. Найти транспортное стредство красного цвета");
            Console.WriteLine("Введите пункт меню");

            int MenuItem;
            int.TryParse(Console.ReadLine(), out MenuItem);

            Console.WriteLine("Результат поиска");
            switch (MenuItem)
            {
                case 1:
                    MySearch.VehicleYear(massTransport, 2015, 2011);
                    break;
                case 2:
                    MySearch.VehicleSpeed(massTransport, 900, 70);
                    break;
                case 3:
                    MySearch.VehiclePassengerCapacity(massTransport, 500, 150);
                    break;
                case 4:
                    MySearch.VehicleColor(massTransport, "Red");
                    break;

                default:
                    break;
            }

            Console.WriteLine("Полный список");
            foreach (var item in massTransport)
            {
                Console.WriteLine(item.ToString());
            }
            Console.ReadLine();
        }
    }
}
