using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
   
        public class Camera:ICamera
        {

            public void Click() {
            Console.WriteLine("Picture Captured");
        }
        public void TakePicture()
        {
            this.Click();
        }

        }

       
    
}
