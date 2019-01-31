using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Genie : IDumb
    {
        string name = "Genie";
        string IDumb.getName()
        {
            return name;
        }
    }
}
