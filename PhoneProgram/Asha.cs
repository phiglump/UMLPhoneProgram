using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Asha : IDumb
    {
        string name = "Asha";
        string IDumb.getName()
        {
            return name;
        }
    }
}
