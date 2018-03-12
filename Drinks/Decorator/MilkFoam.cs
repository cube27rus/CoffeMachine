using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class MilkFoam : CoffeDecorator
    {
        String name = " MilkFoam ";
        Drink coffe;
        public int cost = 15;
        public MilkFoam(Drink coffe)
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
