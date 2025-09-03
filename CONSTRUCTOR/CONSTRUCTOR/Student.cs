using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CONSTRUCTOR
{
    class Student
    {
        private string name;
        private string program;

        public Student(string aName, string aProgram)
        {
            name = aName;
            program = aProgram;
        }

        public void DisplayStudentBasicinfo()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Program: " + program);
        }

    }
    class RegularStudent : Student
    {
        public string Section;
        public RegularStudent(string aSection, string aName, string aProgram) : base(aName, aProgram)
        {
            Section = aSection;
        }
        public void RegularStudentSection()
        {
            DisplayStudentBasicinfo();
            Console.WriteLine("Section: " + Section);
        }
    }
    class IrregularStudent : Student
    {
        public int UnitsEnrolled;
        public IrregularStudent(int aUnitsEnrolled, string aName, string aProgram, string aSection) : base(aName, aProgram)
        {
            UnitsEnrolled = aUnitsEnrolled;
        }
        public void IrregularStudentUnits()
        {
            DisplayStudentBasicinfo();
            Console.WriteLine("Units Enrolled: " + UnitsEnrolled);
        }

    }
}
