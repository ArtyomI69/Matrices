using System;
using ClassLibraryMatrices;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            Matrix a = new Matrix(4, 3);
            Console.Write(a.ToString());
            Console.WriteLine();
            Matrix b = new Matrix(4, 3);
            Console.Write(a.ToString());
            Console.WriteLine();
            Console.Write((a+b).ToString());
        }
    }
}
