using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Bread : Eat
    {
        

        public int cost = 20;

        public Bread()
        {
            description = " Bread ";
        }

        public override int GetCost()
        {

            return cost;

        }
    }
}
