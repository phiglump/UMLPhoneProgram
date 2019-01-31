using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Primo : IDumb
    {
        
        string IDumb.getName()
        {
            string name = "Primo";
            Console.WriteLine("Dumb Phone: " + name);
            return name;
        }

    }
}
