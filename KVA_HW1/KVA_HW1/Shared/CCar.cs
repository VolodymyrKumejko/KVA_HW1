using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVA_HW1.Shared
{
    class CCar : CVehicle
    {
        public string Color { set; get; }

        public CCar(string name, int cost, int speed, int yearMake, int x, int y, string color) : base(name, cost, speed, yearMake, x, y)
        {
            Color = color;
        }
    }
}
