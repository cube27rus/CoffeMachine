using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    abstract class Drink : Food
    {
        public String description = " Coffe ";      
               
        public override abstract int GetCost();

        public override string GetDescription()
        {
            return description;
        }

    }
}
