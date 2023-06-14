using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class Facade
    {
        private SubSystem1 subSystem1 = new SubSystem1();
        private SubSystem2 subSystem2 = new SubSystem2();

        public void ShowSubSystem1()
        {
            subSystem1.ShowPersonalInfo();
            subSystem1.ShowAddress();
            subSystem1.ShowSpam();
        }
        public void ShowSubSystem2()
        {
            subSystem2.ShowPersonalInfo();
            subSystem2.ShowAddress();
            subSystem2.ShowSpam();
        }
    }
}
