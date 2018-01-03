using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Models
{
    public abstract class Pizza
    {
        public virtual string Prepare()
        {
            return "Standard preparation technique.";
        }

        public virtual string Bake()
        {
            return "Standard baking technique.";
        }

        public virtual string Cut()
        {
            return "Standard cutting technique.";
        }

        public virtual string Box()
        {
            return "Standard boxing technique.";
        }
    }
}
