using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    internal class RequestHandler1 : Handler
    {
        public override void HandleRequest(int i)
        {
            if(i >= 0 && i < 10)
            {
                Console.WriteLine("Request handled by RequestHandler 1");
            }
            else if (this.Successor != null) 
            { 
                this.Successor.HandleRequest(i); 
            }
        }
    }
}
