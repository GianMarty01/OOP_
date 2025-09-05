using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CONSTRUCTOR
{
     class Student    // Base class
 {
     // Fields
     private string name;
     private string program;
     //Parametarized Constructor 
     public Student(string aName, string aProgram)      
     {
         name = aName;       // Set Name
         program = aProgram;     //Set Program
     }

     public void Basicinfo()     // Method to display student basic info
     {
         Console.WriteLine("Name: " + name);     // Show Name
         Console.WriteLine("Program: " + program);       // Show Program
     }
 }
 class RegularStudent : Student     // Derived class
 {
     public string section;    // Field

     // Parametarized Constructor
     public RegularStudent(string aSection, string aName, string aProgram) : base(aName, aProgram)     
     {
         section = aSection;      // Set section
     }
     public void SectionEnrolled()       // Method to diplay Regular student units
     {  
         Basicinfo();    // Inheriting the student basic info || getting the name and program
         Console.WriteLine("Section: " + section);       //Show Section
     }
 }
 class IrregularStudent : Student      // Derived class
 {
     public int unitsEnrolled;       // Field

     //Parametarized Constructor
     public IrregularStudent(int aUnitsEnrolled, string aName, string aProgram, string aSection) : base(aName, aProgram) 
     {
         unitsEnrolled = aUnitsEnrolled;     // Set enrolled units
     }
     public void EnrolledSemUnits()      // Method to diplay Irregular student units
     {
         Basicinfo();    // Inheriting the student basic info || getting the name and program
         Console.WriteLine("Units Enrolled: " + unitsEnrolled);      // Show Units enrolled
     }

 }
}
