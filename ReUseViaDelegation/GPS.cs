using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
    class GPS:IGPS
    {
        public void Navigate() {
            Console.WriteLine("Navigation Done");
        }
    }
}
