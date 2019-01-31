using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Primo : IDumb
    {
        string name = "Primo";
        string IDumb.getName()
        {
            return name;
        }
    }
}
