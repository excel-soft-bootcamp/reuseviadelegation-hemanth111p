using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
    class PhotoGrapher
    {
        public void Capture(ICamera _camera)
        {
            
            _camera.Click();
        }
    }
}
