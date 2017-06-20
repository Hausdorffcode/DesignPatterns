using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class Pizza
    {
        string name;
        protected Dough dough;
        protected Sauce sauce;
        ArrayList toppings = new ArrayList();

        public abstract void prepare();

        public virtual void bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza");
        }

        public void box()
        {
            Console.WriteLine("Boxing the pizza");
        }

        protected string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
    }
}
