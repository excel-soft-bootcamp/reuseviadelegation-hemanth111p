using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
    class Phone:ICommunication
    {
        public void Hangup() { }
        public void Release() { }
    }
}
