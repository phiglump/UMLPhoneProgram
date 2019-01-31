using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class NokiaFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            ISmart newPhone = new Lumia();
            newPhone.getName();
            return newPhone;
        }

        IDumb IPhoneFactory.GetDumb()
        {
            IDumb newPhone = new Asha();
            newPhone.getName();
            return newPhone;
        }
    }
}
