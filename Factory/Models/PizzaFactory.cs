using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Models
{
    public class PizzaFactory
    {
        Pizza aPizza = null;

        public Pizza CreatePizza(string pizzaType)
        {
            if (pizzaType == "Cheese")
            {
                aPizza = new CheesePizza();
            }
            else if (pizzaType == "Pepperoni")
            {
                aPizza = new PepperoniPizza();
            }
            else if (pizzaType == "Veggie")
            {
                aPizza = new VeggiePizza();
            }
            else if (pizzaType == "MeatLovers")
            {
                aPizza = new MeatLoversPizza();
            }
            else if (pizzaType == "Mushroom")
            {
                aPizza = new MushroomPizza();
            }
            else
            {
                aPizza = new CheesePizza();
            }

            return aPizza;
        }
    }
}