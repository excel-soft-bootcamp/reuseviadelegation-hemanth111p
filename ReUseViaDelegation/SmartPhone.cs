using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
    class SmartPhone: ICamera,ICommunication, IGPS
    {
        ICamera _cameraRef;
        IGPS _navigateRef;
        ICommunication _phoneRef;

        public void SetCamera(ICamera CameraRef)
        {
            this._cameraRef = CameraRef;
        }
        public void SetNavigate(IGPS NavigateRef)
        {

            this._navigateRef = NavigateRef;
        }
        public void SetPhone(ICommunication PhoneRef)
        {
            this._phoneRef = PhoneRef;
        }
        public void Click() {  this._cameraRef.Click();  }
        public void Hangup() { this._phoneRef.Hangup(); }
        public void Release() { this._phoneRef.Release(); }
        public void Navigate() { this._navigateRef.Navigate(); }
        public void TakePicture() { this.Click(); }
    }
}
