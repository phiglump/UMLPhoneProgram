using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            PhoneTypeChecker check = new PhoneTypeChecker();

            Manufacturers selection = new Manufacturers();
            string answer = "";
            Console.WriteLine("Please enter the phone you wanna see.");
            answer = Console.ReadLine();
            if (answer == "HTC")
            {
                selection = Manufacturers.HTC;
            }
            else if (answer == "Samsung")
            {
                selection = Manufacturers.Samsung;
            }
            else if (answer == "Nokia")
            {
                selection = Manufacturers.Nokia;
            }

            switch (selection) {
                case Manufacturers.HTC: 
                    check.phoneTypeChecker(selection);
                    break;
                case Manufacturers.Nokia:
                    check.phoneTypeChecker(selection);
                    break;
                case Manufacturers.Samsung:
                    check.phoneTypeChecker(selection);
                    break;
            }
            Console.ReadKey();
        }
    }
}