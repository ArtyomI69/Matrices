using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMatrices {
    public class Matrix {
        public readonly int N;
        public readonly int M;
        private double[,] _data;

        public Matrix(int NColumn, int NRow) {
            N = NColumn;
            M = NRow;
            _data = CreateRandomMatrix();
        }

        public Matrix(double[,] data) {
            _data = data;
            N = data.GetLength(0);
            M = data.GetLength(1);
        }

        public ref double this[int row, int column] => ref _data[row, column];

        public static Matrix operator +(Matrix a, Matrix b) {
            bool isSameSize = a.N == b.N && a.M == b.M;
            if (!isSameSize) throw new Exception("Невозможно сложить матрицы не одинаковых размеров");

            Matrix c = new Matrix(a.N, b.M);
            for (int j = 0; j < b.M; j++) {
                for (int i = 0; i < a.N; i++) {
                    c[i, j] = a[i, j] + b[i, j];
                }
            }
            return c;
        }

        public static Matrix operator *(Matrix a, Matrix b) {
            bool isSameSize = a.N == b.N && a.M == b.M;
            if (!isSameSize) throw new Exception("Невозможно умножить матрицы не одинаковых размеров");

            Matrix c = new Matrix(a.N, b.M);
            for (int i = 0; i < c.N; i++) {
                for (int j = 0; j < c.M; j++) {
                    double s = 0.0;
                    for (int m = 0; m < a.M; m++) {
                        s += a[i, m] * b[m, j];
                    }
                    c[i, j] = s;
                }
            }
            return c;
        }

        public override string ToString() {
            string s = "";
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    s += ($"{_data[i, j]:0.000}\t");
                }
                s += ("\n");
            }
            return s;
        }

        private double[,] CreateRandomMatrix() {
            double[,] data = new double[N, M];
            Random rd = new Random();
            for (int j = 0; j < M; j++) {
                for (int i = 0; i < N; i++) {
                    data[i, j] = rd.Next(0, 9);
                }
            }

            return data;
        }
    }
}
