using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Lumia : ISmart
    {
        readonly string name = "Lumia";
        string ISmart.getName()
        {
            return name;
        }
    }
}
