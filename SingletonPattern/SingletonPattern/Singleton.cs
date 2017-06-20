using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    
    public class Singleton 
    {

        private Singleton() { }

        private static Singleton uniqueInstance = null;

        //解决了多线程带来的问题
        //类的静态构造函数在整个程序生命周期仅会被调用一次
        static Singleton()
        {
            uniqueInstance = new Singleton();
        }

        public static Singleton getInstance()
        {
            return uniqueInstance;
        }

    }
}
