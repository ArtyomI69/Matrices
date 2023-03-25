using System;
using System.Collections.Generic;
using ClassLibraryMatrices;
using System.Diagnostics;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            Stopwatch sw = Stopwatch.StartNew();
            Matrix a = new Matrix(500, 500, new Random());
            Matrix b = new Matrix(500, 500, new Random());
            Matrix c = a * b;
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
