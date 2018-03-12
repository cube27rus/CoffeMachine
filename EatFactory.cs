using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class EatFactory 
    {
        public string[] MakeFood(String eatName, Boolean withHam, Boolean withCheese, Boolean withJam)
        {
            string[] descAndCost = new string[2];
            Eat eat = null;
            Boolean needHam =  withHam;
            Boolean needCheese =  withCheese;
            Boolean needJam = withJam;
            switch (eatName)
            {                
                case "Bread":
                    eat = new Bread();
                    break;
                case "Bun":
                    eat = new Bun();
                    break;
                case "Chips":
                    eat = new Chips();
                    break;
                case "Cookie":
                    eat = new Cookie();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }

            if (needHam) { eat = new Ham(eat); }

            if (needCheese) { eat = new Cheese(eat); }

            if (needJam) { eat = new Jam(eat); }
            
            descAndCost[0] = eat.GetDescription();
            descAndCost[1] = eat.GetCost().ToString();
            return descAndCost;
        }
    }
}
