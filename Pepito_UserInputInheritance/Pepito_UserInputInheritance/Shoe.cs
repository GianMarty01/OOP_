using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_UserInputInheritance
{
    class Shoe      // Base class
    {
        private string brand;
        private double size;

        public Shoe (string sBrand, double sSize)
        {
            brand = sBrand;
            size = sSize;
        }

        public void ShoeDetails ()
        {
            Console.WriteLine("Brand: " + brand);
            Console.WriteLine("Price: " + size);
        }
    }
    class CasualShoes : Shoe
    {
        public string type;
        public string color;

        public CasualShoes(string sBrand, double sPrice, string sType, string sColor) : base(sBrand, sPrice)
        {
            type = sType; 
            color = sColor;
        }

        public void CasualShoesDetails()
        {
            ShoeDetails();
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Size: " + color);
        }
    }
    class Boots : Shoe
    {
        public string cuttype;
        public string style;

        public Boots(string sBrand, double sPrice, string sCuttype, string sStyle) : base(sBrand, sPrice)
        {
            cuttype = sCuttype;
            style = sStyle;
        }

        public void BootsDetails()
        {
            ShoeDetails();
            Console.WriteLine("Type: " + cuttype);
            Console.WriteLine("Size: " + style);
        }
    }
}
