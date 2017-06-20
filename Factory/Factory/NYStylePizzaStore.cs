using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class NYStylePizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            if (type == "cheese")
            {
                pizza = new NYStyleCheesePizza();
            }
            else if (type == "greek")
            {
                pizza = new NYStyleGreekPizza();
            }
            return pizza;
        }
    }
}
