using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    internal class RequestHandler2 : Handler
    {
        public override void HandleRequest(int i)
        {
            if (i >= 10 && i < 100)
            {
                Console.WriteLine("Request handled by RequestHandler 2");
            }
            else if (this.Successor != null)
            {
                this.Successor.HandleRequest(i);
            }
        }
    }
}
