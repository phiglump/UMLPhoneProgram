using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class HTCFactory : IPhoneFactory
    {
        ISmart IPhoneFactory.GetSmart()
        {
            ISmart newPhone = new Titan();
            newPhone.getName();
            return newPhone;
        }

        IDumb IPhoneFactory.GetDumb()
        {
            IDumb newPhone = new Primo();
            newPhone.getName();
            return newPhone;
        }
    }
}
