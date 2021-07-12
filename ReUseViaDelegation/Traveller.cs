using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
    class Traveller
    {
        public void Hike(IGPS _navigate)
        {

            _navigate.Navigate();
        }
    }
}
