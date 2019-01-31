using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Titan : ISmart
    {
        string name = "Titan";
        string ISmart.getName()
        {
            return name;
        }
    }
}
