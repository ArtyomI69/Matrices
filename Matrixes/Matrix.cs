using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryMatrices {
    public class Matrix : ICloneable, IEquatable<Matrix> {
        #region Поля
        /// <summary>
        /// Двоичный массив, представляющий матрицу
        /// </summary>
        private double[,] _data;

        /// <summary>
        /// Кол-во рядов матрицы
        /// </summary>
        public int N => _data.GetLength(0);

        /// <summary>
        /// Кол-во столбцов матрицы
        /// </summary>
        public int M => _data.GetLength(1);

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
            if (!IsSameSize(a, b)) throw new Exception("Невозможно сложить матрицы не одинаковых размеров");

            Matrix c = new Matrix(a.N, b.M);

            for (int i = 0; i < c.N; i++) {
                for (int j = 0; j < c.M; j++) {
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
            if (!IsSameSize(a, b)) throw new Exception("Невозможно сложить матрицы не одинаковых размеров");

            Matrix c = new Matrix(a.N, b.M);
            for (int i = 0; i < c.N; i++) {
                for (int j = 0; j < c.M; j++) {
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
            return CoppersmithWinograd(a, b);
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
            for (int i = 0; i < c.N; i++) {
                for (int j = 0; j < c.M; j++) {
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
            return a * b;
        }

        /// <summary>
        /// Возводит в степень b матрицу a
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">число b</param>
        /// <returns>новая матрица</returns>
        public static Matrix operator ^(Matrix matrix, int power) {
            return FastMatrixExponentiation(matrix, power);
        }
        #endregion

        #region Умножение
        /// <summary>
        /// Стандартный способ умножения матрицы
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">матрица b</param>
        /// <returns>результат умножения матриц a и b</returns>
        /// <exception cref="Exception">Если число столбцов в первом сомножителе не равно числу строк во втором</exception>
        public static Matrix MultiplyMatrices(Matrix a, Matrix b) {
            if (a.M != b.N) throw new Exception("Число столбцов в первом сомножителе должно быть равно числу строк во втором");

            Matrix c = new Matrix(a.N, b.M);
            for (int i = 0; i < a.N; i++) {
                for (int j = 0; j < b.M; j++) {
                    for (int k = 0; k < b.N; k++) {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }
            }

            return c;
        }

        /// <summary>
        /// Умножения матрицы методом Копперсмита-Винограда
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">матрица b</param>
        /// <returns>результат умножения матриц a и b</returns>
        /// <exception cref="Exception">Если число столбцов в первом сомножителе не равно числу строк во втором</exception>
        public static Matrix CoppersmithWinograd(Matrix matrix1, Matrix matrix2) {
            int rows1 = matrix1.N;
            int cols1 = matrix1.M;
            int rows2 = matrix2.N;
            int cols2 = matrix2.M;

            if (cols1 != rows2)
                throw new Exception("Число столбцов в первом сомножителе должно быть равно числу строк во втором");

            double[] rowFactor = new double[rows1];
            double[] colFactor = new double[cols2];

            // Высчитываем rowFactor
            for (int i = 0; i < rows1; i++) {
                for (int j = 0; j < cols1 / 2; j++) {
                    rowFactor[i] += matrix1[i, j * 2] * matrix1[i, j * 2 + 1];
                }
            }

            // Высчитываем colFactor
            for (int i = 0; i < cols2; i++) {
                for (int j = 0; j < rows2 / 2; j++) {
                    colFactor[i] += matrix2[j * 2, i] * matrix2[j * 2 + 1, i];
                }
            }

            double[,] result = new double[rows1, cols2];

            // Высчитываем результат
            for (int i = 0; i < rows1; i++) {
                for (int j = 0; j < cols2; j++) {
                    result[i, j] = -rowFactor[i] - colFactor[j];

                    for (int k = 0; k < cols1 / 2; k++) {
                        result[i, j] += (matrix1[i, 2 * k + 1] + matrix2[2 * k, j]) * (matrix1[i, 2 * k] + matrix2[2 * k + 1, j]);
                    }
                }
            }

            // Продолжаем вычисиление если матрица не чётна
            if (cols1 % 2 == 1) {
                for (int i = 0; i < rows1; i++) {
                    for (int j = 0; j < cols2; j++) {
                        result[i, j] += matrix1[i, cols1 - 1] * matrix2[rows2 - 1, j];
                    }
                }
            }

            return new Matrix(result);
        }

        /// <summary>
        /// Умножения матрицы методом Штрассена
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">матрица b</param>
        /// <returns>результат умножения матриц a и b</returns>
        /// <exception cref="Exception">Если матрицы не квадратны или не равны по размерам или размер не является степенью 2</exception>
        public static Matrix Strassen(Matrix a, Matrix b) {
            int n = a.N;

            if (!IsSameSize(a, b) || n > 0 && (n & (n - 1)) != 0)
                throw new Exception("Матрицы должны быть квадратны, равны по размерам и размер является степенью 2");

            Matrix result = new Matrix(n, n);

            // Базовый случай - матрицы 1x1
            if (n == 1) {
                result[0, 0] = a[0, 0] * b[0, 0];
                return result;
            }

            // Разбиваем матрицы на подматрицы
            Matrix a11 = new Matrix(n / 2, n / 2);
            Matrix a12 = new Matrix(n / 2, n / 2);
            Matrix a21 = new Matrix(n / 2, n / 2);
            Matrix a22 = new Matrix(n / 2, n / 2);

            Matrix b11 = new Matrix(n / 2, n / 2);
            Matrix b12 = new Matrix(n / 2, n / 2);
            Matrix b21 = new Matrix(n / 2, n / 2);
            Matrix b22 = new Matrix(n / 2, n / 2);

            SplitMatrix(a, a11, a12, a21, a22);
            SplitMatrix(b, b11, b12, b21, b22);

            // Вычисляем 7 промежуточных матриц
            Matrix p1 = Strassen(a11, b12 - b22);
            Matrix p2 = Strassen(a11 + a12, b22);
            Matrix p3 = Strassen(a21 + a22, b11);
            Matrix p4 = Strassen(a22, b21 - b11);
            Matrix p5 = Strassen(a11 + a22, b11 + b22);
            Matrix p6 = Strassen(a12 - a22, b21 + b22);
            Matrix p7 = Strassen(a11 - a21, b11 + b12);

            // Собираем результат из 4 подматриц
            Matrix c11 = p5 + p4 - p2 + p6;
            Matrix c12 = p1 + p2;
            Matrix c21 = p3 + p4;
            Matrix c22 = p5 + p1 - p3 - p7;

            JoinMatrices(c11, c12, c21, c22, result);

            return result;
        }

        // Функция разбивает матрицу на 4 подматрицы
        public static void SplitMatrix(Matrix matrix, Matrix a11, Matrix a12, Matrix a21, Matrix a22) {
            int n = matrix.N;

            for (int i = 0; i < n / 2; i++) {
                for (int j = 0; j < n / 2; j++) {
                    a11[i, j] = matrix[i, j];
                    a12[i, j] = matrix[i, j + n / 2];
                    a21[i, j] = matrix[i + n / 2, j];
                    a22[i, j] = matrix[i + n / 2, j + n / 2];
                }
            }
        }

        // Функция объединяет 4 подматрицы в одну матрицу
        public static void JoinMatrices(Matrix a11, Matrix a12, Matrix a21, Matrix a22, Matrix result) {
            int n = a11.N;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < n; j++) {
                    result[i, j] = a11[i, j];
                    result[i, j + n] = a12[i, j];
                    result[i + n, j] = a21[i, j];
                    result[i + n, j + n] = a22[i, j];
                }
            }
        }
        #endregion

        #region Возведение в степень
        /// <summary>
        /// Стандартный способ возведение матрицы
        /// </summary>
        /// <param name="matrix">матрица возводимая в степень</param>
        /// <param name="power">аргуемент степени</param>
        /// <returns>результат возведения матрицы в степень</returns>
        /// <exception cref="Exception">Если матрица не квадратная</exception>
        public static Matrix MatrixExponentiation(Matrix matrix, int power) {
            if (!matrix.IsSquare()) throw new Exception("Матрица должна быть квадратной для возведения в степень");
            if (power < 0) {
                matrix = matrix.Inverse();
                power = Math.Abs(power);
            }

            if (power == 0) return new Matrix(matrix.M, true);

            Matrix res = (Matrix)matrix.Clone();
            for (int i = 1; i < power; i++) {
                res *= matrix;
            }
            return res;
        }

        /// <summary>
        /// Быстрый метод возведения матрицы в степень
        /// </summary>
        /// <param name="matrix">матрица возводимая в степень</param>
        /// <param name="power">аргуемент степени</param>
        /// <returns>результат возведения матрицы в степень</returns>
        /// <exception cref="Exception">Если матрица не квадратная</exception>
        public static Matrix FastMatrixExponentiation(Matrix matrix, int power) {
            if (!matrix.IsSquare()) throw new Exception("Матрица должна быть квадратной для возведения в степень");
            if (power < 0) {
                matrix = matrix.Inverse();
                power = Math.Abs(power);
            }

            if (power == 0) {
                // Возврат единичной матрицы
                int size = matrix.N;
                Matrix result = new Matrix(size, true);
                return result;
            } else if (power % 2 == 0) {
                // Возврат квадрата матрицы, возведенной в степень power / 2
                Matrix halfPowerMatrix = FastMatrixExponentiation(matrix, power / 2);
                return MultiplyMatrices(halfPowerMatrix, halfPowerMatrix);
            } else {
                // Возврат произведения матрицы и матрицы, возведенной в степень power - 1
                Matrix halfPowerMatrix = FastMatrixExponentiation(matrix, (power - 1) / 2);
                Matrix squaredHalfPowerMatrix = MultiplyMatrices(halfPowerMatrix, halfPowerMatrix);
                return MultiplyMatrices(matrix, squaredHalfPowerMatrix);
            }
        }
        #endregion

        #region Обратная матрица
        /// <summary>
        /// Получения обратной матрицы методом Гаусса
        /// </summary>
        /// <returns>Обратная матрица</returns>
        /// <exception cref="Exception">Есши матрица не квадратная</exception>
        public Matrix Inverse() {
            if (!IsSquare()) throw new Exception("Матрица должна быть квадратной для нахождение обратной");

            double[,] augmentedMatrix = new double[N, 2 * N];

            // Создаём расширенную матрицу
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    augmentedMatrix[i, j] = _data[i, j];
                }
                augmentedMatrix[i, i + N] = 1;
            }

            // Выполняем операции со строками, чтобы получить единичную матрицу слева.
            for (int i = 0; i < N; i++) {
                // Разделить текущую строку на опорный элемент
                double pivot = augmentedMatrix[i, i];
                for (int j = i; j < 2 * N; j++) {
                    augmentedMatrix[i, j] /= pivot;
                }

                // Вычитаем текущую строку из всех других строк, чтобы получить нули ниже точки поворота.
                for (int j = 0; j < N; j++) {
                    if (j != i) {
                        double factor = augmentedMatrix[j, i];
                        for (int k = i; k < 2 * N; k++) {
                            augmentedMatrix[j, k] -= factor * augmentedMatrix[i, k];
                        }
                    }
                }
            }

            // Извликаем обратную матрицу из расширенной матрицы
            double[,] inverseMatrix = new double[N, N];
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < N; j++) {
                    inverseMatrix[i, j] = augmentedMatrix[i, j + N];
                }
            }

            return new Matrix(inverseMatrix);
        }
        #endregion

        #region Определитель
        /// <summary>
        /// Нахождение определителя по методу Гаусса
        /// </summary>
        /// <returns>определитель</returns>
        /// <exception cref="Exception">если матрица не квадратная</exception>
        public double Determinant() {
            double determinant = 1;
            Matrix copyMatrix = (Matrix)Clone();

            // Преобразование матрицы к верхнеугольной форме
            for (int i = 0; i < N; i++) {
                int maxRow = i;

                for (int j = i + 1; j < N; j++) {
                    if (Math.Abs(copyMatrix[j, i]) > Math.Abs(copyMatrix[maxRow, i])) {
                        maxRow = j;
                    }
                }

                if (maxRow != i) {
                    for (int j = 0; j < N; j++) {
                        double temp = copyMatrix[i, j];
                        copyMatrix[i, j] = copyMatrix[maxRow, j];
                        copyMatrix[maxRow, j] = temp;
                    }
                    determinant *= -1;
                }

                for (int j = i + 1; j < N; j++) {
                    double factor = copyMatrix[j, i] / copyMatrix[i, i];

                    for (int k = i + 1; k < N; k++) {
                        copyMatrix[j, k] -= factor * copyMatrix[i, k];
                    }

                    copyMatrix[j, i] = 0;
                }
            }

            // Умножение элементов главной диагонали
            for (int i = 0; i < N; i++) {
                determinant *= copyMatrix[i, i];
            }

            return determinant;
        }
        #endregion

        #region Вспомогательные методы
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
        /// Проверяем квадратная ли матрица
        /// </summary>
        /// <returns>True - матрица квадратная, false - матрица не квадратная</returns>
        public bool IsSquare() {
            return N == M;
        }

        /// <summary>
        /// Проверяем одинаковы ли матрицы по размерам
        /// </summary>
        /// <param name="a">матрица a</param>
        /// <param name="b">матрица b</param>
        /// <returns>True - матрицы одинаковы по размерам, false - иначе</returns>
        public static bool IsSameSize(Matrix a, Matrix b) {
            return a.N == b.N && a.M == b.M;
        }

        /// <summary>
        /// Сравнивает матрицу с другой
        /// </summary>
        /// <param name="matrix2">матрица для сравнения</param>
        /// <returns>True - если матрицы равны, false - иначе</returns>
        public bool Equals(Matrix matrix2) {
            bool equal =
         _data.Rank == matrix2._data.Rank &&
        Enumerable.Range(0, _data.Rank).All(dimension => _data.GetLength(dimension) == matrix2._data.GetLength(dimension)) &&
        _data.Cast<double>().SequenceEqual(matrix2._data.Cast<double>());
            return equal;
        }

        /// <summary>
        /// Конвертация матрицу в строчный вид
        /// </summary>
        /// <returns>строчный вид матрицы</returns>
        public override string ToString() {
            string s = "";
            for (int i = 0; i < N; i++) {
                for (int j = 0; j < M; j++) {
                    s += ($"{_data[i, j]:0.00} ");
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
    }
}
