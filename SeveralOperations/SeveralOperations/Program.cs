/*
 * Write a C# program to print on screen the result of
 * adding, subtracting, multiplying and dividing two numbers typed by the user.
 * The remainder of the division must be displayed, too.
 */
using System;

namespace SeveralOperations
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number1, number2,sum,subtract,multiply,divide,mod;

            Console.Write("Enter a number: ");
            number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            number2 = Convert.ToInt32(Console.ReadLine());
            sum = number1 + number2;
            subtract = number1 - number2;
            multiply = number1 * number2;
            divide = number1 / number2;
            mod = number1 % number2;

            //Console.WriteLine("{0 }+{1 }={2}", number1,number2,number1+number2);
            Console.WriteLine("{0}+{1}={2}", number1, number2, sum);
            Console.WriteLine("{0}-{1}={2}", number1, number2, subtract);
            Console.WriteLine("{0}X{1}={2}", number1, number2, multiply);
            Console.WriteLine("{0}/{1}={2}", number1, number2, divide);
            Console.WriteLine("{0}-{1}={2}", number1, number2, mod);



        }
    }
}
