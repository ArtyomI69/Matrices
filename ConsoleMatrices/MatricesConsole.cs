using System;
using ClassLibraryMatrices;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            Matrix a = new Matrix(4, 4, new Random());
            Console.WriteLine(a);
            Console.WriteLine(a.Inverse());
            Console.WriteLine(a ^ -1);
        }
    }
}
