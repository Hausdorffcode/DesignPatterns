using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class SimplePizzaFactory
    {
        public Pizza createPizza(string type)
        {
            Pizza pizza = null;
            if (type == "cheese")
            {
                pizza = new CheesePizza();
            }
            else if (type == "greek")
            {
                pizza = new GreekPizza();
            }
            return pizza;
        }
    }
}
