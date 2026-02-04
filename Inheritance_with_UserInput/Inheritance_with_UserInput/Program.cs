using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_with_UserInput
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Print regular student above student info
            Console.WriteLine("-----Regular Student-----");

            // Instantiate an object to show the parameterized constructor
            RegularStudent student1 = new RegularStudent("IT301", "Gian Dandu", "BSIT");

            // Display regular student info with inherited student info
            student1.SectionEnrolled();

            Console.WriteLine(); // Spacing

            // Print irregular student above student info
            Console.WriteLine("-----Irregular Student-----");

            // Instantiate an object to show the parameterized constructor
            IrregularStudent student2 = new IrregularStudent(20, "Aaron Ordeniza", "BSIT", "IT301");

            // Display irregular student info with inherited student info
            student2.EnrolledUnits();

            Console.ReadKey();

        }
    }
}
