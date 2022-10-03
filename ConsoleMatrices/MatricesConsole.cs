using System;
using ClassLibraryMatrices;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            //Matrix a = new Matrix(4, 3);
            //Console.Write(a.ToString());
            //Console.WriteLine();
            Matrix a = new Matrix(4, 4, new Random());
            Console.WriteLine(a);
            Console.WriteLine(a ^ -2);
            Console.WriteLine(a);
        }
    }
}
