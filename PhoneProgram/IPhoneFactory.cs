using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    interface IPhoneFactory
    {
        ISmart GetSmart();
        IDumb GetDumb();
    }
}
