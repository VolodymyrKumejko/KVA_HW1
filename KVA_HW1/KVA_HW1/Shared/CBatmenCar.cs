using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVA_HW1.Shared
{
    class CBatmenCar : CTerrapin, IFly, IMove, ISwim
    {
        public CBatmenCar(string name, int cost, int speed, int yearMake, int x, int y, string color, string homePort, int height) : base(name, cost, speed, yearMake, x, y, color, homePort)
        {
            this.Height = height;
        }

        public int Height { get; set; }
    }
}
