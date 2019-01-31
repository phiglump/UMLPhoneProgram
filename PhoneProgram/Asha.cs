using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Asha : IDumb
    {
        
        string IDumb.getName()
        {
            string name = "Asha";
            Console.WriteLine("Dumb Phone: " + name);
            return name;
        }
    }
}
