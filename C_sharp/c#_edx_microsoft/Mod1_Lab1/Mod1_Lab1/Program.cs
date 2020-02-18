using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod1_Lab1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // create variables of different data types
            // initialize with a "default" value
            string firstName = "";
            string lastName = "";
            int age = 0;
            string street = "";
            string city = "";
            string country = "";
            DateTime birthDate;

            // Assign values
            firstName = "Jose";
            lastName = "Marte";
            age = 50;
            street = "Cambronal 48 parte atras";
            city = "Santiago";
            country = "Mycountry";
            birthDate = new DateTime(1932, 6, 1);


            // output to the console

            // use simple output with variable name
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);

            //use placeholder style
            Console.WriteLine("{0} Years old. ", age);

            //use string concatenation
            Console.WriteLine(street + "," + city + "," + country);

            //use string interpolation
            Console.WriteLine($"Born on {birthDate}");

        }
    }
}
