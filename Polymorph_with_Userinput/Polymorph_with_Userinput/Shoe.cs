using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorph_with_Userinput
{
    class Shoe
    {
        public string Brand { get; set; } // public properties
        public double Size { get; set; }

        public Shoe(string brand, double size) // Parameterized constructor
        {
            Brand = brand;
            Size = size;
        }

        public virtual void DisplayInfo() // Virtual Method
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Size: {Size}");
        }
    }
    class Sport : Shoe // Derived class
    {
        public string Model { get; set; } // Properties
                                          // Parameterized constructor
        public Sport(string brand, double size, string model) : base(brand, size)
        {
            Model = model;
        }

        public override void DisplayInfo() // Override Method
        {
            Console.WriteLine("--- Sport Details ---");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Size: {Size}");
        }
    }
    class Formal : Shoe // Derived class
    {
        public string Type { get; set; } // Properties
                                         // Parameterized constructor
        public Formal(string brand, double size, string type) : base(brand, size)
        {
            Type = type;
        }

        public override void DisplayInfo() // Override Method
        {
            Console.WriteLine("--- Formal Shoe details ---");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Type: {Type}");
            Console.WriteLine($"Size: {Size}");
        }
    }
}
