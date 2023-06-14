using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilities
{
    abstract class Handler
    {
        protected Handler Successor;
        public void SetSuccessor(Handler handler)
        {
            this.Successor = handler;
        }
        public abstract void HandleRequest(int i);
    }
}
