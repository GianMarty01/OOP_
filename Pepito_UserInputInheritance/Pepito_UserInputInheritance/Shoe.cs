using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_UserInputInheritance
{
   class Shoe      // Base class
{
    private string brand;      //Fields
    private int size;

    public Shoe(string aBrand, int aSize)  //Parametarized constructor
    {
        brand = aBrand;     //Setting up a field
        size = aSize;
    }

    public void ShoeInfo()  //Method to call the basic info of the shoe
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Size: " + size);
    }
}
class Casual : Shoe         //Derived Class
{
    public string type;      //Fields
    public string color;

    public Casual(string aBrand, int aSize, string bType, string bColor) : base(aBrand, aSize)  //Parametarized constructor
    {
        type = bType;     //Setting up a field
        color = bColor;
    }

    public void CasualShoeDetails()      //Method to call the Casual shoe
    {
        ShoeInfo();     // Inheriting the  base class
        Console.WriteLine("Type: " + type);
        Console.WriteLine("Color: " + color);
    }
}
class Sports : Shoe       //Derived class
{
    public string Traction;      //Fields
    public string style;

    public Sports(string aBrand, int aSize, string aTraction, string aStyle) : base(aBrand, aSize) //Parametarized constructor
    {
        Traction = aTraction;     //Setting up a field
        style = aStyle;
    }

    public void SportShoeDetails()      //Method to call the formal shoe
    {
        ShoeInfo();   // Inheriting the  base class
        Console.WriteLine("Traction: " + Traction);
        Console.WriteLine("Style: " + style);
    }
}
}
