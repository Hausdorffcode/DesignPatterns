using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore ps = new ChicagoStylePizzaStore();
            ps.orderPizza("cheese");
            Console.ReadKey();
        }
    }
}
