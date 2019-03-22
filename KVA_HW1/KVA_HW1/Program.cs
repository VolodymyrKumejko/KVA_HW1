using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KVA_HW1.Shared;
using KVA_HW1.BAL;

namespace KVA_HW1
{
    public class CompareBySpeed : IComparer<CVehicle>
    {
        public int Compare(CVehicle x, CVehicle y)
        {
            return x.Speed - y.Speed;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            CVehicle[] massTransport = new CVehicle[12];
            massTransport[0] = new CCar("Car  #1", 1000, 100, 2015, 0, 0, "Red");
            massTransport[1] = new CPlane("Plane#1", 500000, 1000, 2010, 0, 0, 5000, 230);
            massTransport[2] = new CShip("Ship #1", 400000, 60, 2016, 0, 0, 500, "Kiyv");
            massTransport[3] = new CCar("Car  #2", 1200, 120, 2017, 0, 0, "Green");
            massTransport[4] = new CPlane("Plane#2", 520000, 900, 1990, 0, 0, 7000, 120);
            massTransport[5] = new CShip("Ship #1", 420000, 40, 2000, 0, 0, 700, "Kiyv 1");
            massTransport[6] = new CCar("Car  #4", 1300, 120, 2016, 0, 0, "Yellow");
            massTransport[7] = new CPlane("Plane#3", 530000, 1100, 2005, 0, 0, 8000, 280);
            massTransport[8] = new CShip("Ship #1", 430000, 30, 2014, 0, 0, 400, "Dnipro");
            massTransport[9] = new CCar("Car  #3", 1400, 130, 2015, 0, 0, "Blue");
            massTransport[10] = new CPlane("Plane#4", 550000, 1200, 2011, 0, 0, 4000, 100);
            massTransport[11] = new CShip("Ship #1", 460000, 70, 2017, 0, 0, 520, "Chernigov");
           
            

            Console.WriteLine("1. Найти транспортное стредство с наибольшой ценой");
            Console.WriteLine("2. Найти транспортное стредство от 2000 до 2005 года выпуска скорость выше 150км\час найменьшая цена");
            Console.WriteLine("3. Масив CShip не старше 5 лет");
            Console.WriteLine("4. Масив CShip не старше 5 лет сортировка по цене по убыванию");
            Console.WriteLine("5. Создаются 3 последовательности IFly, ISwim, IMove, упорядоченые по скорости");
            Console.WriteLine("Введите пункт меню");

            int MenuItem;
            int.TryParse(Console.ReadLine(), out MenuItem);
            CVehicle searchVehicle;
            CVehicle[] searchVehicles;
            Console.WriteLine("Результат поиска");
            switch (MenuItem)
            {
                case 1:
                    searchVehicle = massTransport[0];
                    foreach (var item in massTransport)
                    {
                        if (item.Cost > searchVehicle.Cost)
                        {
                            searchVehicle = item;
                        }
                    }
                    Console.WriteLine(searchVehicle.ToString());

                    break;
                case 2:
                    MySearch.VehicleYear(massTransport, 2005, 2000, out searchVehicles);
                    MySearch.VehicleSpeed(massTransport, 100000, 150, out searchVehicles);
                    searchVehicle = searchVehicles[0];
                    foreach (var item in searchVehicles)
                    {
                        if (item.Cost < searchVehicle.Cost)
                        {
                            searchVehicle = item;
                        }
                    }
                    Console.WriteLine(searchVehicle.ToString());
                    break;
                case 3:
                    CCar[] cCars = new CCar[0];
                    foreach (var item in massTransport)
                    {
                        if (item is CCar && (System.DateTime.Now.Year-item.YearMake)<5)
                        {
                            Array.Resize(ref cCars, cCars.Length + 1);
                            cCars[cCars.Length - 1] = (CCar)item;
                        }
                    }

                    foreach (var item in cCars)
                    {
                        Console.WriteLine(cCars.ToString());
                    }
                    break;

                case 4:
                    CShip[] cShips = new CShip[0];
                    foreach (var item in massTransport)
                    {
                        if (item is CShip && (System.DateTime.Now.Year - item.YearMake) < 5)
                        {
                            Array.Resize(ref cShips, cShips.Length + 1);
                            cShips[cShips.Length - 1] = (CShip)item;
                        }
                    }

                    Array.Sort(cShips);

                    foreach (var item in cShips)
                    {
                        Console.WriteLine(cShips.ToString());
                    }
                    break;
                case 5:
                    IFly[] flys = new IFly[0];
                    ISwim[] swims = new ISwim[0];
                    IMove[] moves = new IMove[0];

                    foreach (var item in massTransport)
                    {
                        if (item is IFly)
                        {
                            Array.Resize(ref flys, flys.Length + 1);
                            flys[flys.Length - 1] = (IFly)item;
                        }

                        if (item is ISwim)
                        {
                            Array.Resize(ref swims, swims.Length + 1);
                            swims[swims.Length - 1] = (ISwim)item;
                        }
                        if (item is IMove)
                        {
                            Array.Resize(ref moves, moves.Length + 1);
                            moves[moves.Length - 1] = (IMove)item;
                        }
                    }
                    Array.Sort((CVehicle[])flys, new CompareBySpeed());
                    Array.Sort((CVehicle[])swims, new CompareBySpeed());
                    Array.Sort((CVehicle[])moves, new CompareBySpeed());

                    foreach (var item in flys)
                    {
                        Console.WriteLine(((CVehicle)item).ToString());
                    }
                    foreach (var item in swims)
                    {
                        Console.WriteLine(((CVehicle)item).ToString());
                    }
                    foreach (var item in moves)
                    {
                        Console.WriteLine(((CVehicle)item).ToString());
                    }


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
