using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public class CheesePizza : Pizza
    {
        public override string Prepare()
        {
            return "Making custom cheese pizza.";
        }
    }

    public class PepperoniPizza : Pizza
    {
        public override string Prepare()
        {
            return "Making custom pepperoni pizza.";
        }
    }

    public class VeggiePizza : Pizza
    {
        public override string Prepare()
        {
            return "Making custom Veggie pizza.";
        }
    }

    public class MeatLoversPizza : Pizza
    {
        public override string Prepare()
        {
            return "Making custom MeatLovers pizza.";
        }
    }

    public class MushroomPizza : Pizza
    {
        public override string Prepare()
        {
            return "Makeing custom Mushroom pizza.";
        }
    }
}
