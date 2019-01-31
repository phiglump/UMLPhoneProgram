using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Lumia : ISmart
    {
        
        string ISmart.getName()
        {
            string name = "Lumia";
            Console.WriteLine("Smart Phone: " + name);
            return name;
        }
    }
}
