using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMatrices {
    public class Matrix : ICloneable {
        /// <summary>
        /// Двоичный массив, представляющий матрицу
        /// </summary>
        private double[,] _data;

        /// <summary>
        /// Кол-во столбцов матрицы
        /// </summary>
        public int N => _data.GetUpperBound(0) + 1;

        /// <summary>
        /// Кол-во рядов матрицы
        /// </summary>
        public int M => _data.GetUpperBound(1) + 1;

        /// <summary>
        /// Создаёт квадратную матрицу размера n
        /// </summary>
        /// <param name="n">размер матрицы</param>
        /// <param name="diagonal">если diagonal == true создаёт еденичную матрицу</param>
        public Matrix(int n, bool diagonal = false) {
            _data = new double[n, n];
            if (!diagonal) return;
            for (int i = 0; i < n; i++) {
                _data[i, i] = 1.0;
            }
        }

        /// <summary>
        /// Создаёт матрицу размерами n*m
        /// </summary>
        /// <param name="n">Кол-во столбцов</param>
        /// <param name="m">Кол-во строк</param>
        /// <param name="r">Если мы не передаём объект Random, создаёт нулевую матрицу</param>
        public Matrix(int n, int m, Random r = null) {
            _data = new double[n, m];
            if (r == null) return;
            for (int i = 0; i < n; i++) {
                for (int j = 0; j < m; j++) {
                    _data[i, j] = r.Next(0, 9);
                }
            }
        }

        /// <summary>
        /// Создаёт матрицу базируясь на двойном массиве
        /// </summary>
        /// <param name="data">двойной массив</param>
        public Matrix(double[,] data) {
            _data = data;
        }

        public ref double this[int row, int column] => ref _data[row, column];

        /// <summary>
        /// Операция сложения матриц
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">матрица b</param>
        /// <returns>новая матрица</returns>
        /// <exception cref="Exception">если матрицы не равны</exception>
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

        /// <summary>
        /// Операция вычитания матриц
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">матрица b</param>
        /// <returns>новая матрица</returns>
        /// <exception cref="Exception">если матрицы не равны</exception>
        public static Matrix operator -(Matrix a, Matrix b) {
            bool isSameSize = a.N == b.N && a.M == b.M;
            if (!isSameSize) throw new Exception("Невозможно сложить матрицы не одинаковых размеров");

            Matrix c = new Matrix(a.N, b.M);
            for (int j = 0; j < b.M; j++) {
                for (int i = 0; i < a.N; i++) {
                    c[i, j] = a[i, j] - b[i, j];
                }
            }
            return c;
        }

        /// <summary>
        /// Операция умножения матриц
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">матрица b</param>
        /// <returns>новая матрица</returns>
        /// <exception cref="Exception">если число столбцов в первом сомножителе не равно числу строк во втором</exception>
        public static Matrix operator *(Matrix a, Matrix b) {
            if (a.M != b.N) throw new Exception("Число столбцов в первом сомножителе должно быть равно числу строк во втором");

            Matrix c = new Matrix(a.N, b.M);
            for (int i = 0; i < c.N; i++) {
                for (int j = 0; j < c.M; j++) {
                    double s = 0;
                    for (int m = 0; m < a.M; m++) {
                        s += a[i, m] * b[m, j];
                    }
                    c[i, j] = s;
                }
            }
            return c;
        }

        /// <summary>
        /// Операция умножения матриц
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">число</param>
        /// <returns>новая матрица</returns>
        /// <exception cref="Exception">если число столбцов в первом сомножителе не равно числу строк во втором</exception>
        public static Matrix operator *(Matrix a, double b) {
            Matrix c = new Matrix(a.N, a.M);
            for (int j = 0; j < c.M; j++) {
                for (int i = 0; i < c.N; i++) {
                    c[i, j] = a[i, j] * b;
                }
            }
            return c;
        }

        /// <summary>
        /// Умножает каждый элемент матрицы на число b
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">число b</param>
        /// <returns>новая матрица</returns>
        public static Matrix operator *(double b, Matrix a) {
            Matrix c = new Matrix(a.N, a.M);
            for (int j = 0; j < c.M; j++) {
                for (int i = 0; i < c.N; i++) {
                    c[i, j] = a[i, j] * b;
                }
            }
            return c;
        }

        /// <summary>
        /// Возводит в степень b матрицу a
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">число b</param>
        /// <returns>новая матрица</returns>
        public static Matrix operator ^(Matrix a, int b) {
            Matrix c;
            if (b == 0) {
                c = new Matrix(a.M, true);
                return c;
            }

            c = (Matrix)a.Clone();
            if (b < 0) c = c.Inverse();
            int n = Math.Abs(b);
            for (int i = 1; i < n; i++) {
                c *= c;
            }
            return c;
        }

        /// <summary>
        /// Проверяем квадратная ли матрица
        /// </summary>
        /// <returns>True - матрица квадратная, false - матрица не квадратная</returns>
        public bool IsSquare() {
            return M == N;
        }

        /// <summary>
        /// Транспонирование матрицы
        /// </summary>
        /// <returns>новая матрица</returns>
        public Matrix Transpose() {
            double[,] newData = new double[M, N];
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    newData[i, j] = _data[j, i];
                }
            }
            return new Matrix(newData);
        }

        /// <summary>
        /// Нахождение определителя
        /// </summary>
        /// <returns>определитель</returns>
        /// <exception cref="Exception">если матрица не квадратная</exception>
        public double Determinant() {
            if (!IsSquare()) throw new Exception("Матрица должна быть квадратной для нахождения определителя");
            return CalculateDeterminant(_data);
        }

        /// <summary>
        /// Нахождение обратной матрицу
        /// </summary>
        /// <returns>новая матрица</returns>
        /// <exception cref="Exception">если матрица не квадратная</exception>
        public Matrix Inverse() {
            if (!IsSquare()) throw new Exception("Для приведения матрицы к обратной матрица должна быть квадратной");
            Matrix reverseMatrix = new Matrix(N);
            int stdout = GaussEliminationForward(this, out var e, out var p, out var u);
            if (stdout != 0) throw new Exception("Матрица не может быть приведена к обратной");
            GaussEliminationBackward(u, e * p, out reverseMatrix);
            return reverseMatrix;
        }

        /// <summary>
        /// Конвертация матрицу в строчный вид
        /// </summary>
        /// <returns>строчный вид матрицы</returns>
        public override string ToString() {
            string s = "";
            for (int j = 0; j < M; j++) {
                for (int i = 0; i < N; i++) {
                    s += ($"{_data[i, j]:0.00}  ");
                }
                s += ("\n");
            }
            return s;
        }

        /// <summary>
        /// Клонирование матрицы
        /// </summary>
        /// <returns>новая матрица</returns>
        public object Clone() {
            return new Matrix((double[,])_data.Clone());
        }

        /// <summary>
        /// Рекурсивный способ нахождение определителя (взято из интернета)
        /// </summary>
        /// <returns>Определитель</returns>
        private double CalculateDeterminant(double[,] M) {
            if (M.GetLength(0) == 1) return M[0, 0];

            double determinant = 0;
            int R = M.GetLength(0);
            int i = 0;
            for (int j = 0; j < R; j++) {
                double[,] T = new double[R - 1, R - 1];
                for (int ii = 0; ii < R - 1; ii++) {
                    for (int jj = 0; jj < R - 1; jj++) {
                        int iii = (ii < i) ? (ii) : (ii + 1);
                        int jjj = (jj < j) ? (jj) : (jj + 1);
                        T[ii, jj] = M[iii, jjj];
                    }
                    determinant += (((i + j) % 2 == 0) ? 1 : -1) * M[i, j] * CalculateDeterminant(T);
                }
            }
            return determinant;
        }

        /// <summary>
        /// Функция необхадимая для вычисения обратной матрицы (взято из интернета)
        /// </summary>
        private static int GaussEliminationForward(Matrix a, out Matrix e, out Matrix p, out Matrix u) {
            e = new Matrix(a.N, true);
            p = new Matrix(a.N, true);
            u = (Matrix)a.Clone();
            for (int i = 0; i < a.N; i++) {
                if (Math.Abs(u[i, i]) < Double.Epsilon) {
                    int iReverse = i;
                    for (int j = i + 1; j < a.N; j++) {
                        if (Math.Abs(u[j, i]) > Double.Epsilon) {
                            iReverse = j;
                            break;
                        }
                    }

                    if (iReverse == i) {
                        return -1;
                    }
                    e.ExchangeRows(iReverse, i, i);
                    p.ExchangeRows(iReverse, i);
                    u.ExchangeRows(iReverse, i);
                }
                Matrix eTmp = new Matrix(a.N, true);
                for (int j = i + 1; j < a.N; j++) {
                    double coeff = u[j, i] / u[i, i];
                    eTmp[j, i] = -coeff;
                    for (int k = i; k < a.M; k++) {
                        u[j, k] -= u[i, k] * coeff;
                    }
                }
                e = eTmp * e;
            }
            return 0;
        }

        /// <summary>
        /// Функция необхадимая для вычисения обратной матрицы (взято из интернета)
        /// </summary>
        private void GaussEliminationBackward(Matrix u, Matrix c, out Matrix x) {
            x = (Matrix)c.Clone();
            for (int i = x.N - 1; i >= 0; i--) {
                for (int j = 0; j < x.M; j++) {
                    x[i, j] /= u[i, i];
                }
                for (int j = 0; j < i; j++) {
                    double coeff = u[j, i];
                    for (int k = 0; k < x.M; k++) {
                        x[j, k] -= coeff * x[i, k];
                    }
                }
            }
        }

        /// <summary>
        /// Функция необхадимая для вычисения обратной матрицы (взято из интернета)
        /// </summary>
        private void ExchangeRows(int i, int j, int until = Int32.MaxValue) {
            until = Math.Min(M, until);
            for (int k = 0; k < until; k++) {
                (_data[i, k], _data[j, k]) = (_data[j, k], _data[i, k]);
            }
        }
    }
}
