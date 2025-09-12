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
    //Exer_08:Inheritance with User Input
    static void Main(string[] args)
    {
    Begin:
        string aBrand;      // Variables
        int aSize;
        Console.WriteLine("--Choose a Type of shoes--");      //Heading, a description which gives you idea to choose a shoe
        Console.WriteLine("----- Casual Shoes type type 'C' or 'c', And for Formal Shoes type 'S' or 's' ");     //Type of shoe to choose
        string Type = Convert.ToString(Console.ReadLine());   //User input to input of the choosen shoe
        Console.Clear();    //Clear
        if (Type == "C" || Type == "c")  // Casual Shoe 
        {
            Console.WriteLine("----Casual Shoe----");      //Heading
            string aType;       // Variables
            string aColor;
            Console.Write("Input the Brand: ");         // to let a user input of the specified shoe of a Casual shoe
            aBrand = Convert.ToString(Console.ReadLine());
            Console.Write("Input the Size: ");
            aSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Type: ");
            aType = Convert.ToString(Console.ReadLine());
            Console.Write("Input the Color: ");
            aColor = Convert.ToString(Console.ReadLine());
            Console.Clear();    // Clear
            Casual casualShoes = new Casual(aBrand, aSize, aType, aColor);   ///Instantiate an object to call the method

            Console.WriteLine("----Casual Shoes Info----");
            casualShoes.CasualShoeDetails();    // With the inherited method inside
        }
        else if (Type == "S" || Type == "s")
        {
            Console.WriteLine("----Sport Shoe----");   //Heading
            string bTraction;    // Variables
            string bStyle;
            Console.Write("Input the Brand: ");         // to let a user input of the specified shoe of a Formal shoe
            aBrand = Convert.ToString(Console.ReadLine());
            Console.Write("Input the Size: ");
            aSize = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the Traction: ");
            bTraction = Convert.ToString(Console.ReadLine());
            Console.Write("Input the Style: ");
            bStyle = Convert.ToString(Console.ReadLine());
            Console.Clear();    // Clear

            Sports sport = new Sports(aBrand, aSize, bTraction, bStyle);     //Instantiate an object to call the method

            Console.WriteLine("----Sport Shoes Info----");
            sport.SportShoeDetails();   // With the inherited method inside
        }
        else 
        {
            
            Console.WriteLine("You Inputted a wrong letter. Please try again");
            Console.WriteLine("");

            goto Begin; // Return to the beginning to choose again.
        }
        Console.ReadKey();
    }
}
    
}
