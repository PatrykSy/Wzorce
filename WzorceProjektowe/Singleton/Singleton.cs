using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    internal class Singleton
    {
        private static Singleton _instance;

        private readonly static object _instanceLock = new object();

        public static Singleton GetSingleton()
        {
            lock (_instanceLock)
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }
        private Singleton() { }

        public int x { get; set; }
        public int y { get; set; }
        public int Sum()
        { return x + y; }
    }
}
