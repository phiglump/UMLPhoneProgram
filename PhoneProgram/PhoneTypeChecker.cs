using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class PhoneTypeChecker
    {
        public IPhoneFactory factory;
        public Manufacturers manu;

        public phoneTypeChecker(Manufacturers manu)
        {
            Manufacturers phoneSamsung = Manufacturers.Samsung;
            Manufacturers phoneHTC = Manufacturers.HTC;
            Manufacturers phoneNokia = Manufacturers.Nokia;
            void CheckProducts()
            {
                factory.GetSmart();
                factory.GetDumb();
            }
        }
    }
}
