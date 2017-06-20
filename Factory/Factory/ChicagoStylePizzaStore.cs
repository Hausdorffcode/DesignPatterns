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
            PizzaIngredientFactory pif = new ChicagoPizzaIngredientFactory();

            if (type == "cheese")
            {
                pizza = new CheesePizza(pif);
            }
            else if (type == "greek")
            {
                pizza = new GreekPizza(pif);
            }
            return pizza;
        }

    }
}
