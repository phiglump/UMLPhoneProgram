﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Titan : ISmart
    {
        
        string ISmart.getName()
        {
            string name = "Titan";
            Console.WriteLine("Smart Phone: " + name);
            return name;
        }
    }
}
