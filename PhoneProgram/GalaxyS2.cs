using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class GalaxyS2 : ISmart
    {
        
        string ISmart.getName()
        {
            string name = "GalaxyS2";
            Console.WriteLine("Smart Phone: " + name);
            return name;
        }
    }
}
