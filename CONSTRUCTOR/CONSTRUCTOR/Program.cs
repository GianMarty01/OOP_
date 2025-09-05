using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR
{
    class Program
{
    //Gian MArty Pepito
    //IT301
    //EXER_07: Simple Inheritance with Constructor

    static void Main(string[] args)
    {
        // Print regular student above student info
        Console.WriteLine("----Regular Student----");

        // Instantiate  an object to show the parametarized constructor
        RegularStudent student1 = new RegularStudent("IT301", "Gian Dumdum", "BSIT");

        // Display regular student info with inherited student student info
        student1.SectionEnrolled(); 

        Console.WriteLine();    // Spacing

        // Print irregular student above student info
        Console.WriteLine("----Irregular Student----");

        // Instantiate an object to show the parametarized constructor
        IrregularStudent Student2 = new IrregularStudent(20, "Aaron Ordeniza", "BSIT", "IT301");

        // Display irregular student info with inherited student info
        Student2.EnrolledSemUnits();

        Console.ReadKey();
    }
}
}
