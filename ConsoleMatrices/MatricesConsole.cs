using System;
using ClassLibraryMatrices;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            Matrix a = new Matrix(4, 4, new Random());
            Matrix b = new Matrix(1, 4, new Random());

            SoLE test = new SoLE(a, b);
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(test);
        }
    }
}
