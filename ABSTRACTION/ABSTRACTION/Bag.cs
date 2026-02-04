using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTION
{

    abstract class Bag
    {

        public string Brand { get; set; } // Properties
        public string Color { get; set; }
        public double Price { get; set; }
        // Parameterized constructor
        public Bag(string brand, string color, double price)
        {
            Brand = brand;
            Color = color;
            Price = price;
        }
        // Abstract Methods
        public abstract void DisplayDetails();
        public abstract double CalculateDiscount(double percent);
        // Concrete
        public void Carry()
        {
            Console.WriteLine("Carrying the bag...");
        }

    }
    // Derived class
    class SchoolBag : Bag
    {
        public int NumberOfCompartments { get; set; } // Properties
                                                      // Parameterized Constructor
        public SchoolBag(string brand, string color, double price, int compartments) : base(brand, color, price)
        {
            NumberOfCompartments = compartments;
        }
        public override void DisplayDetails() // override  
        {
            Console.WriteLine("--- School Bag Details ---");
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Compartments: " + NumberOfCompartments);
        }

        public override double CalculateDiscount(double percent) // override  
        {
            double discount = Price * (percent / 100);
            double discountedPrice = Price - discount;
            Console.WriteLine("Discounted Price: " + discountedPrice);
            return discountedPrice;
        }


    }
    // Derived class: TravelBag
    class TravelBag : Bag
    {
        public double Capacity { get; set; }

        public TravelBag(string brand, string color, double price, double capacity)
            : base(brand, color, price)
        {
            Capacity = capacity;
        }

        public override void DisplayDetails()
        {
            Console.WriteLine("--- Travel Bag Details ---");
            Console.WriteLine("Brand: " + Brand);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Price: " + Price);
            Console.WriteLine("Capacity: " + Capacity);
        }

        public override double CalculateDiscount(double percent)
        {
            double discount = Price * (percent / 100);
            double discountedPrice = Price - discount;
            Console.WriteLine("Discounted Price: " + discountedPrice);
            return discountedPrice;
        }
    }
}