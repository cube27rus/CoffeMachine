using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Sugar : CoffeDecorator
    {
        String name = " Sugar ";
        Drink coffe;

        public int cost = 3;

        public Sugar(Drink coffe)
        {
            this.coffe = coffe;
        }
               
        public override int GetCost()
        {
            return coffe.GetCost() + cost;
        }

        public override string GetDescription()
        {
            return name + coffe.GetDescription();
        }
    }
}
