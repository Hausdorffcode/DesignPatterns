using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class GreekPizza : Pizza
    {
        PizzaIngredientFactory pif = null;

        public GreekPizza(PizzaIngredientFactory pif)
        {
            this.Name = "GreekPizze";
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
