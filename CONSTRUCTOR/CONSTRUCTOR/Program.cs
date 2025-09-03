using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CONSTRUCTOR
{
    class Program
    {
        static void Main(string[] args)
        {
            //Student student1 = new Student("Gian", "BSIT");
            //student1.DisplayStudentBasicinfo();
            Console.WriteLine("----Regular Student----");
            RegularStudent student1 = new RegularStudent("IT301", "Gian Dumdum", "BSIT");
            student1.RegularStudentSection();

            Console.WriteLine();

            Console.WriteLine("----Irregular Student----");
            IrregularStudent Student2 = new IrregularStudent(20, "Aaron Ordeniza", "BSIT", "IT301");
            Student2.IrregularStudentUnits();


        }
    }
}
