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

        public void phoneTypeChecker(Manufacturers manu)
        {
            if (manu == Manufacturers.HTC)
            {
                HTCFactory H = new HTCFactory();
                factory = H;
                CheckProducts(factory);
            }
            else if (manu == Manufacturers.Nokia)
            {
                NokiaFactory N = new NokiaFactory();
                factory = N;
                CheckProducts(factory);
            }
            else if (manu == Manufacturers.Samsung)
            {
                SamsungFactory S = new SamsungFactory();
                factory = S;
                CheckProducts(factory);
            }
            void CheckProducts(IPhoneFactory factory)
            {
                factory.GetSmart();
                factory.GetDumb();
            }
        }

    }
}
