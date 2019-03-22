using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVA_HW1.Shared
{
    public abstract class CVehicle
    {
        public string Name { get; set; }
        public int Cost { set; get; }
        public int Speed { set; get; }
        public int YearMake { set; get; }
        public int X { set; get; }
        public int Y { set; get; }

        public CVehicle(string name, int cost, int speed, int yearMake, int x, int y)
        {
            Name = name;
            Cost = cost;
            Speed = speed;
            YearMake = yearMake;
            X = x;
            Y = y;
        }


       

        public override string ToString()
        {
            return "Тр.ср.-" + Name + "; Цена-" + Cost + "; Скорость-" + Speed + "; Год вып.-" + YearMake + "; Коор-ты-" + Y + "," + X;
        }


    }
}
