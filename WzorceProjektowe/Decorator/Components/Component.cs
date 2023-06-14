using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Components
{
    internal class Component : IComponent
    {
        public void Action()
        {
            Console.WriteLine("Akcja componentu");
        }
    }
}
