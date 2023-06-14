using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class SubSystem2
    {
        public void ShowPersonalInfo()
        {
            Console.WriteLine("Patryk");
            Console.WriteLine("Sypula");
        }
        public void ShowAddress()
        {
            Console.WriteLine("Warszawa");
            Console.WriteLine("Poland");
        }
        public void ShowSpam()
        {
            Console.WriteLine("Test");
            Console.WriteLine("Testing");
        }
    }
}
