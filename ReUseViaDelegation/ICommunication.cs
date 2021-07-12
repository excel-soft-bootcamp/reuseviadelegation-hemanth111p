using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
    public interface ICommunication
    {
        void Hangup();
        void Release();
    }
}
