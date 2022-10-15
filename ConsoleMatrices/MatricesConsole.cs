using System;
using System.Collections.Generic;
using ClassLibraryMatrices;

namespace ConsoleMatrices {
    internal class MatricesConsole {
        static void Main(string[] args) {
            Matrix a = new Matrix(3, 3, new Random());
            Matrix b = new Matrix(1, 3, new Random());

            SoLE test = new SoLE(a, b);

            Console.WriteLine(test);
            List<double> solution = test.Solve();
            int N = solution.Count;
            for (int i = 0; i < N; i++) {
                Console.WriteLine($"x{i + 1}: {solution[i]}");
            }
        }
    }
}
