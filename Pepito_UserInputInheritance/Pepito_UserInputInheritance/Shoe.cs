using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_UserInputInheritance
{
    class Shoe      // Base class
    {
        //private Variables and fields
        private string brand;
        private int size;

        //Making the public properties for the fields
        public string Brand
        {
            get { return brand; }
            set { brand = value; }

        }

        public int Size
        {
            get { return size; }
            set { size = value; }

        }

        //Method to display the shoe
        public void DisplayShoeInfo()
        {
            Console.WriteLine("");
            Console.WriteLine("------Shoe Display------");
            Console.WriteLine($"Brand: {Brand} \nSize: {Size}");
        }
    }
    class Adidas : Shoe
    {
        private string color;
        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        public void DisplayColor()
        {
            DisplayShoeInfo();
            Console.WriteLine("Color: " + Color);
        }
    }
}
