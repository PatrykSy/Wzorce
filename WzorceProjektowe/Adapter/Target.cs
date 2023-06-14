
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class Target
    {
        public virtual void Action()
        {
            Console.WriteLine("Metoda Action w klasie Target");
        }
    }
}
