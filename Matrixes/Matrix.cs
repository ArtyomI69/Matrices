using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMatrices {
    public class Matrix : ICloneable {
        #region Поля
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

        public ref double this[int row, int column] => ref _data[row, column];
        #endregion

        #region Конструкторы
        /// <summary>
        /// Создаёт квадратную матрицу размера n
        /// </summary>
        /// <param name="n">размер матрицы</param>
        /// <param name="diagonal">если diagonal == true создаёт матрицу где значения диагонали 1</param>
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
                    _data[i, j] = r.Next(-9, 9);
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
        #endregion

        #region Операции
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

            double[,] ans = new double[b.N, a.M];
            for (int i = 0; i < b.M; i++) {
                for (int j = 0; j < a.N; j++) {
                    for (int k = 0; k < a.M; k++) {
                        ans[i, j] += b[i, k] * a[k, j];
                    }
                }
            }
            return new Matrix(ans);
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
        #endregion

        #region Public Методы
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
            return CalculateDeterminant(this);
        }

        /// <summary>
        /// Нахождение обратной матрицу
        /// </summary>
        /// <returns>новая матрица</returns>
        /// <exception cref="Exception">если матрица не квадратная</exception>
        public Matrix Inverse() {
            if (!IsSquare()) throw new Exception("Для приведения матрицы к обратной матрица должна быть квадратной");

            if (Math.Abs(Determinant()) <= 0.000000001) throw new ArgumentException("Обратная матрица не существует!");
            double k = 1 / Determinant();
            Matrix minorMatrix = MinorMatrix();
            return minorMatrix.Transpose() * k;
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
        #endregion

        #region Private Методы
        /// <summary>
        /// Рекурсивный способ нахождение определителя (взято из интернета)
        /// </summary>
        /// <returns>Определитель</returns>
        private double CalculateDeterminant(Matrix m) {
            if (m.N == 1) return m[0, 0];

            double det = 0;
            int length = m.M;

            if (length == 1) det = m._data[0, 0];
            if (length == 2) det = m._data[0, 0] * m._data[1, 1] - m._data[0, 1] * m._data[1, 0];

            if (length > 2)
                for (int i = 0; i < m.N; i++)
                    det += Math.Pow(-1, 0 + i) * m._data[0, i] * CalculateDeterminant(m.GetMinor(0, i));
            return det;
        }

        /// <summary>
        /// Получение минора матрицы.
        /// </summary>
        /// <param name="row"> индекс строки </param>
        /// <param name="column"> индекс столбца </param>
        /// <returns> минор матрицы </returns>
        private Matrix GetMinor(int row, int column) {
            double[,] minor = new double[M - 1, N - 1];
            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if ((i != row) || (j != column)) {
                        if (i > row && j < column) minor[i - 1, j] = _data[i, j];
                        if (i < row && j > column) minor[i, j - 1] = _data[i, j];
                        if (i > row && j > column) minor[i - 1, j - 1] = _data[i, j];
                        if (i < row && j < column) minor[i, j] = _data[i, j];
                    }
                }
            }
            return new Matrix(minor);
        }

        /// <summary>
        /// Поиск матрицы миноров (алгебраических дополнений)
        /// </summary>
        /// <returns> матрица миноров </returns>
        public Matrix MinorMatrix() {
            double[,] ans = new double[M, N];

            for (int i = 0; i < M; i++)
                for (int j = 0; j < N; j++)
                    ans[i, j] = Math.Pow(-1, i + j) * CalculateDeterminant(GetMinor(i, j));

            return new Matrix(ans);
        }
        #endregion
    }
}
