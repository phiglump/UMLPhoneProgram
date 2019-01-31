using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Genie : IDumb
    {
        
        string IDumb.getName()
        {
            string name = "Genie";
            Console.WriteLine("Dumb Phone: " + name);
            return name;
        }
    }
}
