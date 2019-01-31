using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class SamsungFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            ISmart newPhone = new GalaxyS2();
            newPhone.getName();
            return newPhone;
        }

        IDumb IPhoneFactory.GetDumb()
        {
            IDumb newPhone = new Genie();
            newPhone.getName();
            return newPhone;
        }
    }
}
