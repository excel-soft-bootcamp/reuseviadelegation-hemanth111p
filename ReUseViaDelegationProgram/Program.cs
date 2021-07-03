using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReUseViaDelegation
{
    class Program
    {
        static void Main(string[] args)
        {
            Camera _camera = new Camera();
            GPS __gps = new GPS();
            Phone _phone = new Phone();

            SmartPhone _smartPhone = new SmartPhone();//Smartphone Should Deleagte Calls to  Camera, Gps,Phone
            _smartPhone.SetCamera(_camera);
            _smartPhone.SetNavigate(__gps);
            _smartPhone.SetPhone(_phone);
           

            //Substitute Camera with SmartPhone , GPS with SmartPhone , Phone With SamrtPhone
            PhotoGrapher _photoGrapher = new PhotoGrapher();
            _photoGrapher.Capture(_camera);
            _photoGrapher.Capture(_smartPhone);

            Traveller traveller = new Traveller();
            traveller.Hike(__gps);
            traveller.Hike(_smartPhone);

            Person person = new Person();
            person.Communicate(_phone);
            person.Communicate(_smartPhone);


        }
    }
}
