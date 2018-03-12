using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class CoffeFactory
    {
        public string[] MakeFood(String coffeName,Boolean withMilk, Boolean withSyrup, Int32? sugar)
        {
            string[] descAndCost = new string[2];
            Drink drink = null;
            Boolean needMilk = withMilk;
            Boolean needSyrup = withSyrup;
            Int32? numOfSugar = sugar;
            switch (coffeName)
            {
                case "Water":
                    needMilk = false;
                    drink = new Water();
                    break;
                case "Espresso":
                    drink = new Espresso();
                    break;
                case "Latte":
                    drink = new Espresso();
                    drink = new Milk(drink);
                    drink = new MilkFoam(drink);                    
                    break;
                case "Cappuccino":
                    needMilk = false;
                    drink = new Espresso();
                    drink = new Milk(drink);

                    break;
                case "BlackTea":

                    drink = new BlackTea();
                    break;
                case "GreenTea":

                    drink = new GreenTea();
                    break;
                default:
                    Console.WriteLine("Default case");
                    break;
            }
            
            if (needMilk) { drink = new Milk(drink); }
           
            if (needSyrup) { drink = new Syrup(drink); }
            // сахарный цикл
            for (int i = 0; i < numOfSugar; i++)
            {
                drink = new Sugar(drink);
            }
            descAndCost[0] = drink.GetDescription();
            descAndCost[1] = drink.GetCost().ToString();
            return descAndCost;
        }
    }
}
