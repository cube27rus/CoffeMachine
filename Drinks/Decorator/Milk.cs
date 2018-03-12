using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Milk : CoffeDecorator
    {
        String name = " Milk ";

        public int cost = 10;
        Drink coffe;

        public Milk(Drink coffe)
        {
            this.coffe = coffe;
        }

        
        public override int GetCost()
        {
            return cost + coffe.GetCost();
        }

        public override string GetDescription()
        {
            return name + coffe.GetDescription();
        }
    }
}
