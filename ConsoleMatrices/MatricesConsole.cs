using System;
using System.Collections.Generic;
using ClassLibraryMatrices;
using System.Diagnostics;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            Test(100, 10);
            Test(100, 25);
            Test(100, 50);
            Test(100, 100);
            Test(100, 250);
            Test(100, 500);
        }

        static void Test(int n, int b) {
            Console.WriteLine("----------------");
            Console.WriteLine(b);
            Stopwatch sw1 = Stopwatch.StartNew();
            Matrix a = new Matrix(n, n, new Random());
            Matrix c1 = Matrix.MatrixExponentiation(a, b);
            sw1.Stop();
            Console.WriteLine("Обычный алгоритм: " + sw1.ElapsedMilliseconds);
            Stopwatch sw2 = Stopwatch.StartNew();
            Matrix c2 = Matrix.MatrixExponentiation(a, b);
            sw2.Stop();
            Console.WriteLine("Быстрое возведения в степень: " + sw2.ElapsedMilliseconds);
        }
    }
}
