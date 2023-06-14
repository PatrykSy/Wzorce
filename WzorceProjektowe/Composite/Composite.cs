using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Composite : Component
    {
        private List<Component> _components = new List<Component>();
        public Composite(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
            if(component != null)
            {
                _components.Add(component);
            }
        }
        public override void Remove(Component component)
        {
            if (component != null)
            {
                _components.Remove(component);
            }
        }
        public override void Print(int level)
        {
            Console.WriteLine("{0} {1}", new string('-', level), this.Name);
            _components.ForEach(component => component.Print(level + 1));
        }
    }
}
