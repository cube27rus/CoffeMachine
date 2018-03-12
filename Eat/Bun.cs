using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Bun : Eat
    {
       

        public int cost = 30;

        public Bun()
        {
            description = " Bun ";
        }

        public override int GetCost()
        {

            return cost;

        }
    }
}
