using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza createPizza(string type)
        {
            Pizza pizza = null;
            if (type == "cheese")
            {
                pizza = new ChicagoStyleCheesePizza();
            }
            else if (type == "greek")
            {
                pizza = new ChicagoStyleGreekPizza();
            }
            return pizza;
        }

    }
}
