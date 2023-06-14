using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubSystem1
    {
        public void ShowPersonalInfo()
        {
            Console.WriteLine("Name");
            Console.WriteLine("Surname");
        }
        public void ShowAddress() 
        {
            Console.WriteLine("Lodz");
            Console.WriteLine("Poland");
        }
        public void ShowSpam()
        {
            Console.WriteLine("dasfsdfga");
            Console.WriteLine("fsrgdtgdf");
        }
    }
}
