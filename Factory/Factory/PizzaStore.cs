using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class PizzaStore
    {
        private SimplePizzaFactory spf;

        public PizzaStore(SimplePizzaFactory spf)
        {
            this.spf = spf;
        }

        public Pizza orderPizza(string type)
        {
            Pizza pizza = null;

            pizza = spf.createPizza(type);

            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();
            return pizza;
        }
    }
}
