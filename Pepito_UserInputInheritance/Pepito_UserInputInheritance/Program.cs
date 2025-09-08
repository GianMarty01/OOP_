using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_UserInputInheritance
{
    class Program
    {
        //Gian Marty Pepito
        //IT301
        //Exer 8: 
        static void Main(string[] args)
        {
            Console.WriteLine("-----Enter Shoe info to display-----");
            Console.Write("Enter Brand Name: ");
            string Brand = Console.ReadLine();

            Console.Write("Enter Size: ");
            int Size = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Color: ");
            string Color = Console.ReadLine();


            //Intantiate A shoe object
            Shoe shoe1 = new Shoe();

            //Setting Values of the properties
            shoe1.Brand = Brand;
            shoe1.Size = Size;

            //Calling the method to Display shoe details
            shoe1.DisplayShoeInfo();

            Adidas style = new Adidas();

            style.Color = Color;

            style.DisplayShoeInfo();
            style.DisplayColor();

            Console.ReadKey();
        }
    }
}
