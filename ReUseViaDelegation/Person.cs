using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
    class Person
    {
        public void Communicate(ICommunication _Phone)
        {
            
            _Phone.Hangup();
            _Phone.Release();
        }
    }
}
