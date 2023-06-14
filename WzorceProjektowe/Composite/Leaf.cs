using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Leaf : Component
    {
        public Leaf(string name) : base(name)
        {
        }

        public override void Add(Component component)
        {
           
        }
        public override void Remove(Component component)
        {

        }
        public override void Print(int level)
        {
            Console.WriteLine("{0} {1}", new string('-', level + 1), this.Name);
        }
    }
}
