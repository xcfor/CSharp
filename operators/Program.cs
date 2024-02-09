using System;

namespace Operators
{
    internal class Program
    {
        // Main is the entry point for C# programs - this is a void function so no return
        static void Main(string[] args)
        {
            // Declaring some basic value type variables
            int x = 10, y = 5; // can declare multiple vars per line, if desired
            string a = "abcd", b = "efgh";

            // Basic mathematics operators include +, -, /, *
            Console.WriteLine("-- Basic maths -- ");
            Console.WriteLine((x / y) * x);
            Console.WriteLine(a + b);  // this is concatenating two strings using the + operator

            // Increment and decrement shorthand operators
            Console.WriteLine("-- Shorthand -- ");
            x++;
            y--;
            Console.WriteLine("x: {0}\ny: {1}", x, y);

            a += b;
            Console.WriteLine("a: {0}", a);

            // Logical operators (making decisions and checking conditions)
            Console.WriteLine("-- Logic operators -- ");

            Console.WriteLine(x > y && y >= 5);  // will return true if the conditions are satisfied, otherwise false
            Console.WriteLine(x > y || y >= 5);

            Console.WriteLine("-- Null-coalescing operators -- ");
            string str = null;
            //The ?? operator uses the left operand if NOT null or the right operand if it IS null

            Console.WriteLine(str ?? "Some other string");


        }
    }
}