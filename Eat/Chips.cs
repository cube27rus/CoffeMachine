using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Chips : Eat
    {

        public int cost = 50;

        public Chips()
        {
            description = " Chips ";
        }

        public override int GetCost()
        {
            return cost;
        }

       
    }
}
