using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
    class Phone:ICommunication
    {
        public void Hangup() { Console.WriteLine("Phone Hangup Done"); }
        public void Release() { Console.WriteLine("Phone Release Done"); }
    }
}
