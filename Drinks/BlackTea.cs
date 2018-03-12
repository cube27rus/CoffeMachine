using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class BlackTea : Drink
    {

        public BlackTea()
        {
            description = " BlackTea ";
        }


        public int cost = 30;

        public override int GetCost()
        {
            return cost;
        }

    }
}
