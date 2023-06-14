using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    sealed class Adaptee
    {
        public void SpecificAction()
        {
            Console.WriteLine("Metoda SpecificAction w klasie Adaptee");
        }
    }
}
