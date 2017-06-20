using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class CheesePizza : Pizza
    {
        PizzaIngredientFactory pif = null;

        public CheesePizza(PizzaIngredientFactory pif)
        {
            this.Name = "CheesePizza";
            this.pif = pif;
        }

        public override void prepare()
        {
            Console.WriteLine("Preparing {0}", this.Name);
            this.dough = pif.createDough();
            this.sauce = pif.createSauce();
        }
    }
}
