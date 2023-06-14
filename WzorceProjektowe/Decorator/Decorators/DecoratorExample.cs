using Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    internal class DecoratorExample : Decorator
    {
        public DecoratorExample(IComponent component) : base(component)
        {
        }

        public override void Action()
        {
            Console.WriteLine(new string('-', 20));
            base.Action();
            Console.WriteLine(new string('-', 20));
        }
    }
}
