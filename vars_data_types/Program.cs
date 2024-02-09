using System;

namespace VarsDataTypes
{
    internal class Program
    {
        // Main is the entry point for C# programs - this is a void function so no return
        static void Main(string[] args)
        {
            // Declaring some basic value type variables
            int i = 10;
            float f = 2.0f;
            decimal d = 10.0m;
            bool b = true;
            char c = 'c';

            //Declaring a string
            string str = "a string";

            //Declaring an implicit value (var will let the compiler figure out he data type e.g. int or string)
            var x = 10;
            var z = "Hello!";

            //Declaring an array of type int with a length of 5
            int[] vals = new int[5];

            string[] strs = { "one", "two", "three", "four" };

            //Using a formatting string
            Console.WriteLine("{0}, {1}, {2}, {3}, {4}, {5}, {6}, {7}", i, c, b, str, f, d, x, z);

            //null means no value in C#
            object obj = null;
            Console.WriteLine(obj);

            //Implicit conversion between types
            long bignum;
            bignum = i;   //we decleared i as an int earlier - it will be implictly converted

            //Explicit conversion between types
            float i_to_f = (float)i;   //here we are converting an int we declared earlier - i - to a float called i_to_f
            Console.WriteLine("{0}", i_to_f);


            int f_to_i = (int)f;    //here we are converting a float we declared earlier - f - to an int called f_to_i
            Console.WriteLine("{0}", f_to_i);

        }
    }
}