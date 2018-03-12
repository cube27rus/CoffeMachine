using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Cheese : EatDecorator
    {
        String name = " Cheese";
        Eat eat;

        public int cost = 20;

        public Cheese(Eat eat)
        {
            this.eat = eat;
        }

        public override int GetCost()
        {
            return eat.GetCost() + cost;
        }

        public override string GetDescription()
        {
            return name + eat.GetDescription();
        }
    }
}
