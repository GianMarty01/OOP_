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
            string sBrand;
            double sSize;
            Console.WriteLine("***Choose to a Type of shoes***");
            Console.WriteLine("*** Casual Shoes or Boots ***");
            string Kind = Convert.ToString(Console.ReadLine());
            Console.Clear();
            if(Kind == "Casual Shoes")
            {
                Console.WriteLine("***CASUAL SHOES***");
                string sType, sColor;
                Console.Write("Input the Brand: ");
                sBrand = Convert.ToString(Console.ReadLine());
                Console.Write("Input the Size: ");
                sSize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the Type: ");
                sType = Convert.ToString(Console.ReadLine());
                Console.Write("Input the Color: ");
                sColor = Convert.ToString(Console.ReadLine());
                Console.Clear();
                CasualShoes casualShoes = new CasualShoes(sBrand, sSize, sType, sColor);
                
                casualShoes.CasualShoesDetails();
            }
            else if(Kind == "Boots") 
            {
                Console.WriteLine("***BOOTS***");
                string sCuttype, sStyle;
                Console.Write("Input the Brand: ");
                sBrand = Convert.ToString(Console.ReadLine());
                Console.Write("Input the Size: ");
                sSize = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input the Cut Type: ");
                sCuttype = Convert.ToString(Console.ReadLine());
                Console.Write("Input the Style: ");
                sStyle = Convert.ToString(Console.ReadLine());
                Console.Clear();
                Boots boots = new Boots(sBrand, sSize, sCuttype, sStyle);

                boots.BootsDetails();
            }
            Console.ReadKey();
        }
    }
}
