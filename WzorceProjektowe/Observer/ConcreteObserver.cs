using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    internal class ConcreteObserver : Observer
    {
        public override void Notify()
        {
            Console.WriteLine("Nastąpiła zmiana");
        }
    }
}
