using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class GalaxyS2 : ISmart
    {
        string name = "GalaxyS2";
        string ISmart.getName()
        {
            return name;
        }
    }
}
