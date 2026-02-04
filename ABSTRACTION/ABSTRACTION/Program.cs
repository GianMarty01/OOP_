using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABSTRACTION
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creating objects of both derived classes
            SchoolBag sBag = new SchoolBag("Jansport", "Red", 1500, 3);
            TravelBag tBag = new TravelBag("Adidas", "Blue", 4500, 4);

    // Calling the inherited class  
            sBag.DisplayDetails();
            sBag.Carry();
            sBag.CalculateDiscount(10);

            // Calling the inherited class  
            tBag.DisplayDetails();
            tBag.Carry();
            tBag.CalculateDiscount(5);
        }

    }
}
