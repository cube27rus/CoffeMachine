using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Espresso : Drink
    {
        
        public Espresso()
        {
            description = " Espresso ";
        }
        

        public int cost = 50;

        public override int GetCost()
        {            
                return cost;            
        }
        
    }
}
