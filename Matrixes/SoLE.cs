using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMatrices {
    public class SoLE {
        #region Поля
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
        #endregion

        #region Конструктор
        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="a">матрица А, предсавляющая коэффициенты</param>
        /// <param name="b">матрица B, предсавляющая свободные коэффициенты</param>
        /// <exception cref="Exception">если матрица А не квадратная или кол-во свободных элементов меньше чем кол-во уравнений</exception>
        public SoLE(Matrix a, Matrix b) {
            if (!a.IsSquare() || a.M != b.M) throw new Exception();

            A = a;
            B = b;
        }
        #endregion

        #region Public методы
        /// <summary>
        /// Решение системы линейных алгебраических уравнений
        /// </summary>
        /// <returns>лист элементов, представляющих ответы</returns>
        /// <exception cref="Exception">если невозможно решить СЛАУ</exception>
        public List<double> Solution() {
            List<double> result = new List<double>();
            double mainDeterminant = A.Determinant();
            double[] determinants = CalculateDeterminants();

            if (mainDeterminant == 0) {
                if (AreDeterminantsEqualZero(determinants)) throw new Exception("Система уравнений не определена");
                else throw new Exception("Система уравнений несовместима");
            }

            for (int i = 0; i < N; i++) {
                result.Add(determinants[i] / mainDeterminant);
            }
            return result;
        }

        /// <summary>
        /// Конвертация системы линейных алгебраических уравнений в строку
        /// </summary>
        /// <returns>строка</returns>
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
        #endregion

        #region Private методы
        /// <summary>
        /// Проверяет если все элементы в ряду равны 0
        /// </summary>
        /// <param name="row">строка</param>
        /// <returns>True - если все элементы в ряду равны 0, False - хотябы 1 элемент не равен 0</returns>
        private bool AreAllCoefInRowEqualZero(int row) {
            for (int i = 0; i < N; i++) {
                if (A[i, row] != 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Проверяет если элементы до определённой позиции в ряду равны 0
        /// </summary>
        /// <param name="row">строка</param>
        /// <param name="column">столбец</param>
        /// <returns>True - если все элементы до данной позиции равны 0, False - хотябы 1 элемент не равен 0</returns>
        private bool AreCoefBeforeEqualZero(int row, int column) {
            for (int i = 0; i < column; i++) {
                if (A[i, row] != 0) return false;
            }
            return true;
        }

        /// <summary>
        /// Вычисление определителей
        /// </summary>
        /// <returns>массив определителей</returns>
        private double[] CalculateDeterminants() {
            double[] determinants = new double[N];
            for (int j = 0; j < N; j++) {
                Matrix T = A.Clone() as Matrix;
                for (int i = 0; i < N; i++) {
                    T[j, i] = B[0, i];
                }
                determinants[j] = T.Determinant();
            }
            return determinants;
        }

        /// <summary>
        /// Проверяет если все определители равны 0
        /// </summary>
        /// <param name="determinants">массив определителей</param>
        /// <returns>True - если все элементы в ряду равны 0, False - хотябы 1 элемент не равен 0</returns>
        private bool AreDeterminantsEqualZero(double[] determinants) {
            foreach (double determinant in determinants) {
                if (determinant != 0) return false;
            }
            return true;
        }
        #endregion
    }
}
