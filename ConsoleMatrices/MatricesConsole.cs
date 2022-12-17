using System;
using System.Collections.Generic;
using ClassLibraryMatrices;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            //Matrix a = new Matrix(3, 4, new Random());
            //Matrix b = new Matrix(4, 3, new Random());

            //Console.WriteLine(a);
            //Console.WriteLine("------");
            //Console.WriteLine(b);
            //Console.WriteLine("------");
            //Console.WriteLine(a * b);
            double[,] n = { { 1, 0, 0 }, { 0, 1, 0 }, { 0, 0, 1} };
            var a = new Matrix(n);
            var b = new Matrix(3, true);
            Console.WriteLine(a);
            Console.WriteLine();
            Console.WriteLine(b);
        }
    }
}
