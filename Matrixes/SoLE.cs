using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMatrices {
    public class SoLE {
        /// <summary>
        /// Коэффициенты линейных уравнений
        /// </summary>
        public Matrix A;

        /// <summary>
        /// Кол-во линейных уравнений в системе
        /// </summary>
        public int N => A.N;

        /// <summary>
        /// Свободные коэффициенты линейных уравнений
        /// </summary>
        public Matrix B;

        public SoLE(Matrix a, Matrix b) {
            if (!a.IsSquare() || a.M != b.M) throw new Exception();

            A = a;
            B = b;
        }

        public override string ToString() {
            string s = "";
            for (int j = 0; j < N; j++) {
                if (AreAllCoefInRowEqualZero(j)) {
                    s += "0 ";
                    s += ($"= {B[0, j]}");
                    s += "\n";
                    continue;
                }
                for (int i = 0; i < N; i++) {
                    if (i == 0 || AreCoefBeforeEqualZero(j, i)) {
                        if (Math.Abs(A[i, j]) == 1) {
                            s += $"{(A[i, j] > 0 ? "" : "-")}x{i + 1} ";
                        } else if (A[i, j] > 0) {
                            s += $"{Math.Abs(A[i, j])}*x{i + 1} ";
                        } else if (A[i, j] < 0) {
                            s += $"-{Math.Abs(A[i, j])}*x{i + 1} ";
                        }
                    } else if (A[i, j] > 0) {
                        if (A[i, j] != 1) {
                            s += $"+ {Math.Abs(A[i, j])}*x{i + 1} ";
                        } else {
                            s += $"+ x{i + 1} ";
                        }
                    } else if (A[i, j] < 0) {
                        if (A[i, j] != -1) {
                            s += $"- {Math.Abs(A[i, j])}*x{i + 1} ";
                        } else {
                            s += $"- x{i + 1} ";
                        }
                    }
                }
                s += $"= {B[0, j]}";
                s += "\n";
            }
            return s;
        }

        private bool AreAllCoefInRowEqualZero(int row) {
            for (int i = 0; i < N; i++) {
                if (A[i, row] != 0) return false;
            }
            return true;
        }

        private bool AreCoefBeforeEqualZero(int row, int column) {
            for (int i = 0; i < column; i++) {
                if (A[i, row] != 0) return false;
            }
            return true;
        }
    }
}
