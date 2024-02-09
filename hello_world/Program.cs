// This file was auto-generate with the "dotnet new console" command from a terminal (uses the pwd dir name to generate the project name etc.)

// This is the .NET 6 and beyond default console app template (much simpler)

// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


//----------------------------

// This is the .NET 5 and previous default console app template

// using System;

// namespace HelloWorld // Note: actual namespace depends on the project name.
// {
//     internal class Program
//     {
//         // Main is the entry point for C# programs - this is a void function so no return
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//             Console.WriteLine("What is your name?");
//             string str = Console.ReadLine();

//             Console.WriteLine("Hello " + str);
//         }
//     }
// }

// use "dotnet run" in a terminal to compile and run this program


// n.b. a simple version of this is (no boilerplate - .NET 6 and beyond):
using System;

Console.WriteLine("Hello World!");
Console.WriteLine("What is your name?");
string str = Console.ReadLine();

Console.WriteLine("Hello " + str);