using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_SimpleInheritance
{
    //Gian Marty Pepito
    //IT301
    //EXER_06: Simple Inheritance

    internal class Program
    {
        static void Main(string[] args)
        {
            //Instantiate an object
            Student student = new Student();
            student.Name = "Gian Marty Pepito";
            student.Program = "BSIT";

            //Instantiate an object of regular student
            RegularStudent regularstudent = new RegularStudent();
            regularstudent.Section = "IT301";
            student.BasicINfo();                //Inherited Method
            regularstudent.SectionEnrolled();         //Method for Regular student class

            Console.WriteLine("");

            //Instantiate an object of irregular student
            IrregularStudent irregularstudent2 = new IrregularStudent();
            irregularstudent2.Name = "Aaron Ordeniza";
            irregularstudent2.Program = "BSIT";
            irregularstudent2.UnitsEnrolled = 20;
            irregularstudent2.BasicINfo();                //Inherited Method
            irregularstudent2.EnrolledSemUnits();        //Method for IrregularStudent class


            Console.ReadKey();
        }
    }
}
