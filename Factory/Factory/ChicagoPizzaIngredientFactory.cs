using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough()
        {
            return new ThickCrustDough();
        }

        public Sauce createSauce()
        {
            return new PlumTomatoSauce();
        }
    }
}
