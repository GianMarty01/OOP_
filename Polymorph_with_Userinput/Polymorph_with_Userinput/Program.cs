using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph_with_Userinput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create objects
            Sport sport = new Sport("Adidas", 9, "Adizero Boston");
            Formal formal = new Formal("Louis Philippe", 10, "Leather");

            // Display Information
            sport.DisplayInfo();
            formal.DisplayInfo();

            Console.ReadKey();
        }
    }
}
