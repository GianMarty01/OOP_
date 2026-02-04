using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance_with_UserInput
{
    class Student   // Base class
    {
        // Fields
        private string name;
        private string program;

        // Parameterized Constructor
        public Student(string aName, string aProgram)
        {
            name = aName;        // Set Name
            program = aProgram; // Set Program
        }

        public void BasicInfo() // Method to display student basic info
        {
            Console.WriteLine("Name: " + name);       // Show Name
            Console.WriteLine("Program: " + program); // Show Program
        }
    }

    class RegularStudent : Student   // Derived class
    {
        public string section; // Field

        // Parameterized Constructor
        public RegularStudent(string aSection, string aName, string aProgram)
            : base(aName, aProgram)
        {
            section = aSection; // Set section
        }

        public void SectionEnrolled() // Method to display regular student units
        {
            BasicInfo(); // Inheriting the student basic info || getting the name and program
            Console.WriteLine("Section: " + section); // Show Section
        }
    }

    class IrregularStudent : Student  // Derived class
    {
        public int unitsEnrolled; // Field

        // Parameterized Constructor
        public IrregularStudent(int aUnitsEnrolled, string aName, string aProgram, string aSection)
            : base(aName, aProgram)
        {
            unitsEnrolled = aUnitsEnrolled; // Set enrolled units
        }

        public void EnrolledUnits() // Method to display irregular student units
        {
            BasicInfo(); // Inheriting the student basic info || getting the name and program
            Console.WriteLine("Units Enrolled: " + unitsEnrolled); // Show Units enrolled
        }
    }
}
