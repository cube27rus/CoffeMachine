using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class GreenTea : Drink
    {

        public GreenTea()
        {
            description = " GreenTea ";
        }


        public int cost = 30;

        public override int GetCost()
        {
            return cost;
        }

    }
}
