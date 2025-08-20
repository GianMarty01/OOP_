using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_PropertiesAndEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Intantiate A shoe object
            Shoe shoe1 = new Shoe();

            //Setting Values of the properties
            shoe1.Brand = "Adidas";
            shoe1.Size = 9;

            //Display shoe details
            shoe1.DisplayShoeInfo();

            Console.ReadKey();
        }
    }
}
