using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pepito_EncapsulationUserInput
{
    class Shoe
    {
        //Gian Marty Pepito
        //IT301
        //Basics on Encapsulation

        //Variables and fields
        private string brand;
        private int size;

        //Making the public properties for the fields
        public string Brand
        {
            get { return brand; }
            set { brand = value; }

        }

        public int Size
        {
            get { return size; }
            set { size = value; }

        }

        //Method to display the shoe
        public void DisplayShoeInfo()
        {
            Console.WriteLine($"Brand: {Brand} \nSize: {Size}");
        }
    }
}
