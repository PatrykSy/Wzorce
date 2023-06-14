using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    class ConcreteSubject : Subject
    {
        private string name;

        public string Name {
            get => name;
            set 
            { 
                name = value;
                this.Notify();
            } 
        }
    }
}
