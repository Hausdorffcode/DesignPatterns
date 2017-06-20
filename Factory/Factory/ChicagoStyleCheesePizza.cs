using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            this.Name = "ChicagoStyleCheesePizza";
        }

        public override void cut()
        {
            Console.WriteLine("Chicago Style Cut");
        }
    }
}
