using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Syrup : CoffeDecorator
    {
        String name = " Syrup ";
        Drink coffe;

        public int cost = 10;

        public Syrup(Drink coffe)
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
