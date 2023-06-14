using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    class ProductCreator : Factory
    {
        public override Product CreateProduct()
        {
            return new Product();
        }
    }
}
