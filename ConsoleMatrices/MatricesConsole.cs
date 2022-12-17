using System;
using System.Collections.Generic;
using ClassLibraryMatrices;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            Matrix a = new Matrix(3, 4, new Random());
            Matrix b = new Matrix(4, 3, new Random());

            Console.WriteLine(a);
            Console.WriteLine("------");
            Console.WriteLine(b);
            Console.WriteLine("------");
            Console.WriteLine(a * b);
        }
    }
}
