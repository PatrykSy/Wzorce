using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    internal class RequestHandler3 : Handler
    {
        public override void HandleRequest(int i)
        {
            if (i >= 100 && i < 1000)
            {
                Console.WriteLine("Request handled by RequestHandler 3");
            }
            else
            {
                Console.WriteLine("Request cannot be handled");
            }
        }
    }
}
