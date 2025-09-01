using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_SimpleInheritance
{
    class Student      //Base Class
    {
        public string Name { get; set; }        //Properties
        public string Program { get; set; }

        public void BasicINfo()         //Method for Student class
        {
            Console.WriteLine("Name: " + Name  );
            Console.WriteLine("Program: " + Program);
        }
    }

    class RegularStudent : Student      //Derived Class
    {
        public string Section { get; set; }        //Properties

        public void SectionEnrolled()         //Method for Regular student class
        {
            Console.WriteLine("SectionEnrolled: " + Section);
        }
    }

    class IrregularStudent : Student        
    {
        public int UnitsEnrolled { get; set; }        //Properties

        public void EnrolledSemUnits()         //Method for IrregularStudent class
        {
            Console.WriteLine("EnrolledSemUnits: " + UnitsEnrolled);
        }
    }
}
