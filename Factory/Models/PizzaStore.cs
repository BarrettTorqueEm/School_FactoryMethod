using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factory.Models
{
    public class PizzaStore
    {
        public Pizza CreatePizza(string pizzaType)
        {
            Pizza aPizza = null;
            PizzaFactory aPizzaFactory = new PizzaFactory();

            aPizza = aPizzaFactory.CreatePizza("Mushroom");

            return aPizza;
        }
    }
}