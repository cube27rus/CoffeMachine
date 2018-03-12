using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class Jam : EatDecorator
    {
        String name = " Jam ";
        Eat eat;

        public int cost = 20;

        public Jam(Eat eat)
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
