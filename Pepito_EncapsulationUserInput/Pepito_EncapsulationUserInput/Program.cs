using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_EncapsulationUserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //User Input Brand name of a shoe
            Console.Write("Enter Brand Name: ");
            string Brand = Console.ReadLine();
            //User input of the shoe size
            Console.Write("Enter Your Size: ");
            int Size = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("");

            //Intantiate A shoe object
            Shoe shoe1 = new Shoe();

            //Title
            Console.WriteLine("------Shoe Display------");
            shoe1.Brand = Brand;
            shoe1.Size = Size;

            //Display shoe details
            shoe1.DisplayShoeInfo();

            Console.ReadKey();
        }
    }
}
