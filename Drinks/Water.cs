using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Water : Drink
    {

        public Water()
        {
            description = " Water ";
        }


        public int cost = 10;

        public override int GetCost()
        {
            return cost;
        }

    }
}
