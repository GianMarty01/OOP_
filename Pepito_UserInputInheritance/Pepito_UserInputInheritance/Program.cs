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
            string aBrand;      // Fields
            int aSize;
            Console.WriteLine("--Choose a Type of shoes--");      //Heading, a description which gives you idea to choose a shoe
            Console.WriteLine("----- Casual Shoes type type 'C', And for Formal Shoes type 'F' ");     //Type of shoe to choose
            string Type = Convert.ToString(Console.ReadLine());
            Console.Clear();
            if (Type == "C")   // Casual Shoe 
            {
                Console.WriteLine("----CASUAL SHOES----");
                string aType;
                string aColor;
                Console.Write("Input the Brand: ");
                aBrand = Convert.ToString(Console.ReadLine());
                Console.Write("Input the Size: ");
                aSize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the Type: ");
                aType = Convert.ToString(Console.ReadLine());
                Console.Write("Input the Color: ");
                aColor = Convert.ToString(Console.ReadLine());
                Console.Clear();
                Casual casualShoes = new Casual(aBrand, aSize, aType, aColor);

                Console.WriteLine("---Casual Shoes Info");
                casualShoes.CasualShoeDetails();
            }
            else if (Type == "F")
            {
                Console.WriteLine("----Formal Shoes----");
                string bCuttype;
                string bStyle;
                Console.Write("Input the Brand: ");
                aBrand = Convert.ToString(Console.ReadLine());
                Console.Write("Input the Size: ");
                aSize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the Cut Type: ");
                bCuttype = Convert.ToString(Console.ReadLine());
                Console.Write("Input the Style: ");
                bStyle = Convert.ToString(Console.ReadLine());
                Console.Clear();
                Formal boots = new Formal(aBrand, aSize, bCuttype, bStyle);

                Console.WriteLine("---Formal Shoes Info");
                boots.FormalShoeDetails();
            }
            else
            {
                Console.WriteLine("You Inputted a wrong letter. Please try again");
                return;
                
            }
            Console.ReadKey();
        }
    }
    
}
