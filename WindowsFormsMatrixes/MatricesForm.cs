using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibraryMatrices;

namespace WindowsFormsMatrixes {
    public partial class MatricesForm : Form {
        public MatricesForm() {
            InitializeComponent();
        }

        #region Конвертация текста в матрицу
        private static Matrix ConvertStringToMatrix(string s) {
            string input = Regex.Replace(s, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
            (int N, int M) = GetMatrixSize(s);

            double[,] adjMatrix = new double[N, M];
            int i = 0, j = 0;
            foreach (string line in input.Split('\n')) {
                foreach (string el in line.Trim().Split(' ')) {
                    adjMatrix[i, j] = double.Parse(el);
                    j++;
                }
                j = 0;
                i++;
            }

            return new Matrix(adjMatrix);
        }

        private static (int N, int M) GetMatrixSize(string s) {
            string input = Regex.Replace(s, @"^\s*$\n|\r", string.Empty, RegexOptions.Multiline).TrimEnd();
            int N = input.Split('\n').Length;
            int M = input.Split('\n')[0].Trim().Split(' ').Length;
            return (N, M);
        }
        #endregion

        #region МатрицаA
        private void PrintErrorA(string message) {
            ErrorA.Text = message;
        }

        private void ClearErrorA() {
            ErrorA.Text = "";
        }

        private void PrintErrorB(string message) {
            ErrorB.Text = message;
        }

        private void ClearErrorB() {
            ErrorB.Text = "";
        }

        private void GenerateA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                int N = Math.Abs(int.Parse(MatrixANInput.Text));
                int M = Math.Abs(int.Parse(MatrixAMInput.Text));
                MatrixANInput.Text = N.ToString();
                MatrixAMInput.Text = M.ToString();
                Matrix newMatrix = new Matrix(N, M, new Random());
                MatrixAInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("N и M целые должны быть целыми числами");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void ClearA_Click(object sender, EventArgs e) {
            ClearErrorA();
            MatrixAInput.Clear();
        }

        private void TransponseA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                Matrix transponsedMatrix = ConvertStringToMatrix(MatrixAInput.Text).Transpose();
                MatrixAInput.Text = transponsedMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void DeterminantA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                double determinant = ConvertStringToMatrix(MatrixAInput.Text).Determinant();
                MessageBox.Show($"Определитель матрицы: {determinant:0.00}", "Определитель");
            } catch (FormatException err) {
                PrintErrorA("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void MultiplyA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                double multiplier = double.Parse(MatrixAMultiplierInput.Text);
                Matrix newMatrix = ConvertStringToMatrix(MatrixAInput.Text) * multiplier;
                MatrixAInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицу и множитель в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void RaistoToPowerA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                int argument = int.Parse(MatrixAArumentInput.Text);
                Matrix newMatrix = ConvertStringToMatrix(MatrixAInput.Text) ^ argument;
                MatrixAArumentInput.Text = argument.ToString();
                MatrixAInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите аргумент и матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }

        private void ReverseA_Click(object sender, EventArgs e) {
            ClearErrorA();
            try {
                Matrix inversedMatrix = ConvertStringToMatrix(MatrixAInput.Text).Inverse();
                MatrixAInput.Text = inversedMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
            }
        }
        #endregion

        #region МатрицаB
        private void GenerateB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                int N = Math.Abs(int.Parse(MatrixBNInput.Text));
                int M = Math.Abs(int.Parse(MatrixBMInput.Text));
                MatrixBNInput.Text = N.ToString();
                MatrixBMInput.Text = M.ToString();
                Matrix newMatrix = new Matrix(N, M, new Random());
                MatrixBInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("N и M целые должны быть целыми числами");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void ClearB_Click(object sender, EventArgs e) {
            ClearErrorB();
            MatrixBInput.Clear();
        }

        private void TransponseB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                Matrix transponsedMatrix = ConvertStringToMatrix(MatrixBInput.Text).Transpose();
                MatrixBInput.Text = transponsedMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void DeterminantB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                double determinant = ConvertStringToMatrix(MatrixBInput.Text).Determinant();
                MessageBox.Show($"Определитель матрицы: {determinant:0.00}", "Определитель");
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void MultiplyB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                double multiplier = double.Parse(MatrixBMultiplierInput.Text);
                Matrix newMatrix = ConvertStringToMatrix(MatrixBInput.Text) * multiplier;
                MatrixBInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу и множитель в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void RaistoToPowerB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                int argument = int.Parse(MatrixBArumentInput.Text);
                Matrix newMatrix = ConvertStringToMatrix(MatrixBInput.Text) ^ argument;
                MatrixBArumentInput.Text = argument.ToString();
                MatrixBInput.Text = newMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу и аргумент в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }

        private void ReverseB_Click(object sender, EventArgs e) {
            ClearErrorB();
            try {
                Matrix inversedMatrix = ConvertStringToMatrix(MatrixBInput.Text).Inverse();
                MatrixBInput.Text = inversedMatrix.ToString();
            } catch (FormatException err) {
                PrintErrorB("Введите матрицу в правильном формате");
            } catch (Exception err) {
                PrintErrorB(err.Message);
            }
        }
        #endregion

        #region Операции между матрицами A и B
        private void FromRightToLeft_Click(object sender, EventArgs e) {
            MatrixAInput.Text = MatrixBInput.Text;
        }

        private void FromLeftToRight_Click(object sender, EventArgs e) {
            MatrixBInput.Text = MatrixAInput.Text;
        }

        private void Swap_Click(object sender, EventArgs e) {
            string tmp = ErrorA.Text;
            ErrorA.Text = ErrorB.Text;
            ErrorB.Text = tmp;
            tmp = MatrixAInput.Text;
            MatrixAInput.Text = MatrixBInput.Text;
            MatrixBInput.Text = tmp;
        }

        private void Sum_Click(object sender, EventArgs e) {
            ClearErrorA();
            ClearErrorB();
            try {
                Matrix a = ConvertStringToMatrix(MatrixAInput.Text);
                Matrix b = ConvertStringToMatrix(MatrixBInput.Text);
                Matrix c = a + b;
                MatrixOutput.Text = c.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицы в правильном формате");
                PrintErrorB("Введите матрицы в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
                PrintErrorB(err.Message);
            }
        }

        private void Subtraction_Click(object sender, EventArgs e) {
            ClearErrorA();
            ClearErrorB();
            try {

                Matrix a = ConvertStringToMatrix(MatrixAInput.Text);
                Matrix b = ConvertStringToMatrix(MatrixBInput.Text);
                Matrix c = a - b;
                MatrixOutput.Text = c.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицы в правильном формате");
                PrintErrorB("Введите матрицы в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
                PrintErrorB(err.Message);
            }
        }

        private void Multiplication_Click(object sender, EventArgs e) {
            ClearErrorA();
            ClearErrorB();
            try {
                Matrix a = ConvertStringToMatrix(MatrixAInput.Text);
                Matrix b = ConvertStringToMatrix(MatrixBInput.Text);
                Matrix c = a * b;
                MatrixOutput.Text = c.ToString();
            } catch (FormatException err) {
                PrintErrorA("Введите матрицы в правильном формате");
                PrintErrorB("Введите матрицы в правильном формате");
            } catch (Exception err) {
                PrintErrorA(err.Message);
                PrintErrorB(err.Message);
            }
        }
        #endregion

        #region Вспомогательные кнопки
        private void InsertResultInA_Click(object sender, EventArgs e) {
            MatrixAInput.Text = MatrixOutput.Text;
            MatrixOutput.Clear();
        }

        private void InsertResultInB_Click(object sender, EventArgs e) {
            MatrixBInput.Text = MatrixOutput.Text;
            MatrixOutput.Clear();
        }

        private void Reference_Click(object sender, EventArgs e) {
            string s = "C помощью этого калькулятора вы сможете:\n" +
                "получить определитель матрицы, возводить её в степень,\n" +
                "найти сумму и произведение матриц, вычислить обратную матрицу.\n" +
                "Заполните поля для элементов матрицы и нажмите соответствующую кнопку.";
            s += "Формат ввода матрицы вручную.\n";
            s += "1 2 3 10\n";
            s += "3 0 5 7\n";
            s += "0 4 6 12\n";
            s += "Через пробел.";
            MessageBox.Show(s);
        }
        #endregion

        #region Проверка введённого текста
        private void OnlyNumbers(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != ' ') && (e.KeyChar != '-')) {
                e.Handled = true;
            }
        }

        private void OnlyIntNumbers(object sender, KeyPressEventArgs e) {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ' ') && (e.KeyChar != '-')) {
                e.Handled = true;
            }
        }
        #endregion
    }
}
