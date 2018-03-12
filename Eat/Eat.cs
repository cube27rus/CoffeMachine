using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    abstract class Eat : Food
    {
        public String description = " Eat ";
        
        public override abstract int GetCost();

        public override string GetDescription()
        {
            return description;
        }

    }
}
