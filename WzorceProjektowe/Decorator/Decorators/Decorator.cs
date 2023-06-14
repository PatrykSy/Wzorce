using Decorator.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Decorator.Decorators
{
    abstract class Decorator : IComponent
    {
        private Components.IComponent _component;

        public Decorator(IComponent component)
        {
            _component = component;
        }
        public virtual void Action()
        {
            if(_component != null)
            {
                _component.Action();
            }
        }
    }
}
