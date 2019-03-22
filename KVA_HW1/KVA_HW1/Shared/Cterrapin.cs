using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KVA_HW1.Shared
{
    class CTerrapin : CCar, IMove, ISwim
    {
        public CTerrapin(string name, int cost, int speed, int yearMake, int x, int y, string color, string homePort) : base(name, cost, speed, yearMake, x, y, color)
        {
            this.HomePort = homePort;
        }

        public string HomePort { get ; set ; }
    }
}
