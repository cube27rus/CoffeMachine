using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Cookie : Eat
    {
        

        public int cost = 50;

        public Cookie()
        {
            description = " Cookie ";
        }

        public override int GetCost()
        {

            return cost;

        }
    }
}
